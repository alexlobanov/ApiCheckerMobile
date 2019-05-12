using System;
using System.Collections.Generic;
using System.Linq;
using ApiChecker.Helpers;
using ApiChecker.Models;
using Microcharts;
using Prism.Navigation;
using PropertyChanged;
using SkiaSharp;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GlobalLatencyResultPageViewModel : ViewModelBase
    {
        public GlobalLatencyModel LatencyResult { get; set; }

        public Chart LatencyChart { get; set; }


        public GlobalLatencyResultPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {

        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            if (parameters.ContainsKey(NavigationKeys.GlobalLatencyResultKey))
            {
                LatencyResult = parameters.GetValue<GlobalLatencyModel>(NavigationKeys.GlobalLatencyResultKey);
                Title = LatencyResult.Url;
                LatencyChart = GenerateUIChart(LatencyResult);
            }

        }

        private Chart GenerateUIChart(GlobalLatencyModel globalLatency)
        {
            return new LineChart()
            {
                Entries = globalLatency.LocationsTested?.Select(x => new ChartEntry(x.TotalTime)
                {
                    Color = SKColors.White,
                    TextColor = SKColors.White,
                    Label = x.Location,
                    ValueLabel = (x.TotalTime).ToString("F0") + " ms",
                }) ?? new ChartEntry[0],
                LineMode = LineMode.Straight,
                PointMode = PointMode.Circle,
                LabelColor = SKColors.White,
                LineSize = 1,
                BackgroundColor = SKColors.Transparent,
            };
        }

    }
}
