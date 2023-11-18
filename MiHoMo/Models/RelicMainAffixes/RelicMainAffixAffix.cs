using Newtonsoft.Json;

namespace MiHoMo.Models.RelicMainAffixes
{
	/// <summary>
	/// 遗器主词条词条
	/// </summary>
	public class RelicMainAffixAffix
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("affix_id")]
		public string AffixID { get; set; }

		/// <summary>
		/// 词条
		/// </summary>
		[JsonProperty("property")]
		public string Property { get; set; }

		/// <summary>
		/// 基础值
		/// </summary>
		[JsonProperty("base")]
		public double Base { get; set; }

		/// <summary>
		/// 步进值
		/// </summary>
		[JsonProperty("step")]
		public double Step { get; set; }
	}
}
