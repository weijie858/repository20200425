using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DALFactory
{
    //#region 1
    //public class DALFactory
    //{
    //    #region MyRegion
    //    public IDAL.机构IDAL Dal机构Provider(string providerName)
    //    {
    //        IDAL.机构IDAL d = null;
    //        if (providerName == "sql")
    //        {
    //            return d;
    //        }
    //        else if (providerName == "oracle")
    //        {
    //            return d;
    //        }
    //        return d;
    //    }
    //    #endregion
    //}
    //#endregion

    #region 2
    public abstract class DalFactory
    {
        public abstract IDAL.I机构DAL Dal机构Provider
        {
            get;
            //set;
        }
        public abstract IDAL.I部门DAL Dal部门Provider
        {
            get; 
            //set;
        }
    } 
    #endregion
}
