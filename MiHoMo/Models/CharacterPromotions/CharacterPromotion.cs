using Newtonsoft.Json;

namespace MiHoMo.Models.CharacterPromotions
{
	/// <summary>
	/// 角色晋阶信息
	/// </summary>
	public class CharacterPromotion
	{
		/// <summary>
		/// 角色ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 基础值、步进值表
		/// </summary>
		[JsonProperty("values")]
		public BaseStepMapList Values { get; set; }
	}
}
