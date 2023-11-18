using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 数据信息
	/// </summary>
	public class OriginRecordInfo
    {
		/// <summary>
		/// 忘却之庭进度
		/// </summary>
		[JsonProperty("challengeInfo")]
        public OriginChallengeInfo ChallengeInfo { get; set; }

		/// <summary>
		/// 通过模拟宇宙数量
		/// </summary>
		[JsonProperty("maxRogueChallengeScore")]
        public int MaxRogueChallengeScore { get; set; }

		/// <summary>
		/// 获得光锥数量
		/// </summary>
		[JsonProperty("equipmentCount")]
        public int EquipmentCount { get; set; }

		/// <summary>
		/// 获得角色数量
		/// </summary>
		[JsonProperty("avatarCount")]
        public int AvatarCount { get; set; }

		/// <summary>
		/// 获得成就数量
		/// </summary>
		[JsonProperty("achievementCount")]
        public int AchievementCount { get; set; }
    }
}
