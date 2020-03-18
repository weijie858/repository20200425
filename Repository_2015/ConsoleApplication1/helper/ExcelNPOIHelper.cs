using System;
using System.IO;
using System.Data;
using System.Collections;

namespace Ming.Provider
{
    using Ming.IProvider;
    using NPOI.SS.UserModel;
    using NPOI.HSSF.UserModel;
    using NPOI.HSSF.Util;
    public class ExcelNPOIHelper : DBHelper, IExcelProvider 
    {
        int perSheetCount = 40000;//每个sheet要保存的条数
        public ExcelNPOIHelper()
        { }
        /// <summary>
        /// 最大接收5万条每页，大于5万时，使用系统默认的值(4万)
        /// </summary>
        /// <param name="perSheetCounts"></param>
        public ExcelNPOIHelper(int perSheetCounts)
        {
            if (perSheetCount <= 50000)
                perSheetCount = perSheetCounts;
        }

        #region IExcelProvider 成员

        public DataTable Import(string fileName, string sheetName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            HSSFWorkbook workbook = new HSSFWorkbook(fs);
            fs.Close();
            sheetName = string.IsNullOrEmpty(sheetName) ? "Sheet1" : sheetName;
            HSSFSheet sheet = workbook.GetSheet(sheetName) as HSSFSheet;
            IEnumerator ie = sheet.GetRowEnumerator();
            
            HSSFRow row = null;
            while (ie.MoveNext())
            {
                row = ie.Current as HSSFRow;//取一行,为了得到column的总数
                break;
            }

            DataTable dt = new DataTable();
            for(int i=0;i<row.LastCellNum ;i++)
                dt.Columns.Add("A"+i.ToString());
            ie.Reset();
            DataRow drow = null;
            HSSFCell cell = null;
            while (ie.MoveNext())
            {
                row = ie.Current as HSSFRow;
                drow = dt.NewRow();
                for (int i = 0; i < row.LastCellNum; i++)
                {

                    if (row.GetCell(i) == null)
                    {
                        drow[i] = null;
                        continue;
                    }
                    cell = row.GetCell(i) as HSSFCell;
                    switch (cell.CellType)
                    {
                        case CellType.BLANK:
                            drow[i] = "[null]";
                            break;
                        case CellType.BOOLEAN:
                            drow[i] = cell.BooleanCellValue;
                            break;
                        case CellType.ERROR:
                            drow[i]=cell.ErrorCellValue;
                            break;
                        case CellType.FORMULA:
                            drow[i]="="+cell.CellFormula;
                            break;
                        case CellType.NUMERIC:
                            drow[i] = cell.NumericCellValue;
                            break;
                        case CellType.STRING:
                            drow[i] = cell.StringCellValue;
                            break;
                        case CellType.Unknown:
                            break;
                        default:
                            drow[i] = null;
                            break;
                    }
                }
                dt.Rows.Add(drow);
            }
            return dt;
        }

        private IFont GetFont(IWorkbook workbook,HSSFColor color)
        {
            IFont font = workbook.CreateFont();
            font.Color = color.GetIndex();
            font.FontHeightInPoints = 10;
            font.Boldweight = 700;
            //font.FontName = "楷体";
            font.IsItalic = true;
            return font;
        }

        public void SetCellValues(ICell cell, string cellType, string cellValue)
        {
            switch (cellType)
            {
                case "System.String": //字符串类型
                    double result;
                    if (double.TryParse(cellValue, out result))
                        cell.SetCellValue(result);
                    else
                        cell.SetCellValue(cellValue);
                    break;
                case "System.DateTime": //日期类型
                    DateTime dateV;
                    DateTime.TryParse(cellValue, out dateV);
                    cell.SetCellValue(dateV);
                    break;
                case "System.Boolean": //布尔型
                    bool boolV = false;
                    bool.TryParse(cellValue, out boolV);
                    cell.SetCellValue(boolV);
                    break;
                case "System.Int16": //整型
                case "System.Int32":
                case "System.Int64":
                case "System.Byte":
                    int intV = 0;
                    int.TryParse(cellValue, out intV);
                    cell.SetCellValue(intV);
                    break;
                case "System.Decimal": //浮点型
                case "System.Double":
                    double doubV = 0;
                    double.TryParse(cellValue, out doubV);
                    cell.SetCellValue(doubV);
                    break;
                case "System.DBNull": //空值处理
                    cell.SetCellValue("");
                    break;
                default:
                    cell.SetCellValue("");
                    break;
            }
        }

        public string Export(string excelFileName, DataTable dtIn)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet=null;
            IRow row=null;
            ICell cell=null;
            int sheetCount = 1;//当前的sheet数量
            int currentSheetCount = 0;//循环时当前保存的条数，每页都会清零

            //表头样式
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.CENTER;
            HSSFColor.GREEN green = new HSSFColor.GREEN();
            style.SetFont(GetFont(workbook,green));

            //内容样式
            style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.CENTER;
            HSSFColor.BLUE blue = new HSSFColor.BLUE();
            style.SetFont(GetFont(workbook, blue));

            sheet = workbook.CreateSheet("Sheet"+sheetCount.ToString());
            //填充表头
            row = sheet.CreateRow(0);
            for (int i = 0; i < dtIn.Columns.Count; i++)
            {
                cell=row.CreateCell(i);
                cell.SetCellValue(dtIn.Columns[i].ColumnName);
                cell.CellStyle = style;
            }
            //填充内容
            for (int i = 0; i < dtIn.Rows.Count; i++)
            {
                if (currentSheetCount >= perSheetCount)
                {
                    sheetCount++;
                    currentSheetCount = 0;
                    sheet = workbook.CreateSheet("Sheet" + sheetCount.ToString());
                }
                if(sheetCount ==1)//因为第一页有表头，所以从第二页开始写
                    row = sheet.CreateRow(currentSheetCount+1);
                else//以后没有表头了，所以从开始写，都是基于0的
                    row = sheet.CreateRow(currentSheetCount);
                currentSheetCount++;
                for (int j = 0; j < dtIn.Columns.Count; j++)
                {
                    cell = row.CreateCell(j);
                    cell.CellStyle =style;
                    SetCellValues(cell, dtIn.Columns[j].DataType.ToString(), dtIn.Rows[i][j].ToString());
                }
            }
            FileStream fs=new FileStream(excelFileName, FileMode.CreateNew , FileAccess.Write);
            workbook.Write(fs);
            fs.Close();
            return excelFileName;
        }

        #endregion
    }
}
