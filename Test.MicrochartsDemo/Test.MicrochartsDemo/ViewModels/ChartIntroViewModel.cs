using System;
using Microcharts;
using Prism;
using Prism.Navigation;

namespace Test.MicrochartsDemo.ViewModels
{
  public class ChartIntroViewModel : ViewModelBase, IActiveAware
  {
    private bool _isActive;

    public ChartIntroViewModel(INavigationService navigationService)
      : base(navigationService)
    {
      Title = "Main Page";
    }

    public event EventHandler IsActiveChanged;

    public bool IsActive
    {
      get => _isActive;
      set
      {
        _isActive = value;
        RaisePropertyChanged();
      }
    }

    public Chart ChartData { get; set; }

    protected virtual void RaiseIsActiveChanged()
    {
      IsActiveChanged?.Invoke(this, EventArgs.Empty);
    }
  }
}