using System;
using Microcharts;
using Prism;
using Prism.Navigation;
using SkiaSharp;
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
    }

    public event EventHandler IsActiveChanged;

    public Chart ChartBar => new BarChart() { Entries = EntryData, BackgroundColor = SKColors.White };

    public Chart ChartDonut => new DonutChart() { Entries = EntryData, BackgroundColor = SKColors.WhiteSmoke };

    public Chart ChartLine => new LineChart() { Entries = EntryData, BackgroundColor = SKColors.Transparent };

    public Chart ChartPie => new PieChart() { Entries = EntryData, BackgroundColor = SKColors.Beige };

    public Chart ChartPoint => new PointChart() { Entries = EntryData };

    public Chart ChartRadar => new RadarChart()
    {
      Entries = EntryData,
      BackgroundColor = SKColors.Black,
      LabelColor = SKColors.AntiqueWhite,
    };

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