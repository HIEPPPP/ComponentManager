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
    public partial class frmEmployeeUpdate : DevExpress.XtraEditors.XtraForm
    {
        private readonly EmployeeServices employeeServices;

        public int Id { get; set; }
        public string fromFile { get; set; }
        public frmEmployeeUpdate(EmployeeServices employeeServices)
        {
            InitializeComponent();
            this.employeeServices = employeeServices;
        }

        public void Initial(int id, string fromFile)
        {
            this.Id = id;
            this.fromFile = fromFile;
        }

        public void LoadData()
        {
            var employee = employeeServices.GetEmployeeById(this.Id);

            txtMaNV.Text = employee.MaNV;
            txtDepartment.Text = employee.Department;   
            txtFullName.Text = employee.FullName;   
            txtChucVu.Text = employee.ChucVu;
            txtFileName.Text = employee.Image;
            txtBirthday.Text = employee.Birthday.ToString();
            txtPhone.Text = employee.PhoneNumber.ToString();

            if (this.fromFile == null || string.IsNullOrEmpty(this.fromFile))
            {
                this.fromFile = string.Empty;
                return;
            }
            else
            {
                try
                {
                    pictureEdit1.Image = Image.FromFile(this.fromFile);
                }
                catch(Exception ex)
                {
                    return;   
                }
            }
        }

        private void frmEmployeeUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee
                {
                    MaNV = txtMaNV.Text.ToString(),
                    Department = txtDepartment.Text.ToString(),
                    FullName = txtFullName.Text.ToString(),
                    PhoneNumber = txtPhone.Text.ToString(),
                    Birthday = Convert.ToDateTime(txtBirthday.Text),
                    ChucVu = txtChucVu.Text.ToString(),
                    Image = "G:\\FileExport\\ImageTest\\" + txtFileName.Text.ToString(),

                };
                employeeServices.UpdateEmployee(this.Id, employee);
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
        
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
    }
}