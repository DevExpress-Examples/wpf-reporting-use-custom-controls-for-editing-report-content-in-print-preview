Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace WpfApplication1

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            AddHandler PrintingSystem.EditingFieldChanged, New EventHandler(Of EditingFieldEventArgs)(AddressOf PrintingSystem_EditingFieldChanged)
        End Sub

        Private Sub PrintingSystem_EditingFieldChanged(ByVal sender As Object, ByVal e As EditingFieldEventArgs)
            If Equals(CType(e.EditingField, TextEditingField).EditorName, "DateEditor") Then
                e.EditingField.Brick.Text = String.Format("{0:MMMM dd, yyyy}", Convert.ToDateTime(e.EditingField.Brick.Text))
            End If
        End Sub
    End Class
End Namespace
