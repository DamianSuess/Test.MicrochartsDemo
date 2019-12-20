using Prism.Navigation;

namespace Test.MicrochartsDemo.ViewModels
{
  public class MainTabPageViewModel : ViewModelBase
  {
    public MainTabPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
      Title = "Main Page";
    }
  }
}