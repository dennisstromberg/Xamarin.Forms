using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sample.Pages;
using Sample.Services;
using Sample.ViewModel;
using Xamarin.Platform;
using Xamarin.Platform.Hosting;

namespace Sample
{
	public class MyApp : App
	{
		public override IAppHostBuilder Builder()
		{
			var app = CreateDefaultBuilder()
					//.RegisterHandlers(new Dictionary<Type, Type>
					//		{
					//			{ typeof(VerticalStackLayout),typeof(LayoutHandler) },
					//			{ typeof(HorizontalStackLayout),typeof(LayoutHandler) },
					//		})
					.ConfigureServices(ConfigureServices);
			//.UseServiceProviderFactory(new DIExtensionsServiceProviderFactory());

			return (IAppHostBuilder)app;
		}

		//public MyApp(IServiceProvider provider) : base(provider)
		//{
		//}

		public void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
		{
			services.AddSingleton<ITextService, TextService>();
			services.AddTransient<MainPageViewModel>();
			services.AddTransient<MainPage>();
			services.AddTransient<IWindow, MainWindow>();

		}


		//Uncomment if you don't use DI
		//public override IEnumerable<IWindow> Windows => new IWindow[1] { Platform.GetWindow() };
	}
}