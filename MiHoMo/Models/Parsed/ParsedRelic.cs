using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedRelic
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("set_id")]
		public string SetID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("set_name")]
		public string SetName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("main_affix")]
		public ParsedMainAffix MainAffix { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sub_affix")]
		public ParsedSubAffixList SubAffixes { get; set; }
	}
}
