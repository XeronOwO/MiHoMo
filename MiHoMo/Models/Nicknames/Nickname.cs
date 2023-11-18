using Newtonsoft.Json;

namespace MiHoMo.Models.Nicknames
{
	/// <summary>
	/// 昵称信息
	/// </summary>
	public class Nickname
	{
		/// <summary>
		/// 角色昵称表
		/// </summary>
		[JsonProperty("characters")]
		public NicknameCharacterList Characters { get; set; }

		/// <summary>
		/// 遗器昵称表
		/// </summary>
		[JsonProperty("relic_sets")]
		public NicknameReclicSetMap RelicSets { get; set; }
	}
}
