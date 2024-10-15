using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentManager.GUI
{
    public partial class frmComponentAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentServices componentServices;
        private readonly CategoryServices categoryServices;
        private readonly LevelServices levelServices;
        private readonly NotiServices notiServices;

        public frmComponentAdd(ComponentServices componentServices, CategoryServices categoryServices, LevelServices levelServices, NotiServices notiServices)
        {
            InitializeComponent();
            this.componentServices = componentServices;
            this.categoryServices = categoryServices;
            this.levelServices = levelServices;
            this.notiServices = notiServices;
        }

        void LoadData()
        {
            txtModel.Text = GenerateModel();

            var categories = categoryServices.GetAllCategories();

            gluCategory.Properties.DataSource = categories;
            gluCategory.Properties.DisplayMember = "Name";
            gluCategory.Properties.ValueMember = "Id";


            if (categories != null && categories.Count > 0)
            {
                gluCategory.EditValue = null;
                //gluCategory.EditValue = categories[0].Id;
            }

            var levels = levelServices.GetListLevels();
            gluLevel.Properties.DataSource = levels;
            gluLevel.Properties.DisplayMember = "Name";
            gluLevel.Properties.ValueMember = "Id";

            if (levels != null && levels.Count > 0)
            {
                gluCategory.EditValue = null;
                //gluLevel.EditValue = levels[0].Id;
            }
        }

        private string GenerateModel()
        {           
            string prefix = "C"; 
            string datePart = DateTime.Now.ToString("yyyyMMddHHmmss"); 

            
            //string category = gluCategory.EditValue.ToString();

            // Kết hợp để tạo Model
            return $"{prefix}-{datePart}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtProvider.Text) ||
                string.IsNullOrWhiteSpace(txtSession.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string generatedModel = GenerateModel();

            var component = new Component
            {
                Category = gluCategory.Text.ToString(),
                Name = txtName.Text.ToString(),
                Model = txtModel.Text.ToString(),
                Level = gluLevel.Text.ToString(),
                Provider = txtProvider.Text.ToString(),
                Secssion = txtSession.Text.ToString(),
                Amount = Convert.ToInt32(txtAmount.Text),
                Min = Convert.ToInt32(txtMin.Text),
            };

            var noti = new Noti
            {
                IsHandled = false,
                NotiType = "Nhập kho",
                Quantity = Convert.ToInt32(txtAmount.Text),
                Username = Component_Constants.username,
            };

            try
            {
                componentServices.CreateComponent(component);
                notiServices.CreateNoti(noti);
                MessageBox.Show("Thêm linh kiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComponentAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}