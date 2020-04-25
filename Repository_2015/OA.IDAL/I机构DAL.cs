using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.IDAL
{
    public interface I机构DAL
    {
        int Insert(Entity.机构 obj);
        int Update(Entity.机构 obj);
        int Delete(Entity.机构 obj);
      //  System.Data.DataSet LoadAll();
        List<Entity.机构> LoadAll();
        Entity.机构 LoadById(Guid id);

        List<Entity.部门>  Load部门by机构(Entity.机构 parentObj);
        List<部门> Load部门by机构(Guid 机构juid);
    }
}
