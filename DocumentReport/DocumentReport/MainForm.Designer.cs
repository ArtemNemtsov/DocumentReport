namespace DocumentReport
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnLoadReport2 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn2 = new DevExpress.XtraBars.BarButtonItem();
            this.Отчеты = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnLoadReport2,
            this.barBtn2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Отчеты});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
            // 
            // barBtnLoadReport2
            // 
            this.barBtnLoadReport2.Caption = "Отчет по выручке за месяц (2.2 задание)";
            this.barBtnLoadReport2.Id = 1;
            this.barBtnLoadReport2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLoadReport2.ImageOptions.Image")));
            this.barBtnLoadReport2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLoadReport2.ImageOptions.LargeImage")));
            this.barBtnLoadReport2.Name = "barBtnLoadReport2";
            this.barBtnLoadReport2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn1_ItemClick);
            // 
            // barBtn2
            // 
            this.barBtn2.Caption = "Результаты ограничения";
            this.barBtn2.Id = 2;
            this.barBtn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn2.ImageOptions.Image")));
            this.barBtn2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn2.ImageOptions.LargeImage")));
            this.barBtn2.Name = "barBtn2";
            this.barBtn2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn2_ItemClick);
            // 
            // Отчеты
            // 
            this.Отчеты.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Отчеты.Name = "Отчеты";
            this.Отчеты.Text = "Отчеты";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnLoadReport2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Моя отчетность";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Отчеты;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadReport2;
        private DevExpress.XtraBars.BarButtonItem barBtn2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}