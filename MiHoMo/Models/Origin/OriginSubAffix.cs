using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 副词条
	/// </summary>
	public class OriginSubAffix
	{
		/// <summary>
		/// 副词条ID
		/// </summary>
		[JsonProperty("affixId")]
		public int AffixId { get; set; }

		/// <summary>
		/// 副词条基础值数量
		/// </summary>
		[JsonProperty("cnt")]
		public int Count { get; set; }

		/// <summary>
		/// 副词条步进值数量 可选
		/// </summary>
		[JsonProperty("step")]
		public int Step { get; set; }
	}
}
