using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedSpaceInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("challenge_data")]
		public ParsedChallengeData ChallengeData { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pass_area_progress")]
		public int PassAreaProgress { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("light_cone_count")]
		public int LightConeCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("avatar_count")]
		public int AvatarCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("achievement_count")]
		public int AchievementCount { get; set; }
	}
}
