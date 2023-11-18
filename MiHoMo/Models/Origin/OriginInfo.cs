using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 原始玩家信息
	/// </summary>
	public class OriginInfo
	{
		/// <summary>
		/// 玩家详细信息字段
		/// </summary>
		[JsonProperty("detailInfo")]
		public OriginDetailInfo DetailInfo { get; set; }
	}
}
