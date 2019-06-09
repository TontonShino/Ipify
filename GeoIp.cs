using Newtonsoft.Json;

namespace Ipify
{
    /// <summary>
    /// Represent the class containing IP Geolocation Datas
    /// </summary>
    public partial class GeoIp
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
    public partial class GeoIp
    {
        public static GeoIp FromJson(string json) => JsonConvert.DeserializeObject<GeoIp>(json, Converter.Settings);
    }
}
