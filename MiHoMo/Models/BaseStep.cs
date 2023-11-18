using Newtonsoft.Json;

namespace MiHoMo.Models
{
	/// <summary>
	/// 基础值、步进值信息
	/// </summary>
	public class BaseStep
	{
		/// <summary>
		/// 基础值
		/// </summary>
		[JsonProperty("base")]
		public double Base { get; set; }

		/// <summary>
		/// 步进值
		/// </summary>
		[JsonProperty("step")]
		public double Step { get; set; }
	}
}
