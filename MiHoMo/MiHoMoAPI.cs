using MiHoMo.Models.Achievements;
using MiHoMo.Models.Avatars;
using MiHoMo.Models.CharacterPromotions;
using MiHoMo.Models.CharacterRanks;
using MiHoMo.Models.Characters;
using MiHoMo.Models.CharacterSkills;
using MiHoMo.Models.CharacterSkillTrees;
using MiHoMo.Models.Descriptions;
using MiHoMo.Models.Elements;
using MiHoMo.Models.Items;
using MiHoMo.Models.LightConePromotions;
using MiHoMo.Models.LightConeRanks;
using MiHoMo.Models.LightCones;
using MiHoMo.Models.Nicknames;
using MiHoMo.Models.Origin;
using MiHoMo.Models.Parsed;
using MiHoMo.Models.Paths;
using MiHoMo.Models.Properties;
using MiHoMo.Models.RelicMainAffixes;
using MiHoMo.Models.Relics;
using MiHoMo.Models.RelicSets;
using MiHoMo.Models.RelicSubAffixes;
using MiHoMo.Models.SimulatedBlessings;
using MiHoMo.Models.SimulatedBlocks;
using MiHoMo.Models.SimulatedCurios;
using MiHoMo.Models.SimulatedEvents;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiHoMo
{
	/// <summary>
	/// MiHoMo API
	/// </summary>
	public class MiHoMoAPI : IDisposable
	{
		#region 构造函数

		private readonly HttpClient _httpClient;

		private readonly string _apiBaseUrl;

		private readonly string _indexBaseUrl;

		private readonly string _indexName;

		private readonly string _indexLanguage;

		/// <summary>
		/// 创建 MiHoMo API
		/// </summary>
		/// <param name="handler">Http客户端处理器<br/>由于绝大多数资源都在 Github ，访问可能较慢，可以通过 HttpClientHandler 设置代理</param>
		/// <param name="apiBaseUrl">API基础Url</param>
		/// <param name="indexBaseUrl">索引资源基础Url</param>
		/// <param name="indexName">索引名称，可以为 index_min / index_new<br/>推荐使用 index_min 以提高加载速度</param>
		/// <param name="indexLanguage">索引语言，可以为 cht / cn / de / en / es / fr / id / jp / kr / pt / ru / th / vi</param>
		public MiHoMoAPI(
			HttpClientHandler handler = null,
			string apiBaseUrl = "https://api.mihomo.me",
			string indexBaseUrl = "https://github.com/Mar-7th/StarRailRes/raw/master",
			string indexName = "index_min",
			string indexLanguage = "cn"
			)
		{
			_httpClient = handler == null ? new() : new(handler);
			_apiBaseUrl = apiBaseUrl;
			_indexBaseUrl = indexBaseUrl;
			_indexName = indexName;
			_indexLanguage = indexLanguage;
		}

		#endregion

		#region 通用

		/// <summary>
		/// 从网络获取资源作为流
		/// </summary>
		/// <param name="path">资源路径<br/>例如：icon/element/Physical.png</param>
		/// <returns>从网络获取资源作为流任务</returns>
		public async Task<Stream> GetResourceAsStreamAsync(string path)
		{
			var response = await _httpClient.GetAsync(path);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStreamAsync();
		}

		/// <summary>
		/// 从网络获取资源作为字节数组
		/// </summary>
		/// <param name="path">资源路径<br/>例如：icon/element/Physical.png</param>
		/// <returns>从网络获取资源作为字节数组任务</returns>
		public async Task<byte[]> GetResourceAsByteArrayAsync(string path)
		{
			var response = await _httpClient.GetAsync(path);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsByteArrayAsync();
		}

		/// <summary>
		/// 从网络获取资源作为字符串
		/// </summary>
		/// <param name="path">资源路径<br/>例如：icon/element/Physical.png</param>
		/// <returns>从网络获取资源作为字符串任务</returns>
		public async Task<string> GetResourceAsStringAsync(string path)
		{
			var response = await _httpClient.GetAsync(path);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}

		private async Task<T> GetDataFromUrlAsync<T>(string url)
		{
			return JsonConvert.DeserializeObject<T>(await GetResourceAsStringAsync(url));
		}

		#endregion

		#region 资源

		#region 成就

		/// <summary>
		/// 成就表
		/// </summary>
		public AchievementMap AchievementMap { get; private set; } = null;

		/// <summary>
		/// 初始化成就表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitAchievementMapAsync()
		{
			AchievementMap = await GetDataFromUrlAsync<AchievementMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/achievements.json");
		}

		#endregion

		#region 头像

		/// <summary>
		/// 头像表
		/// </summary>
		public AvatarMap AvatarMap { get; private set; } = null;

		/// <summary>
		/// 初始化头像表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitAvatarMapAsync()
		{
			AvatarMap = await GetDataFromUrlAsync<AvatarMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/avatars.json");
		}

		#endregion

		#region 角色晋阶

		/// <summary>
		/// 角色晋阶表
		/// </summary>
		public CharacterPromotionMap CharacterPromotionMap { get; private set; } = null;

		/// <summary>
		/// 初始化角色晋阶表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitCharacterPromotionMapAsync()
		{
			CharacterPromotionMap = await GetDataFromUrlAsync<CharacterPromotionMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/character_promotions.json");
		}

		#endregion

		#region 角色星魂

		/// <summary>
		/// 角色星魂表
		/// </summary>
		public CharacterRankMap CharacterRankMap { get; private set; } = null;

		/// <summary>
		/// 初始化角色星魂表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitCharacterRankMapAsync()
		{
			CharacterRankMap = await GetDataFromUrlAsync<CharacterRankMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/character_ranks.json");
		}

		#endregion

		#region 角色行迹

		/// <summary>
		/// 角色行迹表
		/// </summary>
		public CharacterSkillTreeMap CharacterSkillTreeMap { get; private set; } = null;

		/// <summary>
		/// 初始化角色行迹表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitCharacterSkillTreeMapAsync()
		{
			CharacterSkillTreeMap = await GetDataFromUrlAsync<CharacterSkillTreeMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/character_skill_trees.json");
		}

		#endregion

		#region 角色技能

		/// <summary>
		/// 角色技能表
		/// </summary>
		public CharacterSkillMap CharacterSkillMap { get; private set; } = null;

		/// <summary>
		/// 初始化角色技能表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitCharacterSkillMapAsync()
		{
			CharacterSkillMap = await GetDataFromUrlAsync<CharacterSkillMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/character_skills.json");
		}

		#endregion

		#region 角色

		/// <summary>
		/// 角色表
		/// </summary>
		public CharacterMap CharacterMap { get; private set; } = null;

		/// <summary>
		/// 初始化角色表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitCharacterMapAsync()
		{
			CharacterMap = await GetDataFromUrlAsync<CharacterMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/characters.json");
		}

		#endregion

		#region 介绍

		/// <summary>
		/// 介绍表
		/// </summary>
		public DescriptionInfoMap DescriptionInfoMap { get; private set; } = null;

		/// <summary>
		/// 初始化介绍表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitDescriptionInfoMapAsync()
		{
			DescriptionInfoMap = await GetDataFromUrlAsync<DescriptionInfoMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/descriptions.json");
		}

		#endregion

		#region 元素

		/// <summary>
		/// 元素表
		/// </summary>
		public ElementMap ElementMap { get; private set; } = null;

		/// <summary>
		/// 初始化元素表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitElementMapAsync()
		{
			ElementMap = await GetDataFromUrlAsync<ElementMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/elements.json");
		}

		#endregion

		#region 物品

		/// <summary>
		/// 物品表
		/// </summary>
		public ItemMap ItemMap { get; private set; } = null;

		/// <summary>
		/// 初始化物品表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitItemMapAsync()
		{
			ItemMap = await GetDataFromUrlAsync<ItemMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/items.json");
		}

		#endregion

		#region 光锥晋阶

		/// <summary>
		/// 光锥晋阶表
		/// </summary>
		public LightConePromotionMap LightConePromotionMap { get; private set; } = null;

		/// <summary>
		/// 初始化光锥晋阶表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitLightConePromotionMapAsync()
		{
			LightConePromotionMap = await GetDataFromUrlAsync<LightConePromotionMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/light_cone_promotions.json");
		}

		#endregion

		#region 光锥叠影

		/// <summary>
		/// 光锥叠影表
		/// </summary>
		public LightConeRankMap LightConeRankMap { get; private set; } = null;

		/// <summary>
		/// 初始化光锥叠影表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitLightConeRankMapAsync()
		{
			LightConeRankMap = await GetDataFromUrlAsync<LightConeRankMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/light_cone_ranks.json");
		}

		#endregion

		#region 光锥

		/// <summary>
		/// 光锥表
		/// </summary>
		public LightConeMap LightConeMap { get; private set; } = null;

		/// <summary>
		/// 初始化光锥表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitLightConeMapAsync()
		{
			LightConeMap = await GetDataFromUrlAsync<LightConeMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/light_cones.json");
		}

		#endregion

		#region 昵称

		/// <summary>
		/// 昵称表
		/// </summary>
		public Nickname Nickname { get; private set; } = null;

		/// <summary>
		/// 初始化昵称表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitNicknameAsync()
		{
			Nickname = await GetDataFromUrlAsync<Nickname>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/nickname.json");
		}

		#endregion

		#region 命途

		/// <summary>
		/// 命途表
		/// </summary>
		public PathInfoMap PathInfoMap { get; private set; } = null;

		/// <summary>
		/// 初始化命途表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitPathInfoMapAsync()
		{
			PathInfoMap = await GetDataFromUrlAsync<PathInfoMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/paths.json");
		}

		#endregion

		#region 词条

		/// <summary>
		/// 词条表
		/// </summary>
		public PropertyMap PropertyMap { get; private set; } = null;

		/// <summary>
		/// 初始化词条表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitPropertyMapAsync()
		{
			PropertyMap = await GetDataFromUrlAsync<PropertyMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/properties.json");
		}

		#endregion

		#region 遗器主词条

		/// <summary>
		/// 遗器主词条表
		/// </summary>
		public RelicMainAffixMap RelicMainAffixMap { get; private set; } = null;

		/// <summary>
		/// 初始化遗器主词条表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitRelicMainAffixMapAsync()
		{
			RelicMainAffixMap = await GetDataFromUrlAsync<RelicMainAffixMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/relic_main_affixes.json");
		}

		#endregion

		#region 遗器套装

		/// <summary>
		/// 遗器套装表
		/// </summary>
		public RelicSetMap RelicSetMap { get; private set; } = null;

		/// <summary>
		/// 初始化遗器套装表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitRelicSetMapAsync()
		{
			RelicSetMap = await GetDataFromUrlAsync<RelicSetMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/relic_sets.json");
		}

		#endregion

		#region 遗器副词条

		/// <summary>
		/// 遗器副词条表
		/// </summary>
		public RelicSubAffixMap RelicSubAffixMap { get; private set; } = null;

		/// <summary>
		/// 初始化遗器副词条表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitRelicSubAffixMapAsync()
		{
			RelicSubAffixMap = await GetDataFromUrlAsync<RelicSubAffixMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/relic_sub_affixes.json");
		}

		#endregion

		#region 遗器

		/// <summary>
		/// 遗器表
		/// </summary>
		public RelicMap RelicMap { get; private set; } = null;

		/// <summary>
		/// 初始化遗器表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitRelicMapAsync()
		{
			RelicMap = await GetDataFromUrlAsync<RelicMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/relics.json");
		}

		#endregion

		#region 模拟宇宙祝福

		/// <summary>
		/// 模拟宇宙祝福表
		/// </summary>
		public SimulatedBlessingMap SimulatedBlessingMap { get; private set; } = null;

		/// <summary>
		/// 初始化模拟宇宙祝福表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitSimulatedBlessingMapAsync()
		{
			SimulatedBlessingMap = await GetDataFromUrlAsync<SimulatedBlessingMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/simulated_blessings.json");
		}

		#endregion

		#region 模拟宇宙区域

		/// <summary>
		/// 模拟宇宙区域表
		/// </summary>
		public SimulatedBlockMap SimulatedBlockMap { get; private set; } = null;

		/// <summary>
		/// 初始化模拟宇宙区域表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitSimulatedBlockMapAsync()
		{
			SimulatedBlockMap = await GetDataFromUrlAsync<SimulatedBlockMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/simulated_blocks.json");
		}

		#endregion

		#region 模拟宇宙奇物

		/// <summary>
		/// 模拟宇宙奇物表
		/// </summary>
		public SimulatedCurioMap SimulatedCurioMap { get; private set; } = null;

		/// <summary>
		/// 初始化模拟宇宙奇物表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitSimulatedCurioMapAsync()
		{
			SimulatedCurioMap = await GetDataFromUrlAsync<SimulatedCurioMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/simulated_curios.json");
		}

		#endregion

		#region 模拟宇宙事件

		/// <summary>
		/// 模拟宇宙事件表
		/// </summary>
		public SimulatedEventMap SimulatedEventMap { get; private set; } = null;

		/// <summary>
		/// 初始化模拟宇宙事件表
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitSimulatedEventMapAsync()
		{
			SimulatedEventMap = await GetDataFromUrlAsync<SimulatedEventMap>($"{_indexBaseUrl}/{_indexName}/{_indexLanguage}/simulated_events.json");
		}

		#endregion

		/// <summary>
		/// 初始化所有资源，包括成就、头像、角色晋阶等<br/>当然，你也可以根据需要选择性地初始化，从而使加载更快
		/// </summary>
		/// <returns>任务</returns>
		public async Task InitAllResourcesAsync()
		{
			await InitAchievementMapAsync();
			await InitAvatarMapAsync();
			await InitCharacterPromotionMapAsync();
			await InitCharacterRankMapAsync();
			await InitCharacterSkillTreeMapAsync();
			await InitCharacterSkillMapAsync();
			await InitCharacterMapAsync();
			await InitDescriptionInfoMapAsync();
			await InitElementMapAsync();
			await InitItemMapAsync();
			await InitLightConePromotionMapAsync();
			await InitLightConeRankMapAsync();
			await InitLightConeMapAsync();
			await InitNicknameAsync();
			await InitPathInfoMapAsync();
			await InitPropertyMapAsync();
			await InitRelicMainAffixMapAsync();
			await InitRelicSetMapAsync();
			await InitRelicSubAffixMapAsync();
			await InitRelicMapAsync();
			await InitSimulatedBlessingMapAsync();
			await InitSimulatedBlockMapAsync();
			await InitSimulatedCurioMapAsync();
			await InitSimulatedEventMapAsync();
		}

		#endregion

		#region API

		/// <summary>
		/// 获取玩家原始信息
		/// </summary>
		/// <param name="UID">玩家 UID</param>
		/// <returns>获取玩家原始信息的任务</returns>
		public async Task<OriginInfo> GetOriginInfoAsync(long UID)
		{
			return await GetDataFromUrlAsync<OriginInfo>($"{_apiBaseUrl}/sr_info/{UID}");
		}

		/// <summary>
		/// 获取玩家解析信息
		/// </summary>
		/// <param name="UID">玩家 UID</param>
		/// <returns>获取玩家解析信息的任务</returns>
		public async Task<ParsedInfo> GetParsedInfoAsync(long UID)
		{
			return await GetDataFromUrlAsync<ParsedInfo>($"{_apiBaseUrl}/sr_info_parsed/{UID}");
		}

		#endregion

		#region Dispose

		/// <inheritdoc/>
		public void Dispose()
		{
			_httpClient.Dispose();
		}

		#endregion
	}
}
