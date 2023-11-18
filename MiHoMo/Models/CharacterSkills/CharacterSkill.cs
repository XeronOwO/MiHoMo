using Newtonsoft.Json;

namespace MiHoMo.Models.CharacterSkills
{
	/// <summary>
	/// 角色技能
	/// </summary>
	public class CharacterSkill
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
		public string MaxLevel { get; set; }

		/// <summary>
		/// 元素
		/// </summary>
		[JsonProperty("element")]
		public string Element { get; set; }

		/// <summary>
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 类型名称
		/// </summary>
		[JsonProperty("type_text")]
		public string TypeText { get; set; }

		/// <summary>
		/// 效果
		/// </summary>
		[JsonProperty("effect")]
		public string Effect { get; set; }

		/// <summary>
		/// 效果名称
		/// </summary>
		[JsonProperty("effect_text")]
		public string EffectText { get; set; }

		/// <summary>
		/// 简介
		/// </summary>
		[JsonProperty("simple_desc")]
		public string SimpleDescription { get; set; }

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
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
