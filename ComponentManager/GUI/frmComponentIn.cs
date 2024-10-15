using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Design;
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
using Unity;

namespace ComponentManager.GUI
{
    public partial class frmComponentIn : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentServices componentServices;
        private readonly CategoryServices categoryServices;
        private readonly LevelServices levelServices;
        private readonly ComponentInServices componentInServices;
        //private readonly frmComponent frmComponent;
        private readonly IUnityContainer container;
        private readonly NotiServices notiServices;

        public frmComponent frmComponent {  get; set; }

        public int Id { get; set; }
        public frmComponentIn(ComponentServices componentServices, CategoryServices categoryServices, LevelServices levelServices, ComponentInServices componentInServices, IUnityContainer container, NotiServices notiServices)
        {
            InitializeComponent();
            this.componentServices = componentServices;
            this.categoryServices = categoryServices;
            this.levelServices = levelServices;
            this.componentInServices = componentInServices;
            this.frmComponent = frmComponent;
            this.container = container;
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

        private void frmComponentIn_Load(object sender, EventArgs e)
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
                    string.IsNullOrWhiteSpace(txtProvider.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text) ||
                    !int.TryParse(txtQuantity.Text, out int quantity) ||
                    !int.TryParse(txtPrice.Text, out int price) ||
                    quantity <= 0 ||
                    price <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var amount = Convert.ToInt32(txtAmount.Text) + Convert.ToInt32(txtQuantity.Text);

            var componentIn = new ComponentIn
            {
                Quantity = Convert.ToInt32(txtQuantity.Text),
                NgayNhap = Convert.ToDateTime(txtDate.Text),
                Provider = txtProvider.Text.ToString(),
                Price = Convert.ToDouble(txtPrice.Text), 
                Model = txtModel.Text.ToString(),
                Note = txtNote.Text.ToString(),
                Amount = amount,
            };

            var noti = new Noti
            {
                NotiType = "Nhập kho",
                IsHandled = false,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Username = Component_Constants.username,
            };
            
            frmComponent.UpdateAmount(Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(txtAmount.Text));

            try
            {
                componentInServices.CreateComponentIn(componentIn);
                notiServices.CreateNoti(noti);
                MessageBox.Show("Nhập kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                this.Close();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message );
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}