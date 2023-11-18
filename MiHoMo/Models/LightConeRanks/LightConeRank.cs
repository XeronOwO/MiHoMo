using Newtonsoft.Json;

namespace MiHoMo.Models.LightConeRanks
{
	/// <summary>
	/// 光锥叠影信息
	/// </summary>
	public class LightConeRank
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 技能
		/// </summary>
		[JsonProperty("skill")]
		public string Skill { get; set; }

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
		/// 属性
		/// </summary>
		[JsonProperty("properties")]
		public TypeValueListList Properties { get; set; }
	}
}
