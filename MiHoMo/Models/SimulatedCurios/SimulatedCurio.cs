using Newtonsoft.Json;

namespace MiHoMo.Models.SimulatedCurios
{
	/// <summary>
	/// 模拟宇宙奇物
	/// </summary>
	public class SimulatedCurio
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
		/// 背景介绍
		/// </summary>
		[JsonProperty("bg_desc")]
		public string BackgroundDescription { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
