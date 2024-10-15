namespace ComponentManager.GUI
{
    partial class frmComponentOutHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentOutHistory));
            this.gcComponentOut = new DevExpress.XtraGrid.GridControl();
            this.gvComponentOut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcComponentOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComponentOut)).BeginInit();
            this.SuspendLayout();
            // 
            // gcComponentOut
            // 
            this.gcComponentOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcComponentOut.Location = new System.Drawing.Point(12, 12);
            this.gcComponentOut.MainView = this.gvComponentOut;
            this.gcComponentOut.Name = "gcComponentOut";
            this.gcComponentOut.Size = new System.Drawing.Size(835, 562);
            this.gcComponentOut.TabIndex = 0;
            this.gcComponentOut.UseEmbeddedNavigator = true;
            this.gcComponentOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComponentOut});
            this.gcComponentOut.Load += new System.EventHandler(this.gcComponentOut_Load);
            // 
            // gvComponentOut
            // 
            this.gvComponentOut.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvComponentOut.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComponentOut.Appearance.Row.Options.UseTextOptions = true;
            this.gvComponentOut.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComponentOut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Quantity,
            this.colDate,
            this.colReason,
            this.colRequestBy,
            this.colModel,
            this.colName,
            this.colCategory,
            this.colProvider,
            this.colAmount});
            this.gvComponentOut.GridControl = this.gcComponentOut;
            this.gvComponentOut.Name = "gvComponentOut";
            this.gvComponentOut.OptionsView.ShowAutoFilterRow = true;
            this.gvComponentOut.OptionsView.ShowGroupPanel = false;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Số lượng sử dụng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 7;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày sử dụng";
            this.colDate.FieldName = "UsageDate";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colReason
            // 
            this.colReason.Caption = "Lý do";
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 2;
            // 
            // colRequestBy
            // 
            this.colRequestBy.Caption = "Người yêu cầu";
            this.colRequestBy.FieldName = "RequestBy";
            this.colRequestBy.Name = "colRequestBy";
            this.colRequestBy.Visible = true;
            this.colRequestBy.VisibleIndex = 3;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Tên linh kiện";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Loại linh kiện";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 5;
            // 
            // colProvider
            // 
            this.colProvider.Caption = "Nhà cung cấp";
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 6;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tổng SL sau khi dùng";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(659, 580);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 38);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Refesh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(756, 580);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 38);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmComponentOutHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 630);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gcComponentOut);
            this.Name = "frmComponentOutHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử dùng linh kiện";
            ((System.ComponentModel.ISupportInitialize)(this.gcComponentOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComponentOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcComponentOut;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComponentOut;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    }
}