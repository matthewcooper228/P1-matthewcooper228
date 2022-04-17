using DL;
using Models;
namespace BL;
public class StoreBL : IStoreBL
{
    private readonly IStoreBL _repo;
    public StoreBL(IStoreBL repo)
    {
        _repo = repo;
    }
    public async Task<List<Store>> GetStoresAsync()
    {
        return await _repo.GetAllStoresAsync();
    }
}