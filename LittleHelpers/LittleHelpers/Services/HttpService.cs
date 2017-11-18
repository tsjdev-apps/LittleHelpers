using System;
using System.Net.Http;
using System.Threading.Tasks;
using LittleHelpers.ExtensionMethods;
using Newtonsoft.Json;

namespace LittleHelpers.Services
{
    public static class HttpService
    {
        /// <summary>
        ///     Gets the web request asynchronous.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="handler">The handler.</param>
        public static async Task<T> GetRequestAsync<T>(string url, HttpClientHandler handler = null) where T : class
        {
            using (var client = handler.IsNull() ? new HttpClient() : new HttpClient(handler))
            {
                try
                {
                    var response = await client.GetAsync(url).ConfigureAwait(false);
                    var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    return JsonConvert.DeserializeObject<T>(responseString);
                }
                catch (Exception ex)
                {
                    ex.LogDebug();
                    throw;
                }
            }
        }
    }
}