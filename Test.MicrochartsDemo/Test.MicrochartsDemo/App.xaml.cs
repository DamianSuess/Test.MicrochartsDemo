using Prism;
using Prism.Ioc;
using Test.MicrochartsDemo.Services;
using Test.MicrochartsDemo.ViewModels;
using Test.MicrochartsDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Test.MicrochartsDemo
{
  public partial class App
  {
    /*
     * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
     * This imposes a limitation in which the App class must have a default constructor.
     * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
     */

    public App() : this(null)
    {
    }

    public App(IPlatformInitializer initializer) : base(initializer)
    {
    }

    protected override async void OnInitialized()
    {
      InitializeComponent();

      await NavigationService.NavigateAsync($"{nameof(MainTabView)}?selectedTab=ChartIntroView");
      // await NavigationService.NavigateAsync($"{nameof(MainTabView)}?{KnownNavigationParamteters.SelectedTab}=ChartIntroView");
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // Services
      containerRegistry.RegisterSingleton<IDataStoreService, DataStoreService>();

      // Views
      containerRegistry.RegisterForNavigation<NavigationPage>();
      containerRegistry.RegisterForNavigation<MainTabView, MainTabPageViewModel>();
      containerRegistry.RegisterForNavigation<ChartIntroView, ChartIntroViewModel>();
      containerRegistry.RegisterForNavigation<ChartSample1View, ChartSample1ViewModel>();
      containerRegistry.RegisterForNavigation<ChartSample2View, ChartSample2ViewModel>();
    }
  }
}