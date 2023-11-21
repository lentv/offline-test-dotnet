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

            return await GetAsync<List<BeerDto>>(url);
        }
    }
}
