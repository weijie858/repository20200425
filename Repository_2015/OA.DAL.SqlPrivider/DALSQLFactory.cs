using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.IDAL;

namespace OA.DAL.SqlPrivider
{
    public class DALSQLFactory : OA.DALFactory.DalFactory
    {
        public override I机构DAL Dal机构Provider
        {
            get
            {
                //todo 考虑效率问题，可以使用缓存
                机构DALSqlProvider obj = System.Web.HttpContext.Current.Cache.Get("OA.IDAL.I机构DAL") as 机构DALSqlProvider;
                if (obj == null)
                {
                    obj = new 机构DALSqlProvider();
                    System.Web.HttpContext.Current.Cache.Add("OA.IDAL.I机构DAL", obj, null, System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
              
                return obj;

                
            }
        }

        public override I部门DAL Dal部门Provider
        {
            get
            {
                return new 部门DALSqlProvider();
            }
        }
    }
}
