using Newtonsoft.Json;

namespace MiHoMo.Models
{
	/// <summary>
	/// 类型、值信息
	/// </summary>
	public class TypeValue
	{
		/// <summary>
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 值
		/// </summary>
		[JsonProperty("value")]
		public double Value { get; set; }
	}
}
