using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class DateProvider
    {
        private static OA.DALFactory.DalFactory _instance;

        static DateProvider()
        {
            //。net能保证这里的代码只执行一次
            //   todo: 根据web.config动态反射实例化数据工厂的实例
            string dllfileName = System.Web.Configuration.WebConfigurationManager.AppSettings["DataProviderDllFile"];
            string dalfactoryClassName = System.Web.Configuration.WebConfigurationManager.AppSettings["DataProviderFactoryName"];
            string path = System.Web.HttpContext.Current.Server.MapPath("~/dataproviders/" + dllfileName);
            System.Reflection.Assembly dll = System.Reflection.Assembly.LoadFile(path);
            _instance = dll.CreateInstance(dalfactoryClassName) as OA.DALFactory.DalFactory;
        }
        private DateProvider()
        {
           // _instance = null;
        }
        public static OA.DALFactory.DalFactory DefaultProvider
        {
            get
            {
                //if (_instance == null)
                //    _instance = null; //;new OA.DALFactory.DalFactory();
                return _instance;
            }
            //set;
        }
    }
}
