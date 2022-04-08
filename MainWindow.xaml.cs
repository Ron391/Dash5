using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Dash5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Visits",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(65) },
                    DataLabels = true,
                    Fill=Brushes.Blue

                },
                new PieSeries
                {
                    Title = "Others",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(35) },
                    DataLabels = true,
                    Fill=Brushes.Transparent

                },
            };
            SeriesCollection2 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Orders",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
                    DataLabels = true,
                    Fill=Brushes.Yellow
                },
                 new PieSeries
                {
                    Title = "Others",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(80) },
                    DataLabels = true,
                    Fill=Brushes.Transparent

                },
            };
            SeriesCollection3 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Sales",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(80) },
                    DataLabels = true,
                    Fill=Brushes.Red
                },
                 new PieSeries
                {
                    Title = "Others",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
                    DataLabels = true,
                    Fill=Brushes.Transparent

                },
            };


            Series = new SeriesCollection
            {
                new StackedAreaSeries
                {
                    Values = new ChartValues<double> {20, 30, 35, 45, 65, 85},
                    Title = "Electricity"
                },
                new StackedAreaSeries
                {
                    Values = new ChartValues<double> {10, 12, 18, 20, 38, 40},
                    Title = "Water"
                },
                new StackedAreaSeries
                {
                    Values = new ChartValues<double> {5, 8, 12, 15, 22, 25},
                    Title = "Solar"
                },
                new StackedAreaSeries
                {
                    Values = new ChartValues<double> {10, 12, 18, 20, 38, 40},
                    Title = "Gas"
                }
            };

            SeriesCollection4 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Current",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(45) },
                    DataLabels = true,

                },
                new PieSeries
                {
                    Title = "Target",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(25) },
                    DataLabels = true,

                },
                 new PieSeries
                {
                    Title = "Lost",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(30) },
                    DataLabels = true,

                },
            };
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection2 { get; set; }
        public SeriesCollection SeriesCollection3 { get; set; }
        public SeriesCollection SeriesCollection4 { get; set; }

        public SeriesCollection Series { get; set; }

        private void ListBox_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(ListBox, (DependencyObject)e.OriginalSource) as ListBoxItem;
            if (item == null) return;

            var series = (StackedAreaSeries)item.Content;
            series.Visibility = series.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }
    }
}
