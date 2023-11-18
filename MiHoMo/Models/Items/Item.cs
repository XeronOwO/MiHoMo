using Newtonsoft.Json;

namespace MiHoMo.Models.Items
{
	/// <summary>
	/// 物品
	/// </summary>
	public class Item
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
		/// 类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 子类型
		/// </summary>
		[JsonProperty("sub_type")]
		public string SubType { get; set; }

		/// <summary>
		/// 稀有度
		/// </summary>
		[JsonProperty("rarity")]
		public string Rarity { get; set; }

		/// <summary>
		/// 图标
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 获取途径
		/// </summary>
		[JsonProperty("come_from")]
		public StringList ComeFrom { get; set; }
	}
}
