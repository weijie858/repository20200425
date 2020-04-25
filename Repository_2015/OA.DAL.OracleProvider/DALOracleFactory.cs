using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DAL.OracleProvider
{
    public class DALOracleFactory : OA.DALFactory.DalFactory
    {
        public override OA.IDAL.I机构DAL Dal机构Provider
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override OA.IDAL.I部门DAL Dal部门Provider
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
