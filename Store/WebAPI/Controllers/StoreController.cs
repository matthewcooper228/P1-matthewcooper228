using Microsoft.AspNetCore.Mvc;
using BL;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly IStoreBL _bl;

    public StoreController(IStoreBL bl)
    {
        _bl = bl;
    }
    
    // GET: api/<StoreController>
    [HttpGet]
    public async Task<List<Store>> GetAsync()
    {
        return await _bl.GetStoresAsync();
    }
}