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

        private void barBtn1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fReport fReport = new fReport
            {
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                NameView = "report.v_document_report",
            };

            fReport.ShowDialog();
        }

        private void barBtn2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fReport fReport = new fReport
            {
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                NameView = "report.v_document_report",
            };

            fReport.ShowDialog();
        }
    }
}
