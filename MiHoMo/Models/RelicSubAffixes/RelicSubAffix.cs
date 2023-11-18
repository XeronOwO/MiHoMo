using Newtonsoft.Json;

namespace MiHoMo.Models.RelicSubAffixes
{
	/// <summary>
	/// 遗器副词条
	/// </summary>
	public class RelicSubAffix
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }
		
		/// <summary>
		/// 词条表
		/// </summary>
		[JsonProperty("affixes")]
		public RelicSubAffixAffixMap Affixes { get; set; }
	}
}
