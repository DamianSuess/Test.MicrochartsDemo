using System;
using System.Collections.Generic;
using Microcharts;
using Prism;
using Prism.Navigation;
using SkiaSharp;
using Test.MicrochartsDemo.Services;

namespace Test.MicrochartsDemo.ViewModels
{
  public class ChartSample1ViewModel : ViewModelBase, IActiveAware
  {
    private Entry[] _entryData;
    private bool _isActive;
    private List<MyChart> _myCharts;

    public ChartSample1ViewModel(INavigationService navigationService, IDataStoreService dataStore)
      : base(navigationService)
    {
      Title = "Main Page";
      EntryData = dataStore.GetItems(false);

      _myCharts = new List<MyChart>();
      _myCharts.Add(new MyChart() { ChartData = new BarChart() { Entries = EntryData } });
      _myCharts.Add(new MyChart() { ChartData = new BarChart() { Entries = EntryData } });
      _myCharts.Add(new MyChart() { ChartData = new BarChart() { Entries = EntryData } });
    }

    public event EventHandler IsActiveChanged;

    public Chart ChartBar => new BarChart() { Entries = EntryData, BackgroundColor = SKColors.White };

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

    public class MyChart
    {
      public Chart ChartData { get; set; }
    }
  }
}