using System;
using System.Threading.Tasks;

namespace DocumentReport.Forms
{
    public partial class fReport : DevExpress.XtraEditors.XtraForm
    {
        internal string NameView { get; set; }
        internal string NameScheme { get; set; }

        private fReport()
        {
            InitializeComponent();
        }

        // при создание экземпляра классав асинхронно вызывается метод
        public static async Task<fReport> Create(string nameScheme, string nameView)
        {
            var myReport = new fReport
            {
                NameScheme = nameScheme,
                NameView = nameView
            };

            await myReport.ReftreshReportAsync();
            return myReport;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await ReftreshReportAsync();
        }

        // асинхронно обновляем dataGrid c данными
        private async Task ReftreshReportAsync()
        {
            bsTask2.DataSource = null;
            bsTask2.DataSource = await Task.Run(() => DataAdapter.SelectData($"select * from {NameScheme}.{NameView} "));
        }
    }
}
