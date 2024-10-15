using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Repository.Implementation;
using ComponentManager.Repository.Interface;
using ComponentManager.Services;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentManager.GUI
{
    public partial class frmComponentOut : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentServices componentServices;
        private readonly CategoryServices categoryServices;
        private readonly LevelServices levelServices;
        private readonly ComponentOutServices componentOutServices;
        private readonly UserLoginServices loginServices;
        private readonly NotiServices notiServices;

        public frmComponent frmComponent { get; set; }

        public int Id { get; set; }
        public frmComponentOut(ComponentServices componentServices, CategoryServices categoryServices, LevelServices levelServices, ComponentOutServices componentOutServices, UserLoginServices loginServices, NotiServices notiServices)
        {
            InitializeComponent();
            this.componentServices = componentServices;
            this.categoryServices = categoryServices;
            this.levelServices = levelServices;
            this.componentOutServices = componentOutServices;
            this.loginServices = loginServices;
            this.notiServices = notiServices;
        }

        public void Initialize(int id, frmComponent frmComponent)
        {
            this.Id = id;
            this.frmComponent = frmComponent;
        }

        void LoadData()
        {
            try
            {
                var component = componentServices.GetComponent(Id);
                if (component == null)
                {
                    return;
                }
                gluCategory.Properties.DataSource = categoryServices.GetAllCategories();
                gluCategory.Properties.DisplayMember = "Name";
                gluCategory.Properties.ValueMember = "Name";

                gluLevel.Properties.DataSource = levelServices.GetListLevels();
                gluLevel.Properties.DisplayMember = "Name";
                gluLevel.Properties.ValueMember = "Name";

                gluRequestBy.Properties.DataSource = loginServices.GetListUserLogin();
                gluRequestBy.Properties.DisplayMember = "DisplayName";
                gluRequestBy.Properties.ValueMember = "UserCode";

                txtName.Text = component.Name.ToString();
                txtModel.Text = component.Model.ToString();
                txtProvider.Text = component.Provider.ToString();
                txtSession.Text = component.Secssion.ToString();
                gluCategory.Text = component.Category.ToString();
                gluLevel.Text = component.Level.ToString();
                txtAmount.Text = component.Amount.ToString();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void frmComponentOut_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtReason.Text) ||
                    !int.TryParse(txtQuantity.Text, out int quantity) ||
                    quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(txtAmount.Text))
            {
                MessageBox.Show("Số lượng tồn kho không đủ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var amount = Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(txtQuantity.Text);

            var componentOut = new ComponentOut
            {
                Model = txtModel.Text.ToString(),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Reason = txtReason.Text.ToString(),
                RequestBy = gluRequestBy.EditValue.ToString(),
                UsageDate = Convert.ToDateTime(txtDate.Text),
                Amount = amount 
            };

            var noti = new Noti
            {
                Username = Component_Constants.username,
                IsHandled = false,
                NotiType = "Sử dụng",
                Quantity = Convert.ToInt32(txtQuantity.Text),
            };

            frmComponent.UpdateAmount(Convert.ToInt32(txtAmount.Text) - Convert.ToInt32(txtQuantity.Text));

            try
            {
                componentOutServices.CreateComponentOut(componentOut);
                notiServices.CreateNoti(noti);
                MessageBox.Show($"Đã sử dụng {txtQuantity.Text} linh kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }

        
    }
    
}