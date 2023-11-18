using Newtonsoft.Json;

namespace MiHoMo.Models.Origin
{
	/// <summary>
	/// 光锥信息
	/// </summary>
	public class OriginEquipment
    {
		/// <summary>
		/// 光锥ID<br/>
		/// 若无光锥此项为null
		/// </summary>
		[JsonProperty("tid")]
        public int? TID { get; set; }

		/// <summary>
		/// 光锥叠影数<br/>
		/// 若无光锥此项为null
		/// </summary>
		[JsonProperty("rank")]
        public int? Rank { get; set; }

		/// <summary>
		/// 光锥等级<br/>
		/// 若无光锥此项为null
		/// </summary>
		[JsonProperty("level")]
        public int? Level { get; set; }

		/// <summary>
		/// 光锥晋阶等级<br/>
		/// 若无光锥此项为null
		/// </summary>
		[JsonProperty("promotion")]
        public int? Promotion { get; set; }
    }
}
