using Prism;
using Prism.Ioc;

namespace Test.MicrochartsDemo.UWP
{
  public sealed partial class MainPage
  {
    public MainPage()
    {
      this.InitializeComponent();

      LoadApplication(new Test.MicrochartsDemo.App(new UwpInitializer()));
    }
  }

  public class UwpInitializer : IPlatformInitializer
  {
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // Register any platform specific implementations
    }
  }
}