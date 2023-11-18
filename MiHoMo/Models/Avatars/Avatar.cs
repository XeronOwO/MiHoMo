using Newtonsoft.Json;

namespace MiHoMo.Models.Avatars
{
	/// <summary>
	/// 头像信息
	/// </summary>
	public class Avatar
	{
		/// <summary>
		/// 头像ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 头像名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 头像图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
