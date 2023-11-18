using Newtonsoft.Json;

namespace MiHoMo.Models.Properties
{
	/// <summary>
	/// 词条
	/// </summary>
	public class Property
	{
		/// <summary>
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 字段
		/// </summary>
		[JsonProperty("field")]
		public string Field { get; set; }

		/// <summary>
		/// 是副词条
		/// </summary>
		[JsonProperty("affix")]
		public bool Affix { get; set; }

		/// <summary>
		/// 是比例
		/// </summary>
		[JsonProperty("ratio")]
		public bool Ratio { get; set; }

		/// <summary>
		/// 是百分比
		/// </summary>
		[JsonProperty("percent")]
		public bool Percent { get; set; }

		/// <summary>
		/// 顺序
		/// </summary>
		[JsonProperty("order")]
		public int Order { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
