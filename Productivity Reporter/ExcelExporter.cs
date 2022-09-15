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
    class ExcelExporter
    {
        ExcelPackage p = new ExcelPackage();
       
       public  ExcelExporter()
        {

        }

        public void writeExcel(string dateS, DataGridView dgv,int totalagents)
        {
            int lastrow = 1;
            var wb = p.Workbook;
            var ws = wb.Worksheets.Add(dateS);
            string[] cols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
            for(int i =0;i<11;i++)
            {
   
                ws.Cells[cols[i]+"1"].Style.Font.Bold = true;
                ws.Cells[cols[i] + "1"].Style.Font.SetFromFont(new Font("Calibri", 11));
                ws.Cells[cols[i] + "1"].Style.Font.Color.SetColor(Color.White);
                ws.Cells[cols[i] + "1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
              
                ws.Cells[cols[i] + "1"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#222B35"));
                ws.Cells[cols[i] + "1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; 


            }
            ws.Cells["A1"].Value= "Department";
            ws.Cells["B1"].Value = "Agents";
            ws.Cells["C1"].Value = "ServiceID";
            ws.Cells["D1"].Value = "Service Name";
            ws.Cells["E1"].Value = "Accounts Loaded";
            ws.Cells["F1"].Value = "Touched";
            ws.Cells["G1"].Value = "Contacts";
            ws.Cells["H1"].Value = "RPC";
            ws.Cells["I1"].Value = "PTP";
            ws.Cells["J1"].Value = "Debit Order";
            ws.Cells["K1"].Value = "Attempts";  

            string[] colsCalc = { "M", "N", "O", "P", "Q"};
            for (int i = 0; i < 5; i++)
            {

                ws.Cells[colsCalc[i] + "1"].Style.Font.Bold = true;
                ws.Cells[colsCalc[i] + "1"].Style.Font.SetFromFont(new Font("Calibri", 11));
                ws.Cells[colsCalc[i] + "1"].Style.Font.Color.SetColor(Color.White);
                ws.Cells[colsCalc[i] + "1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                         
                ws.Cells[colsCalc[i] + "1"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#375623"));
                ws.Cells[colsCalc[i] + "1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


            }

            ws.Cells["M1"].Value = "Touched Rate";
            ws.Cells["N1"].Value = "Contact Rate";
            ws.Cells["O1"].Value = "RPC Rate";
            ws.Cells["P1"].Value = "PTP Rate";
            ws.Cells["Q1"].Value = "Debit Order Rate";

            List<int> sep = new List<int>();

            int[] campaignID_Project1 = {1,2,3,4,5,6,7,8,9,10 };
            int[] campaignID_Project2 = {11,12,13,14,15,16,17,18,19,20};
            sep.Add(2);
            int v = 0;
            int firstrow = 3;
            sep.Add(firstrow);
            ws.Cells["D"+firstrow].Value = "Project 2";
            ws.Cells["D" + firstrow].Style.Font.UnderLine = true;
            ws.Cells["D" + firstrow].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            //firstrow++;
            lastrow = firstrow;


            ///------------------Supervisor 1
            for (int i = 0; i < dgv.RowCount; i++)
            {
                int serviceid = int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
               // Debug.WriteLine("SID: " + serviceid);
               //
                if (campaignID_Project2.Contains(serviceid))
                {

                   
                    if(v==0)
                    {
                        ws.Cells["A2"].Value = "Supervisor Name Here";
                        ws.Cells["A2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells["A2"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                    }

                    v++;
                    int k = 1;
                    lastrow++;
                    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    {
                        
                           
                            
                                    if(k<11)
                                     {
                                           

                                            ws.Cells[cols[k] + lastrow].Value = dgv.Rows[i].Cells[j].Value;
                                                if(k<4)
                                                 {
                                                        ws.Cells[cols[k] + lastrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                                        ws.Cells[cols[k] + lastrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                                                 }
                            k++;
                        }

                    }
                }               
            }

            /////////////////////////////////////////////////////////////
            ///
            if (v > 0)
            {
                ws.Cells["A2:A" + lastrow].Merge = true;
                lastrow++;
                firstrow = lastrow + 1;
                sep.Add(lastrow);
                v = 0;
            }
            //lastrow++;
            ws.Cells["D" + lastrow].Value = "Project 1";
            ws.Cells["D" + lastrow].Style.Font.UnderLine = true;
            ws.Cells["D" + lastrow].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            firstrow++;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                int serviceid = int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
                // Debug.WriteLine("SID: " + serviceid);
                //
                if (campaignID_Project1.Contains(serviceid))
                {


                    if (v == 0)
                    {
                        ws.Cells["A2"].Value = "Supervisor Name Here";
                        ws.Cells["A2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells["A2"].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                    }

                    v++;
                    int k = 1;
                    lastrow++;
                    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    {



                        if (k < 11)
                        {


                            ws.Cells[cols[k] + lastrow].Value = dgv.Rows[i].Cells[j].Value;
                            if (k < 4)
                            {
                                ws.Cells[cols[k] + lastrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                ws.Cells[cols[k] + lastrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                            }
                            k++;
                        }

                    }
                }
            }
            /////////////////////////////////////
            ///
            if (v>0)
            {
                ws.Cells["A2:A" + lastrow].Merge = true;
                lastrow++;
                firstrow = lastrow+1;
                sep.Add(lastrow);
                v = 0;
            }

            /// 
            /// 
            string[] supervisor = { "Supervisor Name Here 2", "Supervisor Name Here 3", "Supervisor Name Here 4", "Supervisor Name Here 5" };
            int[] range = { 300,400,700,900 };
            int[] range2 = {399,499,899,999 };
            ////////
            for(int r=0; r<4; r++)
            {

                ////////////////////////////////////////
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    int serviceid = int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
                    // Debug.WriteLine("SID: " + serviceid);
                    if (serviceid >= range[r] && serviceid <= range2[r])
                    {
                        if (v == 0)
                        {
                            ws.Cells["A" + (lastrow + 1)].Value = supervisor[r];
                            ws.Cells["A" + (lastrow + 1)].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells["A" + (lastrow + 1)].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                        }


                        v++;
                        int k = 1;
                        lastrow++;
                        for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                        {



                            if (k < 11)
                            {


                                ws.Cells[cols[k] + lastrow].Value = dgv.Rows[i].Cells[j].Value;
                                if (k < 4)
                                {
                                    ws.Cells[cols[k] + lastrow].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                    ws.Cells[cols[k] + lastrow].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                                }
                                k++;
                            }

                        }
                    }
                }
                
                if (v > 0)
                {
                    ws.Cells["A" + firstrow + ":A" + lastrow].Merge = true;
                    lastrow++;
                    firstrow = lastrow + 1;
                    sep.Add(lastrow);
                    v = 0;
                }
                ///////////////////////////////////////

            }
           

            lastrow+=3;
            sep.Add(lastrow);
            lastrow++;
            sep.Add(lastrow);
            ws.Cells["A"+lastrow].Value = "Total Distinct Agents";
            ws.Row(lastrow).Style.Font.UnderLine = true;
            ws.Row(lastrow).Style.Font.Bold = true;

            string format = "#0%";
            ws.Cells["B" + lastrow].Value = totalagents;
            

            var cell  = ws.Cells["E" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["E2"].Address + ":" + ws.Cells["E" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["F" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["F2"].Address + ":" + ws.Cells["F" + (lastrow-1)].Address + ")";
            cell = ws.Cells["G" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["G2"].Address + ":" + ws.Cells["G" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["H" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["H2"].Address + ":" + ws.Cells["H" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["I" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["I2"].Address + ":" + ws.Cells["I" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["J" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["J2"].Address + ":" + ws.Cells["J" + (lastrow - 1)].Address + ")";
            cell = ws.Cells["K" + lastrow];
            cell.Formula = "=SUM(" + ws.Cells["K2"].Address + ":" + ws.Cells["K" + (lastrow - 1)].Address + ")";

            cell = ws.Cells["M" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["F"+lastrow].Address + "/" + ws.Cells["E" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["N" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["G" + lastrow].Address + "/" + ws.Cells["F" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["O" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["H" + lastrow].Address + "/" + ws.Cells["G" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["P" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["I" + lastrow].Address + "/" + ws.Cells["H" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;
            cell = ws.Cells["Q" + lastrow];
            cell.Formula = "=IFERROR(" + ws.Cells["J" + lastrow].Address + "/" + ws.Cells["H" + (lastrow)].Address + ",0)";
            cell.Style.Numberformat.Format = format;

            //////////////////////////////////////////////////////////
            ///
            ws.Cells[ws.Dimension.Address].AutoFitColumns();
            for (int i = 0; i < 11; i++)
            {

                
                if (i != 3)
                {
                    ws.Cells[cols[i] + 1 + ":" + cols[i] + lastrow].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

            }

            for (int i = 2; i < lastrow+1; i++)
            {
               
                if(!sep.Contains(i))
                {
                    if(i<lastrow-3)
                    {
                        cell = ws.Cells["M" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["F" + i].Address + "/" + ws.Cells["E" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["N" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["G" + i].Address + "/" + ws.Cells["F" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["O" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["H" + i].Address + "/" + ws.Cells["G" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["P" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["I" + i].Address + "/" + ws.Cells["H" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                        cell = ws.Cells["Q" + i];
                        cell.Formula = "=IFERROR(" + ws.Cells["J" + i].Address + "/" + ws.Cells["H" + i].Address + ",0)";
                        cell.Style.Numberformat.Format = format;
                    }
                    else
                    {

                        for (int j = 0; j < 4; j++)
                        {
                            ws.Cells[cols[j] + i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells[cols[j] + i].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#d6dce4"));
                           



                        }
                    }
                    
                    for (int j = 0; j < 5; j++)
                    {
                        ws.Cells[colsCalc[j] + i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[colsCalc[j] + i].Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#e2efda"));
                        ws.Cells[colsCalc[j] + i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;



                    }
                }

                
            }

          

   


            ws.Column(12).Width = 4;
            ws.Row(1).Height = 30;
            ws.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Column(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = $"Productivity Report {dateS}.xlsx";
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
