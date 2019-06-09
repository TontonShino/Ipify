using System.Threading.Tasks;

namespace Ipify
{
    /// <summary>
    /// Represent the static class for making call to Ipiy API to obtain IP Address Geolocation Data from Ipify
    /// </summary>
    public static class IpifyGeoIp
    {
        private static readonly string EndpointGeoLocation = "https://geo.ipify.org/api/";

        /// <summary>
        /// Request Geo IP Datas
        /// </summary>
        /// <param name="ip">IP Address as string</param>
        /// <param name="token">Ipify Token as string</param>
        /// <returns>GeoIP datas</returns>
        public static GeoIp RequestGeoIp(string token, string ip)
        {
            var endpoint = GetEndpoint(token, ip);
            var res = Request.GetRequestResult(endpoint);
            var geoip = GeoIp.FromJson(res);
            return geoip;
        }
        /// <summary>
        /// Request Geo IP Datas async 
        /// </summary>
        /// <param name="ip">IP Address as string</param>
        /// <param name="token">Ipify Token as string</param>
        /// <returns>GeoIP datas</returns>
        public static async Task<GeoIp> RequestGeoIpAsync(string token, string ip)
        {
            var endpoint = GetEndpoint(token , ip);
            var res = await Request.GetRequestResultAsync(endpoint);
            var geoip = GeoIp.FromJson(res);
            return geoip;
        }
        /// <summary>
        /// Build full endpoint
        /// </summary>
        /// <param name="ip">IP Address as string</param>
        /// <param name="token">Ipify Token as string</param>
        /// <returns>Full Endpoint</returns>
        private static string GetEndpoint(string token, string ip)
        {
            return $"{EndpointGeoLocation}v1?apiKey={token}&ipAddress={ip}";
        }


    }
}
