using MiHoMo.Models.RelicMainAffixes;
using Newtonsoft.Json;

namespace MiHoMo.Models.RelicSubAffixes
{
	/// <summary>
	/// 遗器副词条词条
	/// </summary>
	public class RelicSubAffixAffix : RelicMainAffixAffix
	{
		/// <summary>
		/// 步进数
		/// </summary>
		[JsonProperty("step_num")]
		public int StepNumber { get; set; }
	}
}
