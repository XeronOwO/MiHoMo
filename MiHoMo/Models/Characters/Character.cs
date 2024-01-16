using Newtonsoft.Json;

namespace MiHoMo.Models.Characters
{
	/// <summary>
	/// 角色
	/// </summary>
	public class Character
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 标签
		/// </summary>
		[JsonProperty("tag")]
		public string Tag { get; set; }

		/// <summary>
		/// 稀有度
		/// </summary>
		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		/// <summary>
		/// 命途
		/// </summary>
		[JsonProperty("path")]
		public string Path { get; set; }

		/// <summary>
		/// 元素
		/// </summary>
		[JsonProperty("element")]
		public string Element { get; set; }

		/// <summary>
		/// 能量上限
		/// </summary>
		[JsonProperty("max_sp")]
		public int MaxSP { get; set; }

		/// <summary>
		/// 星魂
		/// </summary>
		[JsonProperty("ranks")]
		public StringList Ranks { get; set; }

		/// <summary>
		/// 技能
		/// </summary>
		[JsonProperty("skills")]
		public StringList Skills { get; set; }

		/// <summary>
		/// 行迹
		/// </summary>
		[JsonProperty("skill_trees")]
		public StringList SkillTrees { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 预览
		/// </summary>
		[JsonProperty("preview")]
		public string Preview { get; set; }

		/// <summary>
		/// 头像
		/// </summary>
		[JsonProperty("portrait")]
		public string Portrait { get; set; }

		/// <summary>
		/// 指南概述
		/// </summary>
		[JsonProperty("guide_overview")]
		public StringList GuideOverview { get; set; }

		/// <summary>
		/// 指南材料
		/// </summary>
		[JsonProperty("guide_material")]
		public StringList GuideMaterial { get; set; }
	}
}
