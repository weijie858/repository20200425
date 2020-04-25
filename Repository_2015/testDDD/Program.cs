using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository cr; // = new CustomerRepository();
            Customer getByNameCustomer = cr.GetBySpecification(new NameSpecification("Sunny"));
            Customer getByUserNameCustomer = cr.GetBySpecification(new UserNameSpecification("daxnet"));
            IList<Customer> getRetiredCustomers = cr.GetAllBySpecification(new RetiredSpecification());
        }
    }
}
