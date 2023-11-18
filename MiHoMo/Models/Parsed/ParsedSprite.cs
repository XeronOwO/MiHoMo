using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedSprite
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
