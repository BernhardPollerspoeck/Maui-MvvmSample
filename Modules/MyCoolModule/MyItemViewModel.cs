using MvvMHelpers.core;
using MvvmSample.Models;

namespace MvvmSample.Modules.MyCoolModule;

internal class MyItemViewModel : BaseViewModel, IMyItemViewModel
{

	public string? Title { get; private set; }
	public int? Number { get; private set; }

	public Task SetData(ItemsDataModel model)
	{
		Title = model.Title;
		Number = model.Number;
		return Task.CompletedTask;
	}
}