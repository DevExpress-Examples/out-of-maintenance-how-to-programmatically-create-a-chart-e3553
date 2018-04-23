using System.Collections;
using System.Windows;
using DevExpress.Xpf.Charts;

namespace DXCharts_Runtime {

    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            // Create a chart.
            ChartControl chart = new ChartControl();
            
            // Create a diagram.
            XYDiagram2D diagram = new XYDiagram2D();
            chart.Diagram = diagram;

            // Create a bar series.
            BarSideBySideSeries2D series = new BarSideBySideSeries2D();
            diagram.Series.Add(series);

            // Add points to the series.
            series.Points.Add(new SeriesPoint("A", 1));
            series.Points.Add(new SeriesPoint("B", 3));
            series.Points.Add(new SeriesPoint("C", 5));
            series.Points.Add(new SeriesPoint("D", 2));
            series.Points.Add(new SeriesPoint("E", 7));

            // Add the chart to the window.
            this.Content = chart;
        }

    }
}
