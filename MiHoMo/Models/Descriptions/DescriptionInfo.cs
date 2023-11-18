using Newtonsoft.Json;

namespace MiHoMo.Models.Descriptions
{
	/// <summary>
	/// 简介
	/// </summary>
	public class DescriptionInfo
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 简介
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }
	}
}
