using Microsoft.Extensions.Logging;
using MvvmSample.Modules.MyCoolModule;
using MvvmSample.Services;

namespace MvvmSample;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<IDataService, DataService>();

		builder.Services.AddTransient<MyCoolPage>();
		builder.Services.AddTransient<IMyCoolPageViewModel, MyCoolPageViewModel>();

		builder.Services.AddTransient<IMyItemViewModel, MyItemViewModel>();

		return builder.Build();
	}
}
