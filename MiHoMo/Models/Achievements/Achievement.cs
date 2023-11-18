using Newtonsoft.Json;

namespace MiHoMo.Models.Achievements
{
	/// <summary>
	/// 
	/// </summary>
	public class Achievement
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string ID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("series_id")]
		public string SeriesID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("desc")]
		public string Description { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hide_desc")]
		public string HideDescription { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hide")]
		public bool Hide { get; set; }
	}
}
