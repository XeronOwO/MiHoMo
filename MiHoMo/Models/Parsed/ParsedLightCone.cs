using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedLightCone
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
		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("rank")]
		public int Rank { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("promotion")]
		public int Promotion { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("preview")]
		public string Preview { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("portrait")]
		public string Portrait { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("path")]
		public ParsedSprite Path { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("attributes")]
		public ParsedAttributeInfo Attributes { get; set; }
	}
}
