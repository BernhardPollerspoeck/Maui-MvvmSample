using MvvmSample.Models;

namespace MvvmSample.Modules.MyCoolModule;

public interface IMyItemViewModel
{
	string? Title { get; }
	int? Number { get; }

	Task SetData(ItemsDataModel model);
}
