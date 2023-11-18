using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 玩家详细信息
	/// </summary>
	public class OriginDetailInfo
	{
		/// <summary>
		/// 游戏 UID
		/// </summary>
		[JsonProperty("uid")]
		public long UID { get; set; }

		/// <summary>
		/// 昵称
		/// </summary>
		[JsonProperty("nickname")]
		public string Nickname { get; set; }

		/// <summary>
		/// 账号等级
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// 均衡等级 / 世界等级
		/// </summary>
		[JsonProperty("worldLevel")]
		public int WorldLevel { get; set; }

		/// <summary>
		/// 当前好友数量
		/// </summary>
		[JsonProperty("friendCount")]
		public int FriendCount { get; set; }

		/// <summary>
		/// 使用头像ID
		/// </summary>
		[JsonProperty("headIcon")]
		public int HeadIcon { get; set; }

		/// <summary>
		/// 签名<br/>若未设置签名则为null
		/// </summary>
		[JsonProperty("signature")]
		public string Signature { get; set; }

		/// <summary>
		/// 平台信息
		/// </summary>
		[JsonProperty("platform")]
		public string Platform { get; set; }

		/// <summary>
		/// 是否公开显示角色信息
		/// </summary>
		[JsonProperty("IsDisplayAvatarList")]
		public bool IsDisplayAvatarList { get; set; }

		/// <summary>
		/// 数据信息
		/// </summary>
		[JsonProperty("recordInfo")]
		public OriginRecordInfo RecordInfo { get; set; }

		/// <summary>
		/// 支援角色信息
		/// </summary>
		[JsonProperty("assistAvatarDetail")]
		public OriginAvatarDetail AssistAvatarDetail { get; set; }

		/// <summary>
		/// 展示角色（星海同行）信息<br/>若未设置则为null
		/// </summary>
		[JsonProperty("avatarDetailList")]
		public OriginAvatarDetailList AvatarDetailList { get; set; }
	}
}
