using Newtonsoft.Json;

namespace MiHoMo.Models.LightCones
{
	/// <summary>
	/// 光锥信息
	/// </summary>
	public class LightCone
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 稀有度
		/// </summary>
		[JsonProperty("rarity")]
		public string Rarity { get; set; }

		/// <summary>
		/// 命途
		/// </summary>
		[JsonProperty("path")]
		public string Path { get; set; }

		/// <summary>
		/// 介绍
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 预览
		/// </summary>
		[JsonProperty("preview")]
		public string Preview { get; set; }

		/// <summary>
		/// 头像
		/// </summary>
		[JsonProperty("portrait")]
		public string Portrait { get; set; }

		/// <summary>
		/// 指南概述
		/// </summary>
		[JsonProperty("guide_overview")]
		public StringList GuideOverview { get; set; }
	}
}
