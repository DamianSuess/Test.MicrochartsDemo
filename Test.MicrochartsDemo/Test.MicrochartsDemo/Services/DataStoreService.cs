using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;

namespace Test.MicrochartsDemo.Services
{
  public class DataStoreService : IDataStoreService
  {
    private static readonly SKColor AccentColor = SKColor.Parse("#2C5DF9");

    private static readonly SKColor AccentDarkColor = SKColor.Parse("#484F64");

    private static readonly SKColor BlueColor = SKColor.Parse("#0099ff");

    private static readonly SKColor GreenColor = SKColor.Parse("#26C3AC");

    private static readonly SKColor OrangeColor = SKColor.Parse("#FFD45F");

    private static readonly SKColor PinkColor = SKColor.Parse("#FA6978");

    public Entry[] GetItems(bool forceRefresh = false)
    {
      return GetItemData(forceRefresh).Result;
    }

    public async Task<Entry[]> GetItemsAsync(bool forceRefresh = false)
    {
      return await GetItemData(forceRefresh);
    }

    private async Task<Entry[]> GetItemData(bool forceRefresh)
    {
      var items = new[]
      {
        new Microcharts.Entry(128) { Color = OrangeColor, Label = "Static Box", ValueLabel = "128", },
        new Microcharts.Entry(300) { Color = GreenColor, Label = "vbStatic", ValueLabel = "300" },
        new Microcharts.Entry(-100) { Color = PinkColor, Label = "Static Industries", ValueLabel = "-100" },
        new Microcharts.Entry(500) { Color = BlueColor, Label = "Xeno Innovations", ValueLabel = "500" },
      };

      return await Task.FromResult(items);
    }
  }
}