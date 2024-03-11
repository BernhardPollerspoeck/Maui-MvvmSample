using MvvmSample.Models;

namespace MvvmSample.Services;
internal class DataService : IDataService
{
	public Task<IEnumerable<ItemsDataModel>> GetItemsData()
	{
		var data = new List<ItemsDataModel>();

		for (var i = 0; i < 50; i++)
		{
			data.Add(new($"ID: {i}", $"Title for item {i}", i));
		}

		return Task.FromResult(data.AsEnumerable());
	}

	public Task<MainDataModel> GetMainData()
	{
		return Task.FromResult(new MainDataModel(
			$"Id: {Random.Shared.NextDouble()}",
			"SomeTitle",
			Guid.NewGuid()));
	}
}
