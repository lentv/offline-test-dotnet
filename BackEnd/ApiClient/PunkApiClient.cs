using Models;

namespace ApiClient
{
    public class PunkApiClient : ApiClientBase, IPunkApiClient
    {

        public PunkApiClient(HttpClient httpClient) : base(httpClient)
        {}

        public async Task<List<BeerDto>> GetBeers()
        {
            var url = "https://api.punkapi.com/v2/beers";
            //var response = await _httpClient.GetAsync(url);
            //response.EnsureSuccessStatusCode();

            //var responseString = await response.Content.ReadAsStringAsync();

            //if (string.IsNullOrEmpty(responseString))
            //{
            //    return new List<ArticleDto> ();
            //}

            //return JsonConvert.DeserializeObject<List<ArticleDto>>(responseString);

            return await GetAsync<List<BeerDto>>(url);
        }
    }
}
