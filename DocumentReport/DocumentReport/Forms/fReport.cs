using System;
using System.Threading.Tasks;

namespace DocumentReport.Forms
{
    public partial class fReport : DevExpress.XtraEditors.XtraForm
    {
        internal string NameView { get; set; }

        public fReport()
        {
            InitializeComponent();
        }

        // после загрузки формы данные асинхронно загрузятся
        private async void FTask2_Load(object sender, EventArgs e)
        {
            await ReftreshReportAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await ReftreshReportAsync();
        }

        // асинхронно обновляем dataGrid c данными
        private async Task ReftreshReportAsync()
        {
            bsTask2.DataSource = null;
            bsTask2.DataSource = await Task.Run(() => DataAdapter.SelectData($"select * from {NameView}"));
        }
    }
}
