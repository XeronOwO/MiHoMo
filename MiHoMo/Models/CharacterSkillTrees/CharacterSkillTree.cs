using Newtonsoft.Json;

namespace MiHoMo.Models.CharacterSkillTrees
{
    /// <summary>
    /// 角色行迹树
    /// </summary>
    public class CharacterSkillTree
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
		/// 最大等级
		/// </summary>
		[JsonProperty("max_level")]
		public int MaxLevel { get; set; }

		/// <summary>
		/// 介绍
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 参数
		/// </summary>
		[JsonProperty("params")]
		public DoubleListList Params { get; set; }

		/// <summary>
		/// 节点
		/// </summary>
		[JsonProperty("anchor")]
		public string Anchor { get; set; }

		/// <summary>
		/// 前置节点
		/// </summary>
		[JsonProperty("pre_points")]
		public StringList PrePoints { get; set; }

		/// <summary>
		/// 技能等级提升
		/// </summary>
		[JsonProperty("level_up_skills")]
		public IDNumberList LevelUpSkills { get; set; }

		/// <summary>
		/// 等级
		/// </summary>
		[JsonProperty("levels")]
		public CharacterSkillTreeLevelInfoList Levels { get; set; }
	}
}
