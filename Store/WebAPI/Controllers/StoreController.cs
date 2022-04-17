using Microsoft.AspNetCore.Mvc;
using BL;
using Models;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly IStoreBL _bl;
    private IMemoryCache _cache;
    public StoreController(IStoreBL bl, IMemoryCache cache)
    {
        _bl = bl;
        _cache = cache;
    }
    
    // GET: api/<IssuesController>
    [HttpGet]
    public async Task<List<Store>> GetAsync()
    {
        List<Store> stores = new List<Store>();
        if(_cache.TryGetValue<List<Store>>("AllStores", out stores))
        {
            return stores;
        }
        else
        {
            stores = await _bl.GetStoresAsync();
            TimeSpan expiration = new TimeSpan(0, 1, 0);
            _cache.Set("AllStores", stores, expiration);
            return stores;
        }
    }
}