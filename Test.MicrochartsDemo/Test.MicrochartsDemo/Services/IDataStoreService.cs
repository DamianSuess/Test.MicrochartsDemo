using System.Threading.Tasks;
using Microcharts;

namespace Test.MicrochartsDemo.Services
{
  public interface IDataStoreService
  {
    Entry[] GetItems(bool forceRefresh);

    Task<Entry[]> GetItemsAsync(bool forceRefresh);
  }
}