using Models;
namespace DL;
public interface IRepository
{
    Task<List<Store>> GetAllStoresAsync();
}
