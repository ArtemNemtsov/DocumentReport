using DocumentReport.Forms;
using System.Windows.Forms;

namespace DocumentReport
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void ShowReport(string nameScheme, string nameView)
        {
            var report = await fReport.Create(nameScheme, nameView);
            report.TopMost = true;
            report.ShowDialog();
        }

        private void barBtn1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReport("report", "v_document_report");
        }

        private void barBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReport("report", "v_restriction_report");
        }

        private void barBtnCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReport("report", "CITY");
        }

        private void barBtnFirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReport("report", "FIRM");
        }

        private void barBtnDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReport("report", "document");
        }
    }
}
