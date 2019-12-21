using System;
using Microcharts;
using Prism;
using Prism.Navigation;
using Test.MicrochartsDemo.Services;

namespace Test.MicrochartsDemo.ViewModels
{
  public class ChartIntroViewModel : ViewModelBase, IActiveAware
  {
    private Entry[] _entryData;
    private bool _isActive;

    public ChartIntroViewModel(INavigationService navigationService, IDataStoreService dataStore)
      : base(navigationService)
    {
      Title = "Main Page";
      EntryData = dataStore.GetItems(false);

      //var BlueColor = SkiaSharp.SKColor.Parse("#0099ff");
      //var OrangeColor = SkiaSharp.SKColor.Parse("#FFD45F");

      //EntryData = new[]
      //{
      //  new Microcharts.Entry(128) { Color = OrangeColor, Label = "Static Box", ValueLabel = "128" },
      //  new Microcharts.Entry(514) { Color = BlueColor, Label = "Static Industries", ValueLabel = "-100" },
      //  new Microcharts.Entry(514) { Color = BlueColor, Label = "Static Industries", ValueLabel = "514" },
      //};
    }

    public event EventHandler IsActiveChanged;

    public Chart ChartBar => new BarChart() { Entries = EntryData };
    public Chart ChartDonut => new DonutChart() { Entries = EntryData };
    public Chart ChartLine => new LineChart() { Entries = EntryData };

    public Chart ChartPie => new PieChart() { Entries = EntryData };

    public Chart ChartPoint => new PointChart() { Entries = EntryData };

    public Chart ChartRadar => new RadarChart() { Entries = EntryData };

    public Chart ChartRadialGauge => new RadialGaugeChart() { Entries = EntryData };

    public Entry[] EntryData
    {
      get => _entryData;
      set
      {
        _entryData = value;
        RaisePropertyChanged();
      }
    }

    public bool IsActive
    {
      get => _isActive;
      set
      {
        _isActive = value;
        RaisePropertyChanged();
      }
    }

    protected virtual void RaiseIsActiveChanged()
    {
      IsActiveChanged?.Invoke(this, EventArgs.Empty);
    }
  }
}