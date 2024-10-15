namespace ComponentManager.GUI
{
    partial class frmComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponent));
            this.gcComponent = new DevExpress.XtraGrid.GridControl();
            this.gvComponent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecssion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUseComponent = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhapKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefesh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComponent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcComponent
            // 
            this.gcComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcComponent.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcComponent.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gcComponent.Location = new System.Drawing.Point(12, 12);
            this.gcComponent.MainView = this.gvComponent;
            this.gcComponent.Name = "gcComponent";
            this.gcComponent.Size = new System.Drawing.Size(804, 417);
            this.gcComponent.TabIndex = 0;
            this.gcComponent.UseEmbeddedNavigator = true;
            this.gcComponent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComponent});
            this.gcComponent.Load += new System.EventHandler(this.gcComponent_Load);
            // 
            // gvComponent
            // 
            this.gvComponent.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvComponent.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComponent.Appearance.Row.Options.UseTextOptions = true;
            this.gvComponent.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvComponent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colModel,
            this.colLevel,
            this.colCategory,
            this.colProvider,
            this.colSecssion,
            this.colAmount,
            this.colId,
            this.colMin});
            this.gvComponent.GridControl = this.gcComponent;
            this.gvComponent.Name = "gvComponent";
            this.gvComponent.OptionsView.ShowAutoFilterRow = true;
            this.gvComponent.OptionsView.ShowGroupPanel = false;
            this.gvComponent.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAmount, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvComponent.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvComponent_CustomDrawCell);
            this.gvComponent.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvComponent_RowStyle);
            this.gvComponent.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvComponent_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Tên linh kiện";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 97;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            this.colModel.Width = 97;
            // 
            // colLevel
            // 
            this.colLevel.Caption = "Mức độ quan trọng";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 2;
            this.colLevel.Width = 117;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Loại linh kiện";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 3;
            this.colCategory.Width = 93;
            // 
            // colProvider
            // 
            this.colProvider.Caption = "Nhà cung cấp";
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 4;
            this.colProvider.Width = 93;
            // 
            // colSecssion
            // 
            this.colSecssion.Caption = "Đơn vị";
            this.colSecssion.FieldName = "Secssion";
            this.colSecssion.Name = "colSecssion";
            this.colSecssion.Visible = true;
            this.colSecssion.VisibleIndex = 5;
            this.colSecssion.Width = 93;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Số lượng";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 93;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colMin
            // 
            this.colMin.Caption = "Số lượng MIN";
            this.colMin.FieldName = "Min";
            this.colMin.Name = "colMin";
            this.colMin.Visible = true;
            this.colMin.VisibleIndex = 7;
            this.colMin.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUseComponent);
            this.groupBox1.Controls.Add(this.btnNhapKho);
            this.groupBox1.Controls.Add(this.btnRefesh);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnUseComponent
            // 
            this.btnUseComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseComponent.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseComponent.Appearance.Options.UseFont = true;
            this.btnUseComponent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUseComponent.ImageOptions.Image")));
            this.btnUseComponent.Location = new System.Drawing.Point(581, 18);
            this.btnUseComponent.Name = "btnUseComponent";
            this.btnUseComponent.Size = new System.Drawing.Size(105, 42);
            this.btnUseComponent.TabIndex = 5;
            this.btnUseComponent.Text = "Sử dụng";
            this.btnUseComponent.Click += new System.EventHandler(this.btnUseComponent_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapKho.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Appearance.Options.UseFont = true;
            this.btnNhapKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.ImageOptions.Image")));
            this.btnNhapKho.Location = new System.Drawing.Point(692, 16);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(105, 42);
            this.btnNhapKho.TabIndex = 4;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Appearance.Options.UseFont = true;
            this.btnRefesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ImageOptions.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(271, 16);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(105, 42);
            this.btnRefesh.TabIndex = 3;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(95, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(183, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(7, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcComponent);
            this.Name = "frmComponent";
            this.Text = "Linh kiện tồn kho";
            ((System.ComponentModel.ISupportInitialize)(this.gcComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComponent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcComponent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComponent;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRefesh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colSecssion;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.SimpleButton btnUseComponent;
        private DevExpress.XtraEditors.SimpleButton btnNhapKho;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMin;
    }
}