using System.Windows.Input;

namespace MvvmSample.Modules.MyCoolModule;

public interface IMyCoolPageViewModel
{
	ICommand LoadInitialDataCommand { get; }
	ICommand LoadDetailDataCommand { get; }

	IEnumerable<IMyItemViewModel> Items { get; }
	string? Title { get; }
	Guid? Data { get; }

}
