using Newtonsoft.Json;

namespace MiHoMo.Models.CharacterRanks
{
    /// <summary>
    /// 角色星魂
    /// </summary>
    public class CharacterRank
	{
		/// <summary>
		/// 星魂ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 星魂名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 星魂等级
		/// </summary>
		[JsonProperty("rank")]
		public int Rank { get; set; }

		/// <summary>
		/// 星魂简介
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 星魂材料
		/// </summary>
		[JsonProperty("materials")]
		public IDNumberList Materials { get; set; }

		/// <summary>
		/// 技能等级提升
		/// </summary>
		[JsonProperty("level_up_skills")]
		public IDNumberList LevelUpSkills { get; set; }

		/// <summary>
		/// 星魂图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
