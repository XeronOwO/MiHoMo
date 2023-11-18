using Newtonsoft.Json;

namespace MiHoMo.Models.Relics
{
	/// <summary>
	/// 遗器部位
	/// </summary>
	public class Relic
	{
		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 套装ID
		/// </summary>
		[JsonProperty("set_id")]
		public string SetID { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 稀有度
		/// </summary>
		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		/// <summary>
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 最高等级
		/// </summary>
		[JsonProperty("max_level")]
		public int MaxLevel { get; set; }

		/// <summary>
		/// 主词条ID
		/// </summary>
		[JsonProperty("main_affix_id")]
		public string MainAffixID { get; set; }

		/// <summary>
		/// 副词条ID
		/// </summary>
		[JsonProperty("sub_affix_id")]
		public string SubAffixID { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
