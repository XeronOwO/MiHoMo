using Newtonsoft.Json;

namespace MiHoMo.Models.RelicSets
{
	/// <summary>
	/// 遗器套装
	/// </summary>
	public class RelicSet
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
		/// 介绍
		/// </summary>
		[JsonProperty("desc")]
		public StringList DescriptionList { get; set; }

		/// <summary>
		/// 词条
		/// </summary>
		[JsonProperty("properties")]
		public TypeValueListList Properties { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 指南概述
		/// </summary>
		[JsonProperty("guide_overview")]
		public StringList GuideOverview { get; set; }
	}
}
