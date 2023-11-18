using Newtonsoft.Json;

namespace MiHoMo.Models.SimulatedBlessings
{
	/// <summary>
	/// 模拟宇宙祝福
	/// </summary>
	public class SimulatedBlessing
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
		/// 介绍
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 强化介绍
		/// </summary>
		[JsonProperty("enhanced_desc")]
		public string EnhancedDescription { get; set; }
	}
}
