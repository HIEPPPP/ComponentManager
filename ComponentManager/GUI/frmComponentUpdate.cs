using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using static System.Collections.Specialized.BitVector32;

namespace ComponentManager.GUI
{
    public partial class frmComponentUpdate : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUnityContainer container;
        private readonly ComponentServices componentServices;
        private readonly CategoryServices categoryServices;
        private readonly LevelServices levelServices;

        public int Id { get; set; }
        public frmComponentUpdate(IUnityContainer container, ComponentServices componentServices, CategoryServices categoryServices, LevelServices levelServices)
        {
            InitializeComponent();
            this.container = container;
            this.componentServices = componentServices;
            this.categoryServices = categoryServices;
            this.levelServices = levelServices;
        }

        public void Initialize(int id)
        {
            this.Id = id;
        }

        void LoadData()
        {
            try
            {
                gluCategory.Properties.DataSource = categoryServices.GetAllCategories();
                gluCategory.Properties.DisplayMember = "Name";
                gluCategory.Properties.ValueMember = "Name";

                gluLevel.Properties.DataSource = levelServices.GetListLevels();
                gluLevel.Properties.DisplayMember = "Name";
                gluLevel.Properties.ValueMember = "Name";


                var component = componentServices.GetComponent(this.Id);

                txtModel.Text = component.Model.ToString();
                txtName.Text = component.Name.ToString();
                txtProvider.Text = component.Provider.ToString();
                txtSession.Text = component.Secssion.ToString();
                gluCategory.Text = component.Category.ToString();
                gluLevel.Text = component.Level.ToString();
                txtMin.Text = component.Min.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi " + ex.Message);
            }
        }

        private void frmComponentUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var component = new Component
            {
                Name = txtName.Text.ToString(),
                Provider = txtProvider.Text.ToString(),
                Level = gluLevel.Text.ToString(),
                Model = txtModel.Text.ToString(),
                Secssion = txtSession.Text,
                Category = gluCategory.Text.ToString(),
                Min = Convert.ToInt32(txtMin.Text),
            };
            try
            {
                componentServices.UpdateComponent(Id, component);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
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