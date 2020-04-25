using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD
{
    public class NameSpecification : Specification
    {
        protected string name;
        public NameSpecification(string name) { this.name = name; }
        public override bool IsSatisifedBy(object obj)
        {
            return (obj as Customer).FirstName.Equals(name);
        }
    }
    public class UserNameSpecification : NameSpecification
    {
        public UserNameSpecification(string name) : base(name) { }
        public override bool IsSatisifedBy(object obj)
        {
            return (obj as Customer).UserName.Equals(this.name);
        }
    }
    public class RetiredSpecification : Specification
    {
        public override bool IsSatisifedBy(object obj)
        {
            return (obj as Customer).Age >= 60;
        }
    }

}
