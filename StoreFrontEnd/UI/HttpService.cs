using Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace UI;
public class HttpService
{
    private readonly string _apiBaseURL = "https://localhost:7255/api/";
    private HttpClient client = new HttpClient();
    public HttpService()
    {
        client.BaseAddress = new Uri(_apiBaseURL);
    }
    public async Task<List<Store>> GetAllStoresAsync()
    {
        List<Store> stores = new List<Store>();
        string url = _apiBaseURL + "Store";
        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseString = await response.Content.ReadAsStringAsync();
            stores = JsonSerializer.Deserialize<List<Store>>(responseString) ?? new List<Store>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Something bad happened: " + ex);
        }
        return stores;
    }

}