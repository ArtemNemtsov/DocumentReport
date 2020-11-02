namespace DocumentReport.Forms
{
    partial class fReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.gridCTask2 = new DevExpress.XtraGrid.GridControl();
            this.bsTask2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridVTask2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTask2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTask2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTask2)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCTask2
            // 
            this.gridCTask2.DataSource = this.bsTask2;
            this.gridCTask2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTask2.Location = new System.Drawing.Point(0, 48);
            this.gridCTask2.MainView = this.gridVTask2;
            this.gridCTask2.Name = "gridCTask2";
            this.gridCTask2.Size = new System.Drawing.Size(800, 402);
            this.gridCTask2.TabIndex = 0;
            this.gridCTask2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVTask2});
            // 
            // gridVTask2
            // 
            this.gridVTask2.GridControl = this.gridCTask2;
            this.gridVTask2.Name = "gridVTask2";
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.btnRefresh);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(800, 48);
            this.backPanel.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(12, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(162, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Обновить статистику";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(421, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // fParentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gridCTask2);
            this.Controls.Add(this.backPanel);
            this.Name = "fParentReport";
            this.Load += new System.EventHandler(this.FTask2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTask2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTask2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTask2)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gridCTask2;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridVTask2;
        protected System.Windows.Forms.BindingSource bsTask2;
        protected System.Windows.Forms.Panel backPanel;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}