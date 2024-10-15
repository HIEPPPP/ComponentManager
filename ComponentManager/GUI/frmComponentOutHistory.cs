using ComponentManager.Constrant;
using ComponentManager.Repository.Interface;
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
    public partial class frmComponentOutHistory : DevExpress.XtraEditors.XtraForm
    {
        private readonly IComponentOutHisRepository componentOutHisRepository;

        public frmComponentOutHistory(IComponentOutHisRepository componentOutHisRepository)
        {
            InitializeComponent();
            this.componentOutHisRepository = componentOutHisRepository;
        }

        private void gcComponentOut_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            gcComponentOut.DataSource = componentOutHisRepository.GetList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Component_Constants.ExportExcel(gcComponentOut);
        }
    }
}