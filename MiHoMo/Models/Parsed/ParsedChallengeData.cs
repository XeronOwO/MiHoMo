using Newtonsoft.Json;

namespace MiHoMo.Models.Parsed
{
	/// <summary>
	/// 
	/// </summary>
	public class ParsedChallengeData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("maze_group_id")]
		public int MazeGroupID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("maze_group_index")]
		public int MazeGroupIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pre_maze_group_index")]
		public int PreMazeGroupIndex { get; set; }
	}
}
