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

namespace ComponentManager.GUI
{
    public partial class frmEmployeeAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly EmployeeServices employeeServices;

        public frmEmployeeAdd(EmployeeServices employeeServices)
        {
            InitializeComponent();
            this.employeeServices = employeeServices;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string folderSaveUpload = "G:\\FileExport\\ImageTest";
            string pathImage = Component_Constants.OpenFileAndGetPath();

            var fileName = Component_Constants.SaveImageWithTimestamp(pathImage, folderSaveUpload);
            txtFileName.Text = fileName;    
            try
            {
                pictureEdit1.Image = Image.FromFile(pathImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hình ảnh: " + ex.Message);
            }           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            var employee = new Employee
            {
                MaNV = txtMaNV.Text.ToString(),
                FullName = txtFullName.Text.ToString(),
                Department = txtDepartment.Text.ToString(),
                Birthday = Convert.ToDateTime(txtBirthday.Text),
                ChucVu = txtChucVu.Text.ToString(),
                PhoneNumber = txtPhone.Text.ToString(),
                Image = "G:\\FileExport\\ImageTest\\" + txtFileName.Text.ToString(),
            };

            employeeServices.CreateEmployee(employee);
            MessageBox.Show("Thêm nhân viên thành công!");
            this.Close();

        }
    }
}