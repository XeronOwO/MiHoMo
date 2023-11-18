using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 角色信息
	/// </summary>
	public class OriginAvatarDetail
	{
		/// <summary>
		/// 角色ID
		/// </summary>
		[JsonProperty("avatarId")]
		public int AvatarID { get; set; }

		/// <summary>
		/// 角色星魂数<br/>若未解锁星魂则为null
		/// </summary>
		[JsonProperty("rank")]
		public int? Rank { get; set; }

		/// <summary>
		/// 角色等级
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 角色晋阶等级
		/// </summary>
		[JsonProperty("promotion")]
		public int Promotion { get; set; }

		/// <summary>
		/// 光锥信息
		/// </summary>
		[JsonProperty("equipment")]
		public OriginEquipment Equipment { get; set; }

		/// <summary>
		/// 行迹 / 技能树信息
		/// </summary>
		[JsonProperty("skillTreeList")]
		public OriginSkillTreeList SkillTreeList { get; set; }

		/// <summary>
		/// 遗器信息
		/// </summary>
		[JsonProperty("RelicList")]
		public OriginRelicList RelicList { get; set; }
	}
}
