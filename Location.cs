
using Newtonsoft.Json;

namespace Ipify
{
    public partial class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("postalCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PostalCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("geonameId")]
        public long GeonameId { get; set; }
    }
}