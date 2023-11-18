using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 行迹 / 技能树信息
	/// </summary>
	public class OriginSkillTree
	{
		/// <summary>
		/// 行迹ID
		/// </summary>
		[JsonProperty("pointId")]
		public int PointId { get; set; }

		/// <summary>
		/// 行迹等级
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
