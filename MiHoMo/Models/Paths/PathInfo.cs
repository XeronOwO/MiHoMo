using Newtonsoft.Json;

namespace MiHoMo.Models.Paths
{
	/// <summary>
	/// 命途信息
	/// </summary>
	public class PathInfo
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 文本
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

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
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
