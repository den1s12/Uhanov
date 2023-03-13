
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Uhanov.ClassFolder
//{
//    public static void ToExcelFile(DataGrid listDataGrid, string namelist)
//    {
//        Excel.Application excelApplication = null;
//        Excel.Workbook workbook = null;
//        Excel.Worksheet sheet = null;
//        var process = Process.GetProcessesByName("Excel");

//        SaveFileDialog openDlg = new SaveFileDialog();
//        openDlg.Filter = namelist;
//        openDlg.Filter = "Excel (.xls)|*.xls |Excel (.xlsx)|*xlsx |All files (*.*)|*.*";
//        openDlg.FilterIndex = 2;
//        openDlg.RestoreDirectory = true;
//        string path = openDlg.FileName;

//        if (openDlg.ShowDialog() == true)
//        {
//            excelApplication = new Excel.Application();
//            excelApplication.Visible = true;
//            workbook = excelApplication.Workbooks.Add(System.Reflection.Missing.Value);
//            sheet = (Excel.Worksheet)workbook.Sheets[1];
//        }
//    }
//}
