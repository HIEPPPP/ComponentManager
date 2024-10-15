using ComponentManager.GUI;
using ComponentManager.Repository.Interface;
using ComponentManager.Repository.Implementation;
using ComponentManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ComponentManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new UnityContainer().AddExtension(new Diagnostic());

            // Đăng ký REPO
            container.RegisterType<IComponentRepository, ComponentRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ILevelRepository, LevelRepository>();
            container.RegisterType<IComponentInHisRepository, ComponentInHisRepository>();
            container.RegisterType<IComponentInRepository, ComponentInRepository>();
            container.RegisterType<IComponentOutRepository, ComponentOutRepository>();
            container.RegisterType<IComponentOutHisRepository, ComponentOutHisRepository>();
            container.RegisterType<IUserLoginRepository, UserLoginRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<INotiRepository, NotiRepository>();

            // Đăng ký Services
            container.RegisterType<ComponentServices>();
            container.RegisterType<CategoryServices>();
            container.RegisterType<LevelServices>();
            container.RegisterType<ComponentInHisServices>();
            container.RegisterType<ComponentInServices>();
            container.RegisterType<ComponentOutServices>();
            container.RegisterType<UserLoginServices>();
            container.RegisterType<UserRoleServices>();
            container.RegisterType<EmployeeServices>();
            container.RegisterType<NotiServices>();


            // Đăng ký FORM
            container.RegisterType<frmMain>();
            container.RegisterType<frmComponent>();
            container.RegisterType<frmComponentAdd>();
            container.RegisterType<frmComponentUpdate>();
            container.RegisterType<frmComponentInHistory>();
            container.RegisterType<frmComponentOutHistory>();
            container.RegisterType<frmComponentIn>();
            container.RegisterType<frmComponentOut>();
            container.RegisterType<frmLogin>();
            container.RegisterType<frmChangePass>();
            container.RegisterType<frmEmployee>();
            container.RegisterType<frmEmployeeAdd>();

            var mainForm = container.Resolve<frmLogin>();
            Application.Run(mainForm);
        }
    }
}
