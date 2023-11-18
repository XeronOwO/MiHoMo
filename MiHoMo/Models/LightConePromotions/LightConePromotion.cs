using Newtonsoft.Json;

namespace MiHoMo.Models.LightConePromotions
{
	/// <summary>
	/// 光锥晋阶信息
	/// </summary>
	public class LightConePromotion
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 基础值、步进值表
		/// </summary>
		[JsonProperty("values")]
		public BaseStepMapList Values { get; set; }

		/// <summary>
		/// 材料表
		/// </summary>
		[JsonProperty("materials")]
		public IDNumberListList Materials { get; set; }
	}
}
