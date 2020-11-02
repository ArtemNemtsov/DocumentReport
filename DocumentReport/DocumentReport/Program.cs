namespace DocumentReport
{
    using System;
    using System.Windows.Forms;
    using DevExpress.LookAndFeel;
    using DevExpress.Skins;
    using DevExpress.UserSkins;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            InfoConnection.BuildConnectionString();

            MainForm main = new MainForm
            {
                WindowState = FormWindowState.Maximized
            };

            Application.Run(main);
        }
    }
}
