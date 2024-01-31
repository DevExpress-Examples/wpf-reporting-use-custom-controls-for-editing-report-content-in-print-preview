Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports DialogService = DevExpress.Xpf.Core.DialogService

Namespace WpfApplication1

    <POCOViewModel>
    Public Class MainViewModel
        Inherits ViewModelBase

        Shared Sub New()
            ' Register custom editors.
            EditingFieldExtensions.Instance.RegisterEditorInfo("ComboBoxEditor", "Custom", "ComboBox Editor")
            EditingFieldExtensions.Instance.RegisterEditorInfo("DateEditor", "Custom", "Date Editor")
            EditingFieldExtensions.Instance.RegisterEditorInfo("PhoneNumberEditor", "Custom", "Phone Number Editor")
        End Sub

        Private Function CreateReport() As XtraReport
            ' Create a new report instance.
            Dim report As XtraReport1 = New XtraReport1()
            ' Enable content editing for controls and assign the required editors.
            report.xrLabel1.EditOptions.Enabled = True
            report.xrLabel1.EditOptions.EditorName = "ComboBoxEditor"
            report.xrLabel2.EditOptions.Enabled = True
            report.xrLabel2.EditOptions.EditorName = "DateEditor"
            report.xrLabel3.EditOptions.Enabled = True
            report.xrLabel3.EditOptions.EditorName = "PhoneNumberEditor"
            Return report
        End Function

        Public Sub ShowPreview()
            ' Show the report's print preview.
            Dim previewService = CType(GetService(Of DevExpress.Mvvm.IDialogService)("previewService"), DialogService)
            previewService.ShowDialog(dialogCommands:=Nothing, title:="Preview", viewModel:=New PreviewViewModel(CreateReport()))
        End Sub
    'public void ShowDesigner() {
    '    // Open the report in the End-User Designer.
    '    var previewService = (DialogService)GetService<DevExpress.Mvvm.IDialogService>("designerService");
    '    previewService.ShowDialog(dialogCommands: null, title: "Report Designer", viewModel: new ReportViewModel(CreateReport()));
    '}
    End Class
End Namespace
