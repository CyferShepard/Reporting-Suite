using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Productivity_Reporter
{
    class ExcelExporterAVM
    {
        ExcelPackage p = new ExcelPackage();
       
       public ExcelExporterAVM()
        {

        }

        public void writeExcel(string dateS, DataGridView dgv)
        {
            int lastrow = 1;
            var wb = p.Workbook;
            var ws = wb.Worksheets.Add(dateS);
            string[] cols = { "A", "B", "C", "D", "E", "F", "G","H","I","J" };
            for(int i =0;i<cols.Length;i++)
            {
   
                ws.Cells[cols[i]+"1"].Style.Font.Bold = true;
                ws.Cells[cols[i] + "1"].Style.Font.SetFromFont(new Font("Calibri", 11));
                ws.Cells[cols[i] + "1"].Style.Font.Color.SetColor(Color.White);
                ws.Cells[cols[i] + "1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
              
                ws.Cells[cols[i] + "1"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#222B35"));
                ws.Cells[cols[i] + "1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; 


            }
            ws.Cells["A1"].Value= "Accounts Loaded Book Level";
            ws.Cells["B1"].Value = "ServiceID";
            ws.Cells["C1"].Value = "Service Description";
            ws.Cells["D1"].Value = "Accounts Loaded";
            ws.Cells["E1"].Value = "Touched";
            ws.Cells["F1"].Value = "AVM";
            ws.Cells["G1"].Value = "Attempts";
/*          ws.Cells["H1"].Value = "Touched Rate";
            ws.Cells["I1"].Value = "AVM Rate";
            ws.Cells["J1"].Value = "Attempt Rate";*/


            string[] colsCalc = { "H", "I", "J"};
            for (int i = 0; i < colsCalc.Length; i++)
            {

                ws.Cells[colsCalc[i] + "1"].Style.Font.Bold = true;
                ws.Cells[colsCalc[i] + "1"].Style.Font.SetFromFont(new Font("Calibri", 11));
                ws.Cells[colsCalc[i] + "1"].Style.Font.Color.SetColor(Color.White);
                ws.Cells[colsCalc[i] + "1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                         
                ws.Cells[colsCalc[i] + "1"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#375623"));
                ws.Cells[colsCalc[i] + "1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


            }

            ws.Cells["H1"].Value = "Touched Rate";
            ws.Cells["I1"].Value = "AVM Rate";
            ws.Cells["J1"].Value = "Attempt Rate";


            List<int> sep = new List<int>();
           
          
            int firstrow = 2;
            int accbcklvl = 0;
            int startrow = firstrow;
            int bckidold = 0;

            for (int i = 0; i < dgv.RowCount; i++)
            {

                int bckid = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                if (bckidold == 0)
                {
                    bckidold = bckid;
                }

              
               
               // Debug.WriteLine("SID: " + serviceid);
               //
                if (bckid==bckidold)
                {

                   
                    int k = 1;
                    lastrow++;
                    accbcklvl += int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    for (int j = 1; j < dgv.Rows[i].Cells.Count; j++)
                    {
                        
                        if(k<7)
                         {
                               

                             ws.Cells[cols[k] + lastrow].Value = dgv.Rows[i].Cells[j].Value;
                             if(k<3)
                              {
                                     ws.Cells[cols[k] + lastrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                     ws.Cells[cols[k] + lastrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                              }
                             k++;
                         }

                    }
                }
                else
                {
                    bckidold = bckid;
                    ws.Cells["A" + startrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells["A" + startrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                    ws.Cells["A"+startrow].Value = accbcklvl;
                    ws.Cells["A"+ startrow+":A" + lastrow].Merge = true;
                    accbcklvl = 0;
                    lastrow++;
                    startrow = lastrow + 1;
                    sep.Add(lastrow);
                    /////////////////////////////////////////////
                    int k = 1;
                    lastrow++;
                    accbcklvl += int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    for (int j = 1; j < dgv.Rows[i].Cells.Count; j++)
                    {



                        if (k < 7)
                        {


                            ws.Cells[cols[k] + lastrow].Value = dgv.Rows[i].Cells[j].Value;
                            if (k < 3)
                            {
                                ws.Cells[cols[k] + lastrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                ws.Cells[cols[k] + lastrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                            }
                            k++;
                        }

                    }
                }
            }
            ws.Cells["A" + startrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A" + startrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
            ws.Cells["A" + startrow].Value = accbcklvl;
            ws.Cells["A" + startrow + ":A" + lastrow].Merge = true;
            /////////////////////////////////////
            ///

            lastrow++;
            sep.Add(lastrow);
            lastrow++;
            ws.Cells["A" + lastrow + ":C" + lastrow].Merge = true;
            ws.Cells["A"+lastrow].Value = "TOTAL";

            ws.Row(lastrow).Style.Font.Bold = true;
            //lastrow++;
            string format = "#0%";
            //ws.Cells["B" + lastrow].Value = totalagents;


            var cell = ws.Cells["D" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["D2"].Address + ":" + ws.Cells["D" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["E" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["E2"].Address + ":" + ws.Cells["E" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["F" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["F2"].Address + ":" + ws.Cells["F" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["G" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["G2"].Address + ":" + ws.Cells["G" + (lastrow - 1)].Address + ")";

            cell = ws.Cells["H" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["E"+lastrow].Address + "/" + ws.Cells["D" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["I" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["F" + lastrow].Address + "/" + ws.Cells["E" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["J" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["G" + lastrow].Address + "/" + ws.Cells["D" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;


            //////////////////////////////////////////////////////////
            ///
            lastrow++;
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            for (int i = 0; i < 7; i++)
            {

                
                
                    ws.Cells[cols[i] + 1 + ":" + cols[i] + lastrow].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                

            }

            for (int i = 2; i < lastrow; i++)
            {
               
                if(!sep.Contains(i))
                {
                    if(i<lastrow-1)
                    {
                        cell = ws.Cells["H" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["E" + i].Address + "/" + ws.Cells["D" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["I" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["F" + i].Address + "/" + ws.Cells["E" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["J" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["G" + i].Address + "/" + ws.Cells["D" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                    }
                    else
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            ws.Cells[cols[j] + i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells[cols[j] + i].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                           



                        }
                    }
                    
                    for (int j = 0; j < 3; j++)
                    {
                        ws.Cells[colsCalc[j] + i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[colsCalc[j] + i].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#e2efda"));
                        ws.Cells[colsCalc[j] + i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;



                    }
                }

                
            }

          

   


           // ws.Column(12).Width = 4;
            ws.Row(1).Height = 30;
            ws.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Column(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = $"AVM Report {dateS}.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    p.SaveAs(new FileInfo(sfd.FileName));
                    MessageBox.Show("Export Complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
            }
           




        }
    }
}
