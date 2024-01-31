Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.XtraReports.UI

Namespace WpfApplication1

    Public Class ReportViewModel
        Inherits DevExpress.Mvvm.BindableBase

        Private _Report As XtraReport

        Public Property Report As XtraReport
            Get
                Return _Report
            End Get

            Private Set(ByVal value As XtraReport)
                _Report = value
            End Set
        End Property

        Public Sub New(ByVal report As DevExpress.XtraReports.UI.XtraReport)
            Me.Report = report
        End Sub
    End Class

    Public Class PreviewViewModel
        Inherits WpfApplication1.ReportViewModel

        Private _ComboBoxItemsSource As IEnumerable(Of String), _DateTimeMin As DateTime, _DateTimeMax As DateTime

        Public Sub New(ByVal report As DevExpress.XtraReports.UI.XtraReport)
            MyBase.New(report)
            ' Fill the itemsSource of a ComboBox editor.
            Me.ComboBoxItemsSource = System.Linq.Enumerable.Range(1, 20).[Select](Function(x) String.Format("Item {0}", x))
            ' Set the minimum and maximum values for a DateTime editor.
            Me.DateTimeMin = System.DateTime.Now.AddMonths(-2)
            Me.DateTimeMax = System.DateTime.Now.AddMonths(2)
        End Sub

        Public Property ComboBoxItemsSource As IEnumerable(Of String)
            Get
                Return _ComboBoxItemsSource
            End Get

            Private Set(ByVal value As IEnumerable(Of String))
                _ComboBoxItemsSource = value
            End Set
        End Property

        Public Property DateTimeMin As DateTime
            Get
                Return _DateTimeMin
            End Get

            Private Set(ByVal value As DateTime)
                _DateTimeMin = value
            End Set
        End Property

        Public Property DateTimeMax As DateTime
            Get
                Return _DateTimeMax
            End Get

            Private Set(ByVal value As DateTime)
                _DateTimeMax = value
            End Set
        End Property
    End Class
End Namespace
