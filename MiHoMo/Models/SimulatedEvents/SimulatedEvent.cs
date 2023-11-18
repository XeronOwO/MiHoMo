using Newtonsoft.Json;

namespace MiHoMo.Models.SimulatedEvents
{
	/// <summary>
	/// 模拟宇宙事件
	/// </summary>
	public class SimulatedEvent
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
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 图片
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }
	}
}
