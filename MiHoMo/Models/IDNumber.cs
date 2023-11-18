using Newtonsoft.Json;

namespace MiHoMo.Models
{
    /// <summary>
    /// ID、数量信息
    /// </summary>
    public class IDNumber
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("num")]
        public int Number { get; set; }
    }
}
