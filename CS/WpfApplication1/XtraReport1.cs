using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace WpfApplication1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, CancelEventArgs e) {
            PrintingSystem.EditingFieldChanged += new EventHandler<DevExpress.XtraPrinting.EditingFieldEventArgs>(PrintingSystem_EditingFieldChanged);
        }

        void PrintingSystem_EditingFieldChanged(object sender, DevExpress.XtraPrinting.EditingFieldEventArgs e) {
            if (((TextEditingField)e.EditingField).EditorName == "DateEditor") {
                e.EditingField.Brick.Text = string.Format("{0:MMMM dd, yyyy}", System.Convert.ToDateTime(e.EditingField.Brick.Text));
            }
        }

    }
}
