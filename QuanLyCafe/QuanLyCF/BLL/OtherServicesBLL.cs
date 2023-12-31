﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


    public class OtherServicesBLL
    {
        static String CTName = "Khang Cafe";
        static String Address = "140 Lê Trọng Tấn, P.Tây Thạnh, Q.Tân Phú";
        static string DVT = "$";
        public static void ExportFile(DataTable dataTable, List<string> plus, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            //Tao ten cong ty
            Microsoft.Office.Interop.Excel.Range ct = oSheet.get_Range("B1", "E1");

            ct.MergeCells = true;

            ct.Value2 = CTName;

            ct.Font.Bold = true;

            ct.Font.Name = "Times New Roman";

            ct.Font.Size = "20";

            ct.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo address
            Microsoft.Office.Interop.Excel.Range add = oSheet.get_Range("B2", "D2");
            add.MergeCells = true;
            add.Value2 = "Địa chỉ: " + Address;


            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("B4", "E4");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo thông tin bill
            Microsoft.Office.Interop.Excel.Range tt1 = oSheet.get_Range("B5", "B5");

            tt1.Value2 = "Ngày tháng: " + plus[0];

            Microsoft.Office.Interop.Excel.Range table = oSheet.get_Range("C7", "C7");

            table.Value2 = "Bàn: " + plus[1];
            table.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;



            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("B8", "B8");

            cl1.Value2 = "Tên sản phẩm";

            cl1.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("C8", "C8");

            cl2.Value2 = "Số lượng";

            cl2.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("D8", "D8");

            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("E8", "E8");

            cl4.Value2 = "Thành Tiền";

            cl4.ColumnWidth = 10.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("B8", "E8");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 9;

            int columnStart = 2;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count  + 1;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            Microsoft.Office.Interop.Excel.Range textTotal = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd +1, columnStart];
            textTotal.Value2 = "Tổng Tiền: ";

            Microsoft.Office.Interop.Excel.Range total = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd +1, columnEnd];
            total.Value2 = plus[3]+DVT;

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
