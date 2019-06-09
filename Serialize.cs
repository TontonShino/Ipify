using Newtonsoft.Json;

namespace Ipify                                                                                                                                                                                                                                                                               
{
    public static class Serialize
    {
        public static string ToJson(this GeoIp self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}