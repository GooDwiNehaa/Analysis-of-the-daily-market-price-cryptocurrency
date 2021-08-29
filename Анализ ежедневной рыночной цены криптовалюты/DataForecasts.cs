using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    class DataForecasts
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessId);

        Work work;
        private List<List<object>> lists = new List<List<object>>();

        public DataForecasts()
        {
            work = new Work();
            lists = work.DataTransfer(Form3.nameC, Work.dsf, Work.defoltDt);
        }

        public List<List<object>> ExcelDataForecasting(int srok)
        {
            //Объявляем приложение
            Excel.Application ex = new Excel.Application();
            //Отобразить Excel
            ex.Visible = false;
            //Количество листов в рабочей книге
            ex.SheetsInNewWorkbook = 1;
            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            ex.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = "Прогнозы";

            for (int i = 2; i < lists[0].Count + 1; i++)
            {
                sheet.Cells[1, i] = lists[0][i - 1].ToString();
            }

            int k = 2;

            for (int i = 0; i < lists.Count - 1; i++)
            {
                for (int j = 1; j < lists[i].Count + 1; j++)
                {
                    if (j == 1)
                    {
                        sheet.Cells[k, j] = lists[i + 1][j - 1].ToString();
                    }
                    else
                    {
                        sheet.Cells[k, j] = Convert.ToDouble(lists[i + 1][j - 1]);
                    }
                }

                k++;
            }

            k = 0;

            Excel.Range forYach = sheet.Cells[1, lists[0].Count] as Excel.Range;
            int yach = Convert.ToInt32(forYach.Value);

            for (int i = 1; i < srok + 1; i++)
            {
                sheet.Cells[1, lists[0].Count + i] = (yach + i).ToString();
            }
            
            Excel.Range knownXRange = sheet.get_Range(sheet.Cells[1, 2] as Excel.Range, sheet.Cells[1, lists[0].Count] as Excel.Range);
            Excel.Range newXRange = sheet.get_Range(sheet.Cells[1, lists[0].Count + 1] as Excel.Range, sheet.Cells[1, lists[0].Count + srok] as Excel.Range);

            string strKnownXRange = knownXRange.get_Address(0, 0, Excel.XlReferenceStyle.xlA1, Type.Missing, Type.Missing);
            string strNewXRange = newXRange.get_Address(0, 0, Excel.XlReferenceStyle.xlA1, Type.Missing, Type.Missing);

            for (int i = 2; i < lists.Count + 1; i++)
            {
                Excel.Range yRange = sheet.get_Range(sheet.Cells[i, 2] as Excel.Range, sheet.Cells[i, lists[0].Count] as Excel.Range);
                string strYRange = yRange.get_Address(0, 0, Excel.XlReferenceStyle.xlA1, Type.Missing, Type.Missing);

                string strFormula = $"=ТЕНДЕНЦИЯ({strYRange};{strKnownXRange};{strNewXRange})";

                Excel.Range formulaRange = sheet.get_Range(sheet.Cells[i, lists[0].Count + 1] as Excel.Range, sheet.Cells[i, lists[0].Count + srok] as Excel.Range);

                formulaRange.FormulaLocal = strFormula;
            }

            List<List<object>> listsOut = new List<List<object>>();
            listsOut.Clear();

            Excel.Range er = sheet.Cells[1, 1] as Excel.Range;

            listsOut.Add(new List<object>() { Convert.ToString(er.Value) });

            for (int i = 2; i < lists[0].Count + srok + 1; i++)
            {
                er = sheet.Cells[1, i] as Excel.Range;
                listsOut[0].Add(Convert.ToString(er.Value));
            }

            for (int i = 1; i < lists.Count; i++)
            {
                listsOut.Add(new List<object>() { lists[i][0].ToString() });
            }

            for (int i = 2; i < listsOut.Count + 1; i++)
            {
                for (int j = 2; j < listsOut[0].Count + 1; j++)
                {
                    er = sheet.Cells[i, j] as Excel.Range;
                    listsOut[i - 1].Add(Convert.ToString(er.Value));
                }
            }

            lists.Clear();

            if (ex != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(new IntPtr(ex.Hwnd), ref excelProcessId);

                Process ExcelProc = Process.GetProcessById(excelProcessId);
                if (ExcelProc != null)
                {
                    ExcelProc.Kill();
                }
            }

            return listsOut;
        }
    }
}
