using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 忘却之庭进度
	/// </summary>
	public class OriginChallengeInfo
    {
		/// <summary>
		/// 回忆进度<br/>
		/// 若未开启忘却之庭，此项为null
		/// </summary>
		[JsonProperty("scheduleMaxLevel")]
        public int? ScheduleMaxLevel { get; set; }

		/// <summary>
		/// 混沌回忆进度 可选<br/>
		/// 若未开启忘却之庭，此项为null
		/// </summary>
		[JsonProperty("scheduleGroupId")]
        public int? ScheduleGroupId { get; set; }

		/// <summary>
		/// 可选<br/>
		/// 若未开启忘却之庭，此项为null
		/// </summary>
		[JsonProperty("noneScheduleMaxLevel")]
        public int? NoneScheduleMaxLevel { get; set; }
    }
}
