using Newtonsoft.Json;

namespace MiHoMo.Models.Elements
{
	/// <summary>
	/// 元素
	/// </summary>
	public class Element
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
		/// 颜色
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
