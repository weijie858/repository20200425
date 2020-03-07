using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    #region     //C#中string.Empty、""和null 之间的区别   //https://blog.csdn.net/henulwj/article/details/7830615
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string str2 = string.Empty;
            //  str = str.ToString();//未将对象引用设置到对象的实例
            str2 = str2.ToString();
            Console.WriteLine("台式测试");
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    } 
    #endregion
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("台式测试");
    //        Console.ReadKey();
    //    }
    //}
}
