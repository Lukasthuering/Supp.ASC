using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Supp.ASC.ViewModel;

namespace ATGTest
{
    class ReadExcel:MainViewModel
    {
        static public List<ATGObject> getData(string adress)
        {
            List<ATGObject> objects = new List<ATGObject>();
            var package = new ExcelPackage(new FileInfo(adress));
            ExcelWorksheet sheet = package.Workbook.Worksheets.First();

            int rowStart = 24;
            int columnStart = 1;
            int columnEnd = 10;

            try
            {
                for (int i = rowStart; i <= sheet.Dimension.End.Row; i++)
                {
                    var tempObject = new ATGObject();
                    for (int j = columnStart; j <= columnEnd; j++)
                    {
                        if (sheet.Cells[i, j].Value != null)
                        {
                            switch (j)
                            {
                                case 1:
                                    tempObject.KST = int.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 2:
                                    tempObject.Location = sheet.Cells[i, j].Value.ToString();
                                    break;
                                case 3:
                                    tempObject.Timestamp = DateTime.Parse(sheet.Cells[i, j].Value.ToString(), CultureInfo.CurrentCulture);
                                    break;
                                case 4:
                                    tempObject.Vessel = int.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 5:
                                    tempObject.Product = sheet.Cells[i, j].Value.ToString();
                                    break;
                                case 6:
                                    tempObject.Dipping = double.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 7:
                                    tempObject.Waterlevel = double.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 8:
                                    tempObject.Temperature = double.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 9:
                                    tempObject.Price = double.Parse(sheet.Cells[i, j].Value.ToString());
                                    break;
                                case 10:
                                    tempObject.Status = sheet.Cells[i, j].Value.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    if (tempObject.KST != 0)
                    {
                        objects.Add(tempObject);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("");
            }
            return objects;
        }
    }
}