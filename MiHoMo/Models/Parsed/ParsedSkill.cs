using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedSkill
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
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("max_level")]
		public int MaxLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("element")]
		public ParsedSprite Element { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type_text")]
		public string TypeText { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("effect")]
		public string Effect { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("effect_text")]
		public string EffectText { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("simple_desc")]
		public string SimpleDescription { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
