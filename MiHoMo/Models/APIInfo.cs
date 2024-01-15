using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiHoMo.Models
{
	/// <summary>
	/// API信息
	/// </summary>
	public class APIInfo
	{
		/// <summary>
		/// 版本
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }

		/// <summary>
		/// 推荐目录
		/// </summary>
		[JsonProperty("folder")]
		public string Folder { get; set; }

		/// <summary>
		/// 时间戳
		/// </summary>
		[JsonProperty("timestamp")]
		public long Timestamp { get; set; }
	}
}
