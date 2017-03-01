using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using OSEC.Models;

namespace OSEC.Functionality
{
    static class FileOperations
    {
        static IWorkbook OpenedFile;
        static ISheet Sheet;
        static List<Dots> DotsList;

        public static List<Dots> GetFromExcel(FileStream file)
        {
            DotsList = new List<Dots>();
            OpenedFile = WorkbookFactory.Create(file);
            Sheet = OpenedFile.GetSheetAt(0);

            for (var i = 1; i <= Sheet.LastRowNum; i++)
            {
                if (Sheet.GetRow(i) != null)
                    //if (Sheet.GetRow(i).GetCell(0).NumericCellValue && Sheet.GetRow(i).GetCell(1).NumericCellValue)
                    //{
                        DotsList.Add(new Dots(Sheet.GetRow(i).GetCell(0).NumericCellValue, Sheet.GetRow(i).GetCell(1).NumericCellValue));
                    //}
            }

            return DotsList;
        }
    }
}
