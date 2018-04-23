using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.XtraReports.UI;

namespace WpfApplication1 {
    public class ReportViewModel : BindableBase {
        public XtraReport Report { get; private set; }
        public ReportViewModel(XtraReport report) {
            Report = report;
        }
    }

    public class PreviewViewModel : ReportViewModel {
        public PreviewViewModel(XtraReport report)
            : base(report) {
            // Fill the itemsSource of a ComboBox editor.
            ComboBoxItemsSource = Enumerable.Range(1, 20)
                .Select(x => string.Format("Item {0}", x));

            // Set the minimum and maximum values for a DateTime editor.
            DateTimeMin = DateTime.Now.AddMonths(-2);
            DateTimeMax = DateTime.Now.AddMonths(2);
        }

        public IEnumerable<string> ComboBoxItemsSource { get; private set; }
        public DateTime DateTimeMin { get; private set; }
        public DateTime DateTimeMax { get; private set; }
    }
}
