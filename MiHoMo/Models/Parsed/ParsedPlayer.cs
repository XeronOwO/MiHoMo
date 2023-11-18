using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedPlayer
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uid")]
		public string UID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("nickname")]
		public string Nickname { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("world_level")]
		public int WorldLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("friend_count")]
		public int FriendCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("avatar")]
		public ParsedSprite Avatar { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("signature")]
		public string Signature { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("is_display")]
		public bool IsDisplay { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("space_info")]
		public ParsedSpaceInfo SpaceInfo { get; set; }
	}
}
