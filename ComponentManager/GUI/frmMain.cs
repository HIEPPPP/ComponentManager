using ComponentManager.Constrant;
using ComponentManager.Models;
using ComponentManager.Services;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ComponentManager.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly frmComponent frmComponent;
        private readonly IUnityContainer container;
        private readonly NotiServices notiServices;
        private Timer checkNewNotiTimer;

        public frmMain(frmComponent frmComponent, IUnityContainer container, NotiServices notiServices)
        {
            InitializeComponent();
            this.frmComponent = frmComponent;
            this.container = container;
            this.notiServices = notiServices;
            checkNewNotiTimer = new Timer();
            checkNewNotiTimer.Interval = 5000; // Kiểm tra mỗi 5 giây
            checkNewNotiTimer.Tick += CheckNewNotiTimer_Tick;
            checkNewNotiTimer.Start();
        }

        private void CheckNewNotiTimer_Tick(object sender, EventArgs e)
        {
            var noti = notiServices.GetNoti();

            if (noti != null)
            {
                int id = Convert.ToInt32(noti.Id);
                string notiType = noti.NotiType.ToString();
                string quantity = noti.Quantity.ToString();
                string username = Component_Constants.username.ToString();

                if (notiType == "Nhập kho")
                {
                    // Hiển thị thông báo nếu có yêu cầu hỗ trợ mới
                    string message = $"{username} đã nhập kho {quantity} linh kiện";
                    //DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo("Yêu cầu hỗ trợ mới", message);
                    alertControl.Show(this, "Thông báo", message, imageCollection.Images[0]);
                } else
                {
                    string message = $"{username} đã lấy ra {quantity} linh kiện";
                    //DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo("Yêu cầu hỗ trợ mới", message);
                    alertControl.Show(this, "Thông báo", message, imageCollection.Images[0]);
                }

                MarkNotiAsHandled(id, noti);
            }
        }

        private void MarkNotiAsHandled(int notiId, Noti noti)
        {
            notiServices.UpdateNoti(notiId, noti);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            // Khi form chính load, hiển thị form frmComponent
            OpenUniqueForm<frmComponent>();
            barUsername.Caption = Component_Constants.username;
        }

        // Hàm kiểm tra và mở form duy nhất
        private void OpenUniqueForm<T>() where T : Form
        {
            // Kiểm tra nếu form đã mở
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    // Nếu form đã mở, kích hoạt form đó
                    form.Activate();
                    return;
                }
            }

            // Nếu form chưa mở, tạo mới và hiển thị
            var frm = container.Resolve<T>();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmComponentAdd = container.Resolve<frmComponentAdd>();
            frmComponentAdd.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenUniqueForm<frmComponentInHistory>();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenUniqueForm<frmComponentOutHistory>();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenUniqueForm<frmComponent>();
        }

        private void liLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            var frmLogin = container.Resolve<frmLogin>();   
            frmLogin.Show();
        }

        private void liCPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmChangePassword = container.Resolve<frmChangePass>();
            frmChangePassword.Initialize(this);
            frmChangePassword.ShowDialog();
        }

        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenUniqueForm<frmEmployee>();
        }
    }
}