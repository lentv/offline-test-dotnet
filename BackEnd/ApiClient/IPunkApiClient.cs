using Models;

namespace ApiClient
{
    public interface IPunkApiClient
    {
        Task<List<BeerDto>> GetBeers();
    }
}
