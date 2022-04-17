using Models;
namespace UI;
internal class MainMenu
{
    public async Task Start()
    {
        Console.Write("Type your selection and press enter: ");
        Console.ReadLine();
        await DisplayAllStoresAsync();
    }
    private async Task DisplayAllStoresAsync()
    {
        Console.WriteLine("Here are all the stores");
        List<Store> allStores = await new HttpService().GetAllStoresAsync();
        foreach(Store store in allStores)
        {
            Console.WriteLine(store.id + " " + store.address);
        }
    }
}