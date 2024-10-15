using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ComponentManager.GUI
{
    public partial class frmComponent : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentServices services;
        private readonly IUnityContainer container;

        public int IdSend { get; set; }
        public int QuantitySend { get; set; }

        public int Quantity { get; set; }

        public frmComponent(ComponentServices services, IUnityContainer container)
        {
            InitializeComponent();
            this.services = services;
            this.container = container;
        }

        #region Methods
        void LoadData()
        {
            gcComponent.DataSource = services.GetListComponent();
            gvComponent.RowStyle += gvComponent_RowStyle;
        }

        public void UpdateAmount(int newAmount)
        {
            var component = new Component
            {
                Amount = newAmount,
            };
            services.UpdateAmount(IdSend, component);
        }
        #endregion

        #region Events

        private void gcComponent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmComponentAdd = container.Resolve<frmComponentAdd>();
            frmComponentAdd.FormClosed += new FormClosedEventHandler(gcComponent_Load);
            frmComponentAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frmComponentUpdate = container.Resolve<frmComponentUpdate>();
            frmComponentUpdate.FormClosed += new FormClosedEventHandler(gcComponent_Load);
            frmComponentUpdate.Initialize(IdSend);
            frmComponentUpdate.ShowDialog();
        }

        private void gvComponent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var idSelected = gvComponent.GetFocusedRowCellValue("Id");
            var quantitySelected = gvComponent.GetFocusedRowCellValue("Amount");
            if (idSelected == null || quantitySelected == null)
            {
                IdSend = -1;
                QuantitySend = 0;
                return;
            }
            IdSend = Convert.ToInt32(idSelected);
            QuantitySend = Convert.ToInt32(quantitySelected);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa linh kiện?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                services.DeleteComponent(IdSend);
                MessageBox.Show("Xóa thành công thông tin linh kiện!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {            
            var frmComponentIn = container.Resolve<frmComponentIn>();
            frmComponentIn.FormClosed += new FormClosedEventHandler(gcComponent_Load);
            frmComponentIn.Initialize(IdSend, this);
            frmComponentIn.ShowDialog();            
        }

        private void btnUseComponent_Click(object sender, EventArgs e)
        {
            var frmComponentOut = container.Resolve<frmComponentOut>();
            frmComponentOut.FormClosed += new FormClosedEventHandler(gcComponent_Load);
            frmComponentOut.Initialize(IdSend, this);
            frmComponentOut.ShowDialog();
        }

        private void gvComponent_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //GridView view = sender as GridView;

            //if (e.RowHandle >= 0) // Đảm bảo đó là dòng dữ liệu (không phải header hay footer)
            //{
            //    // Lấy giá trị của cột "Amount" để kiểm tra điều kiện
            //    int quantity = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, view.Columns["Amount"]));

            //    // Nếu số lượng nhỏ hơn hoặc bằng 10, đổi màu nền thành màu đỏ
            //    if (quantity <= 10)
            //    {
            //        e.Appearance.BackColor = Color.Red;
            //        e.Appearance.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        // Đặt màu mặc định nếu không thỏa điều kiện
            //        e.Appearance.BackColor = Color.White;
            //        e.Appearance.ForeColor = Color.Black;
            //    }
            //}
        }

        private void gvComponent_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0 && e.Column.FieldName == "Amount") // Kiểm tra dòng dữ liệu và đúng cột "Amount"
            {
                int quantity = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, view.Columns["Amount"]));
                int min = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, view.Columns["Min"]));

                // Nếu số lượng nhỏ hơn hoặc bằng 10, tô màu ô thành màu đỏ
                if (quantity <= min)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                else
                {
                    // Đặt màu mặc định nếu không thỏa điều kiện
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }
        #endregion
    }
}