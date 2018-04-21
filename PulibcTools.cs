using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace WS_PUR_TOOL
{
    class PulibcTools
    {

        /// <summary>
        /// 获取本机IPV4
        /// </summary>
        /// <returns></returns>
        public static string GetClientLocalIPv4Address()
        {
            string strLocalIP = string.Empty;
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHost.AddressList[1];
                strLocalIP = ipAddress.ToString();
                return strLocalIP;
            }
            catch
            {
                return "unknown";
            }
        }

        /// <summary>
        /// 读取EXCEL文件上的数据表
        /// 重载,默认只读,不可修改
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="sheetNumber"></param>
        /// <returns></returns>
        public static DataTable ExcelToDT(String Path, int sheetNumber)
        {
            return ExcelToDT(Path, sheetNumber, true, false);
        }

        /// <summary>
        /// 读取EXCEL文件上的数据表
        /// </summary>
        /// <param name="Path">EXCEL文件的路径</param>
        /// <param name="pageNumber">EXCEL表的页数(sheet),从1开始</param>
        /// <returns></returns>
        public static DataTable ExcelToDT(String Path, int sheetNumber, Boolean readOnly, Boolean editable)
        {
            DataTable dt = new DataTable();
            object missing = System.Reflection.Missing.Value;
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook wb = excelApp.Application.Workbooks.Open(Path, missing, readOnly, missing, missing, missing, missing, missing, missing, editable, missing, missing, missing, missing, missing);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(sheetNumber);
            int rowsCount = ws.UsedRange.Cells.Rows.Count;
            int columsCount = ws.UsedRange.Cells.Columns.Count;
            Object[,] arry = (Object[,])ws.UsedRange.Value2;
            int i = arry.GetLength(0);
            int j = arry.GetLength(1);
            dt = ConvertToDataTable(arry);
            return dt;
        }



        /// <summary>
        /// 二维数组转DataTable,第一行为标题
        /// </summary>
        /// <param name="arr">二维数组</param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable(Object[,] arr)
        {

            DataTable dataSouce = new DataTable();
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                DataColumn newColumn = new DataColumn(arr[1, i + 1].ToString());
                dataSouce.Columns.Add(newColumn);
            }
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                DataRow newRow = dataSouce.NewRow();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newRow[j] = arr[i + 1, j + 1];
                }
                dataSouce.Rows.Add(newRow);
            }
            return dataSouce;
        }


    }
}
