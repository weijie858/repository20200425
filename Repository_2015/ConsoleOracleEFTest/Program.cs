using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOracleEFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EMP> list = null;
            using (Entities db = new Entities())
            {
                list = db.EMPs.Select(x => x).ToList();
            }
            Console.WriteLine();
            Console.ReadLine();
        
        }
    }
}
