using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("player")]
		public ParsedPlayer Player { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("characters")]
		public ParsedCharacterList Characters { get; set; }
	}
}
