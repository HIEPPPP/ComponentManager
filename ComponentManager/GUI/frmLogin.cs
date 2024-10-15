using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using System;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserLoginServices loginServices;
        private readonly UserRoleServices userRoleServices;
        private readonly IUnityContainer container;

        public frmLogin(UserLoginServices loginServices,UserRoleServices userRoleServices, IUnityContainer container)
        {
            InitializeComponent();
            this.loginServices = loginServices;
            this.userRoleServices = userRoleServices;
            this.container = container;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userCode = txtUserCode.Text.ToString().Trim();
            var password = txtPassword.Text.ToString().Trim();
            if (string.IsNullOrEmpty(userCode) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = loginServices.Login(userCode, password);
            if (result)
            {
                Component_Constants.userId = userCode;
                Component_Constants.password = password;
                Component_Constants.username = loginServices.GetUserLogin(userCode).DisplayName.ToString();
                List<UserRole> roles = userRoleServices.GetListUserRoleByUserCode(userCode);
                if(roles.Count > 0)
                {
                    Component_Constants.userRoles = roles;
                }
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frmMain = container.Resolve<frmMain>();  
                this.Hide();    
                frmMain.ShowDialog();
                this.Show();               
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
             

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection.Images[1]; 
            txtPassword.Properties.UseSystemPasswordChar = false; 
        }

        private void txtPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection.Images[0]; 
            txtPassword.Properties.UseSystemPasswordChar = true; 
        }



        //private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}