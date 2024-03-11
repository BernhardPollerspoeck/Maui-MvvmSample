namespace MvvmSample.Modules.MyCoolModule;

public partial class MyCoolPage : ContentPage
{
	public MyCoolPage(IMyCoolPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (BindingContext is IMyCoolPageViewModel viewModel)
		{
			viewModel.LoadInitialDataCommand.Execute(null);
		}
	}

}