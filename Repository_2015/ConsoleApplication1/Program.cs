using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("台式测试");
    //        Console.ReadKey();
    //    }
    //}



    #region NPOI  2.0 使用教程详解 https://blog.csdn.net/mouday/article/details/81049219
    #region excel 1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        //  第一步，引用空间
    //        //using NPOI.HSSF.UserModel;
    //        //using NPOI.SS.UserModel;
    //        HSSFWorkbook wk = new HSSFWorkbook();
    //        //第二步，创建工作簿(workbook)和sheet
    //        //创建一个Sheet  
    //        ISheet sheet = wk.CreateSheet("例子");
    //        //第三步，创建行和单元格
    //        //在第一行创建行  
    //        IRow row = sheet.CreateRow(0);
    //        //在第一行的第一列创建单元格  
    //        ICell cell = row.CreateCell(0);
    //        //接下来我们可以使用这个函数对单元格赋值
    //        cell.SetCellValue("测试");
    //        //最后，将做好的这个EXCEL保存到硬盘上。
    //        //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建时不要打开该文件  
    //        using (FileStream fs = File.OpenWrite("d:\\excel.xls"))
    //        {
    //            wk.Write(fs);//向打开的这个xls文件中写入并保存。 
    //  fs.Close(); 
    //        }
    //        Console.WriteLine("台式测试");
    //        Console.ReadKey();
    //    }
    //}
    #endregion


    //#region  excel 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //上一篇教程中生成的文件  
    //        string tempPath = "d:\\excel.xls";
    //        HSSFWorkbook wk = null;
    //        using (FileStream fs = File.Open(tempPath, FileMode.Open,
    //        FileAccess.Read, FileShare.ReadWrite))
    //        {
    //            //把xls文件读入workbook变量里，之后就可以关闭了  
    //            wk = new HSSFWorkbook(fs);
    //            fs.Close();
    //        }
    //        var sheet = wk.GetSheetAt(0);
    //        IRow row = sheet.CreateRow(1);
    //        //在第二行的第一列创建单元格    
    //        row.CreateCell(0).SetCellValue("编辑的值");
    //        using (FileStream fs = File.OpenWrite("d:\\excel2.xls"))
    //        {
    //            wk.Write(fs);//向打开的这个xls文件中写入并保存。  
    //            fs.Close();
    //        }
    //        Console.WriteLine("台式测试");
    //        Console.ReadKey();
    //    }
    //} 
    //#endregion



    #region excel ICellStyle
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //NPOI 2.0 使用教程详解 https://blog.csdn.net/mouday/article/details/81049219
    //        //  第一步，引用空间
    //        //using NPOI.HSSF.UserModel;
    //        //using NPOI.SS.UserModel;
    //        HSSFWorkbook wk = new HSSFWorkbook();
    //        #region 样式设置
    //        ICellStyle cellStyle = wk.CreateCellStyle();
    //        //设置单元格上下左右边框线  
    //        cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
    //        cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
    //        cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
    //        cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
    //        //文字水平和垂直对齐方式  
    //        cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
    //        cellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
    //        //是否换行  
    //        //cellStyle.WrapText = true;  
    //        //缩小字体填充  
    //        cellStyle.ShrinkToFit = true;
    //        #endregion




    //        //第二步，创建工作簿(workbook)和sheet
    //        //创建一个Sheet  
    //        ISheet sheet = wk.CreateSheet("例子");
    //        //第三步，创建行和单元格
    //        //在第一行创建行  
    //        IRow row = sheet.CreateRow(0);
    //        //在第一行的第一列创建单元格  
    //        ICell cell = row.CreateCell(0);
    //        //接下来我们可以使用这个函数对单元格赋值
    //        cell.SetCellValue("测试3333");


    //        cell.CellStyle = cellStyle;
    //        //最后，将做好的这个EXCEL保存到硬盘上。
    //        //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建时不要打开该文件  
    //        using (FileStream fs = File.OpenWrite("d:\\excel.xls"))
    //        {
    //            wk.Write(fs);//向打开的这个xls文件中写入并保存。 
    //            fs.Close();
    //        }
    //        Console.WriteLine("台式测试");
    //        Console.ReadKey();
    //    }
    //}
    #endregion 
    #endregion


    #region     //C#中string.Empty、""和null 之间的区别   //https://blog.csdn.net/henulwj/article/details/7830615
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = null;
    //        string str2 = string.Empty;
    //        //  str = str.ToString();//未将对象引用设置到对象的实例
    //        str2 = str2.ToString();
    //        Console.WriteLine("台式测试");
    //        Console.WriteLine(str);
    //        Console.WriteLine(str2);
    //        Console.ReadKey();
    //    }
    //} 
    #endregion







}
