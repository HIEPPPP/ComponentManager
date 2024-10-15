using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly UserLoginServices userLoginServices;
        private bool isExitClicked = false;

        public frmMain frmMain { get; set; }

        public frmChangePass(Form form, UserLoginServices userLoginServices)
        {
            InitializeComponent();            
            this.userLoginServices = userLoginServices;
        }

        public void Initialize(frmMain frmMain)
        {
            this.frmMain = frmMain;
        }

        void LoadData()
        {
            txtCode.Text = Component_Constants.userId.ToString();
            txtName.Text = Component_Constants.username.ToString();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            isExitClicked = false; 
            this.Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            if (password != Component_Constants.password.ToString()) 
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var userlogin = new UserLogin
            {
                UserCode = txtCode.Text.ToString(),
                DisplayName = txtName.Text.ToString(),
                Password = txtPassNew.Text.ToString(),
            };
            if (txtPassNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                userLoginServices.UpdatePassword(txtCode.Text, userlogin);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isExitClicked = true;
                this.Close();
                frmMain.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void frmChangePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
            if (isExitClicked)  
            {
                frmMain.Close();
            }
        }
    }
}