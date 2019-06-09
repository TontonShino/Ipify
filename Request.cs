using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ipify
{
    public static class Request
    {
        /// <summary>
        /// Create Http Request
        /// </summary>
        /// <param name="endpoint">Endpoint of request</param>
        /// <returns>Request Result</returns>
        public static async Task<string> GetRequestResultAsync(string endpoint)
        {            
            try
            {
                var httpClient = new HttpClient();
                return await httpClient.GetStringAsync(endpoint);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Exception raised: {e}");
                return null;
            }
        }
        /// <summary>
        /// Create Async Http Request
        /// </summary>
        /// <param name="endpoint">Endpoint of request</param>
        /// <returns>Request Result</returns>
        public static string GetRequestResult(string endpoint)
        {            
            try
            {
                var webClient = new WebClient();
                return webClient.DownloadString(endpoint);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Exception raised: {e}");
                return null;
            }
        }
    }
}
