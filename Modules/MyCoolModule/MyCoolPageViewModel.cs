using MvvMHelpers.core;
using MvvmSample.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MvvmSample.Modules.MyCoolModule;
internal class MyCoolPageViewModel
	: BaseViewModel, IMyCoolPageViewModel
{
	#region fields
	private readonly ObservableCollection<IMyItemViewModel> _items;
	private readonly IDataService _dataService;
	private readonly IServiceProvider _serviceProvider;
	#endregion

	#region ctor
	public MyCoolPageViewModel(
		IDataService dataService,
		IServiceProvider serviceProvider)
	{
		_dataService = dataService;
		_serviceProvider = serviceProvider;
		_items = [];

		LoadInitialDataCommand = new AsyncCommand(LoadInitialData);
		LoadDetailDataCommand = new AsyncCommand(LoadDetailData);
	}
	#endregion

	#region IMyCoolPageViewModel
	public ICommand LoadInitialDataCommand { get; }

	public ICommand LoadDetailDataCommand { get; }

	public IEnumerable<IMyItemViewModel> Items => _items;

	private string? _title;
	public string? Title
	{
		get => _title;
		set => Set(ref _title, value);
	}

	private Guid? _data;
	public Guid? Data
	{
		get => _data;
		set => Set(ref _data, value);
	}
	#endregion

	#region command handling
	private async Task LoadInitialData()
	{
		var data = await _dataService.GetMainData();
		Title = data.Title;
		Data = data.Data;
	}
	private async Task LoadDetailData()
	{
		var items = await _dataService.GetItemsData();
		_items.Clear();
		foreach (var item in items)
		{
			var itemVm = _serviceProvider.GetRequiredService<IMyItemViewModel>();
			await itemVm.SetData(item);
			_items.Add(itemVm);
		}
	}
	#endregion
}
