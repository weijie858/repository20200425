using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDD
{
    public abstract class Specification : ISpecification
    {
        #region 接口实现
        public abstract Expression<Func<object, bool>> Expression
        {
            get;
        }

        public bool IsSatisfiedBy(object obj)
        {
            return this.Expression.Compile()(obj);
        } 
        #endregion

        //public virtual bool IsSatisifedBy(object obj)
        //{
        //    return true;
        //}
    }
}
