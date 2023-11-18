using Newtonsoft.Json;

namespace MiHoMo.Models.RelicMainAffixes
{
	/// <summary>
	/// 遗器主词条
	/// </summary>
	public class RelicMainAffix
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 主词条词条信息表
		/// </summary>
		[JsonProperty("affixes")]
		public RelicMainAffixAffixMap Affixes { get; set; }
	}
}
