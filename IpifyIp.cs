using System.Threading.Tasks;

namespace Ipify
{
    /// <summary>
    /// Represent static class of IP address Request Sync/Async
    /// </summary>
    public static class IpifyIp
    {
        private static readonly string EndpointHttps = "https://api.ipify.org";
        private static readonly string EndpointHttp = "http://api.ipify.org";

        private static readonly string EndpointIpV6Https = "https://api6.ipify.org";
        private static readonly string EndpointIpV6Http = "http://api6.ipify.org";

        
        /// <summary>
        /// Async Request Public IP Address
        /// </summary>
        /// <param name="secure">Choose between secure request and unsecure (https/http) by default set as secure</param>
        /// <returns>Return public IP Address as a string.</returns>
        public static async Task<string> GetPublicIpAsync(bool secure = true)
        {
            string endpoint = secure ? EndpointHttps : EndpointHttp;
            return await Request.GetRequestResultAsync(endpoint);
        }

        /// <summary>
        /// Request Public IP Address.
        /// </summary>
        /// <param name="secure">Choose between secure request and unsecure (https/http) by default set as secure</param>
        /// <returns>Return public IP Address as a string.</returns>
        public static string GetPublicIp(bool secure = true)
        {
            string endpoint = secure ? EndpointHttps : EndpointHttp;
            return Request.GetRequestResult(endpoint);
        }

        /// <summary>
        /// Request Public IP Address (v6) try to get IP Address as IPV6.
        /// </summary>
        /// <param name="secure">Choose between secure request and unsecure (https/http) by default set as secure</param>
        /// <returns>Return public IP Address(v6) as a string, if don't will return IPv4 address as string</returns>
        public static string GetPublicIpV6(bool secure = true)
        {
            string endpoint = secure ? EndpointIpV6Https : EndpointIpV6Http;
            return Request.GetRequestResult(endpoint);
        }
        /// <summary>
        /// Asyn Request Public IP Address (v6) try to get IP Address as IPV6.
        /// </summary>
        /// <param name="secure">Choose between secure request and unsecure (https/http) by default set as secure</param>
        /// <returns>Return public IP Address(v6) as a string, if don't will return IPv4 address as string</returns>
        public static async Task<string> GetPublicIpV6Async(bool secure = true)
        {
            string endpoint = secure ? EndpointIpV6Https : EndpointIpV6Http;
            return await Request.GetRequestResultAsync(endpoint);
        }

    }
}
