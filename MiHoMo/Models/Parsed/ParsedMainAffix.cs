using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedMainAffix
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

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
