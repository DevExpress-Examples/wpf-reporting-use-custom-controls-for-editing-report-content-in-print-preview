Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.XtraReports.UI

Namespace WpfApplication1
	Public Class ReportViewModel
		Inherits BindableBase

		Private privateReport As XtraReport
		Public Property Report() As XtraReport
			Get
				Return privateReport
			End Get
			Private Set(ByVal value As XtraReport)
				privateReport = value
			End Set
		End Property
		Public Sub New(ByVal report As XtraReport)
			Me.Report = report
		End Sub
	End Class

	Public Class PreviewViewModel
		Inherits ReportViewModel

		Public Sub New(ByVal report As XtraReport)
			MyBase.New(report)
			' Fill the itemsSource of a ComboBox editor.
			ComboBoxItemsSource = Enumerable.Range(1, 20).Select(Function(x) String.Format("Item {0}", x))

			' Set the minimum and maximum values for a DateTime editor.
			DateTimeMin = DateTime.Now.AddMonths(-2)
			DateTimeMax = DateTime.Now.AddMonths(2)
		End Sub

		Private privateComboBoxItemsSource As IEnumerable(Of String)
		Public Property ComboBoxItemsSource() As IEnumerable(Of String)
			Get
				Return privateComboBoxItemsSource
			End Get
			Private Set(ByVal value As IEnumerable(Of String))
				privateComboBoxItemsSource = value
			End Set
		End Property
		Private privateDateTimeMin As DateTime
		Public Property DateTimeMin() As DateTime
			Get
				Return privateDateTimeMin
			End Get
			Private Set(ByVal value As DateTime)
				privateDateTimeMin = value
			End Set
		End Property
		Private privateDateTimeMax As DateTime
		Public Property DateTimeMax() As DateTime
			Get
				Return privateDateTimeMax
			End Get
			Private Set(ByVal value As DateTime)
				privateDateTimeMax = value
			End Set
		End Property
	End Class
End Namespace
