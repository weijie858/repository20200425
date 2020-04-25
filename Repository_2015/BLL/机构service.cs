using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class 机构service
    {
        private OA.DALFactory.DalFactory datafactory = DateProvider.DefaultProvider;
        #region add
        public int add(Entity.机构 obj)
        {
            //用反射 通过web.config获得当前提供程序的名，在实例化
           // OA.DALFactory.DalFactory datafactory = null;
            return datafactory.Dal机构Provider.Insert(obj);
        }
        public int add(string name ,string 简称)
        {
            return this.add(Guid.NewGuid(), name, 简称,null);
            //return this.add(new Entity.机构
            //{
            //    机构ID=Guid.NewGuid(),
            //    名称 = name,
            //    简称= 简称,

            //});
        }
        public int add(string name, string 简称,int sort)
        {
            return this.add( Guid.NewGuid(), name, 简称 , sort);
        }

        public int add( Guid id, string name, string 简称, int? sort)
        {
            return this.add(new Entity.机构
            {
                机构ID = id,
                名称 = name,
                简称 = 简称,
                排序 = sort
            });
        }
        #endregion

        #region delete
        public int delete(Entity.机构 obj)
        {
           // OA.DALFactory.DalFactory datafactory = null;
            return datafactory.Dal机构Provider.Delete(obj);
        }
        public int delete(Guid id)
        {
            var obj = datafactory.Dal机构Provider.LoadById(id);
            return this.delete(obj);
     
        }
        #endregion

        #region update
        public int update(Entity.机构 obj)
        {
            OA.DALFactory.DalFactory datafactory = null;
            return datafactory.Dal机构Provider.Update(obj);
           
        }
        public int update(Guid id ,string name, string 简称,int  sort)
        {
            var d = new Entity.机构()
            {
                机构ID = id,
                名称 = name,
                简称 = 简称,
                排序=sort,
            };
            return this.update(d);
        }
        #endregion

        #region query
        public Entity.机构 find(Guid id)
        {
            return datafactory.Dal机构Provider.LoadById(id);
           // return null;
        }
        public List<Entity.机构> findAll()
        {
            return datafactory.Dal机构Provider.LoadAll();
        }

        public List<Entity.部门> findAll部门(Guid id)
        {
            return datafactory.Dal机构Provider.Load部门by机构(id);
        }
        #endregion

    }
}
