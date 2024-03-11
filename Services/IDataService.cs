using MvvmSample.Models;

namespace MvvmSample.Services;

public interface IDataService
{
	Task<MainDataModel> GetMainData();
	Task<IEnumerable<ItemsDataModel>> GetItemsData();
}
