using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using DialogService = DevExpress.Xpf.Core.DialogService;

namespace WpfApplication1 {
    [POCOViewModel]
    public class MainViewModel : ViewModelBase {
        static MainViewModel() {
            // Register custom editors.
            EditingFieldExtensions.Instance.RegisterEditorInfo("ComboBoxEditor", "Custom", "ComboBox Editor");
            EditingFieldExtensions.Instance.RegisterEditorInfo("DateEditor", "Custom", "Date Editor");
            EditingFieldExtensions.Instance.RegisterEditorInfo("PhoneNumberEditor", "Custom", "Phone Number Editor");
        }

        XtraReport CreateReport() {
            // Create a new report instance.
            XtraReport1 report = new XtraReport1();

            // Enable content editing for controls and assign the required editors.
            report.xrLabel1.EditOptions.Enabled = true;
            report.xrLabel1.EditOptions.EditorName = "ComboBoxEditor";

            report.xrLabel2.EditOptions.Enabled = true;
            report.xrLabel2.EditOptions.EditorName = "DateEditor";

            report.xrLabel3.EditOptions.Enabled = true;
            report.xrLabel3.EditOptions.EditorName = "PhoneNumberEditor";

            return report;
        }

        public void ShowPreview() {
            // Show the report's print preview.
            var previewService = (DialogService)GetService<DevExpress.Mvvm.IDialogService>("previewService");
            previewService.ShowDialog(dialogCommands: null, title: "Preview", viewModel: new PreviewViewModel(CreateReport()));
        }

        //public void ShowDesigner() {
        //    // Open the report in the End-User Designer.
        //    var previewService = (DialogService)GetService<DevExpress.Mvvm.IDialogService>("designerService");
        //    previewService.ShowDialog(dialogCommands: null, title: "Report Designer", viewModel: new ReportViewModel(CreateReport()));
        //}
    }
}
