using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ComponentManager.GUI
{
    public partial class frmEmployee : DevExpress.XtraBars.TabForm
    {
        private readonly EmployeeServices employeeServices;
        private readonly IUnityContainer container;

        public string FromFile { get; set; }
        public int Id;

        public frmEmployee(EmployeeServices employeeServices, IUnityContainer container)
        {
            InitializeComponent();
            this.employeeServices = employeeServices;
            this.container = container;
        }

        void LoadData()
        {
            gcEmployee.DataSource = employeeServices.GetListEmployee();
        }

        private void acUpdate_Click(object sender, EventArgs e)
        {

        }

        private void gcEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var fromFile = gvEmployee.GetFocusedRowCellValue("Image");
            var id = gvEmployee.GetFocusedRowCellValue("Id");   
            if (fromFile == null || string.IsNullOrEmpty(fromFile.ToString()))
            {
                pictureEdit.Image = null;
                return;
            }
            if (id == null )
            {
                return;
            }
            Id = Convert.ToInt32(id);
            FromFile = fromFile.ToString();
            if (File.Exists(FromFile))
            {
                pictureEdit.Image = Image.FromFile(FromFile);
            }
            else
            {
                pictureEdit.Image = null;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmEmployeeAdd = container.Resolve<frmEmployeeAdd>();
            frmEmployeeAdd.FormClosed += new FormClosedEventHandler(gcEmployee_Load);
            frmEmployeeAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frmEmployeeUpdate = container.Resolve<frmEmployeeUpdate>();
            frmEmployeeUpdate.Initial(Id, FromFile);
            frmEmployeeUpdate.FormClosed += new FormClosedEventHandler(gcEmployee_Load);
            frmEmployeeUpdate.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                   return;
                }
                employeeServices.DeleteEmployee(Id);
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Component_Constants.ExportExcel(gcEmployee);
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Component_Constants.Print(gcEmployee);

        }
    }
}