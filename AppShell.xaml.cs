using MvvmSample.Modules.MyCoolModule;

namespace MvvmSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("mvvm", typeof(MyCoolPage));

		GoToAsync("mvvm");
	}
}
