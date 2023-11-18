using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 遗器信息
	/// </summary>
	public class OriginRelic
	{
		/// <summary>
		/// 遗器ID
		/// </summary>
		[JsonProperty("tid")]
		public int TID { get; set; }

		/// <summary>
		/// 遗器类型<br/>1-HEAD<br/>2-HAND<br/>3-BODY<br/>4-FOOT<br/>5-NECK<br/>6-OBJECT
		/// </summary>
		[JsonProperty("type")]
		public int Type { get; set; }

		/// <summary>
		/// 遗器等级
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 当前经验
		/// </summary>
		[JsonProperty("exp")]
		public int Exp { get; set; }

		/// <summary>
		/// 遗器主词条id<br/>需要在遗器主词条组的索引
		/// </summary>
		[JsonProperty("mainAffixId")]
		public int MainAffixId { get; set; }

		/// <summary>
		/// 副词条
		/// </summary>
		[JsonProperty("subAffixList")]
		public OriginSubAffixList SubAffixeList { get; set; }
	}
}
