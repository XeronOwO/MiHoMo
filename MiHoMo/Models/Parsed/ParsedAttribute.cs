using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 光锥加成信息
	/// </summary>
	public class ParsedAttribute
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("field")]
		public string Field { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("value")]
		public double Value { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("display")]
		public string Display { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("percent")]
		public bool Percent { get; set; }
	}
}
