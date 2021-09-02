Imports System.Collections
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace DXCharts_Runtime

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Create a chart.
			Dim chart As New ChartControl()

			' Create a diagram.
			Dim diagram As New XYDiagram2D()
			chart.Diagram = diagram

			' Create a bar series.
			Dim series As New BarSideBySideSeries2D()
			diagram.Series.Add(series)

			' Add points to the series.
			series.Points.Add(New SeriesPoint("A", 1))
			series.Points.Add(New SeriesPoint("B", 3))
			series.Points.Add(New SeriesPoint("C", 5))
			series.Points.Add(New SeriesPoint("D", 2))
			series.Points.Add(New SeriesPoint("E", 7))

			' Add the chart to the window.
			Me.Content = chart
		End Sub

	End Class
End Namespace
