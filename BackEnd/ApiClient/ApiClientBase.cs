using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ApiClient
{
    public abstract class ApiClientBase
    {

        protected readonly HttpClient httpClient;

        protected ApiClientBase(HttpClient httpClient)
        {
            var mediaType = MediaTypeWithQualityHeaderValue.Parse("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(mediaType);
            this.httpClient = httpClient;
        }

        public async Task<T> GetAsync<T>(string apiUrl)
        {
            var apnResponse = await httpClient.GetAsync(apiUrl);
            apnResponse.EnsureSuccessStatusCode();
            var responseString = await apnResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(responseString);
        }
    }
}
