using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.IDAL
{
    public interface I部门DAL
    {
        int Insert(Entity.部门 obj);
        int Update(Entity.部门 obj);
        int Delete(Entity.部门 obj);
        //  System.Data.DataSet LoadAll();
        List<Entity.部门> LoadAll();
        Entity.部门 LoadById(Guid id);
        机构 FindParent(部门 child);
    }
}
