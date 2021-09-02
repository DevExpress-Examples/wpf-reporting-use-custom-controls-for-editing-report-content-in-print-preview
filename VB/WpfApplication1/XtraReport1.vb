Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace WpfApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
			AddHandler PrintingSystem.EditingFieldChanged, AddressOf PrintingSystem_EditingFieldChanged
		End Sub

		Private Sub PrintingSystem_EditingFieldChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.EditingFieldEventArgs)
			If CType(e.EditingField, TextEditingField).EditorName = "DateEditor" Then
				e.EditingField.Brick.Text = String.Format("{0:MMMM dd, yyyy}", System.Convert.ToDateTime(e.EditingField.Brick.Text))
			End If
		End Sub

	End Class
End Namespace
