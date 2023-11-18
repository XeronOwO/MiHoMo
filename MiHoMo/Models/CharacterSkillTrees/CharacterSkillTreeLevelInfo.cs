using Newtonsoft.Json;

namespace MiHoMo.Models.CharacterSkillTrees
{
	/// <summary>
	/// 行迹等级
	/// </summary>
	public class CharacterSkillTreeLevelInfo
	{
		/// <summary>
		/// 角色晋阶等级
		/// </summary>
		[JsonProperty("promotion")]
		public int Promotion { get; set; }

		/// <summary>
		/// 角色等级
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 属性
		/// </summary>
		[JsonProperty("properties")]
		public TypeValueList Properties { get; set; }

		/// <summary>
		/// 材料
		/// </summary>
		[JsonProperty("materials")]
		public IDNumberList Materials { get; set; }
	}
}
