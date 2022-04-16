using Models;
using DL;
namespace BL;


public class StoreBL : IStoreBL
{
    private readonly IRepository _repo;
    public StoreBL(IRepository repo)
    {
        _repo = repo;
    }
    public List<Store> GetStores()
    {
        return _repo.GetAllStores();
    }
}