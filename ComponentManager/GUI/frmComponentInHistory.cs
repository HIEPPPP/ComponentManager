using ComponentManager.Constrant;
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
    public partial class frmComponentInHistory : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentServices componentServices;
        private readonly ComponentInHisServices componentInServices;

        public frmComponentInHistory(ComponentServices componentServices, ComponentInHisServices componentInServices)
        {
            InitializeComponent();
            this.componentServices = componentServices;
            this.componentInServices = componentInServices;
        }

        void LoadData()
        {
            gcComponentIn.DataSource = componentInServices.GetListComponentIn();
        }

        private void gcComponentIn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Component_Constants.ExportExcel(gcComponentIn);
        }
    }
}