using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Threading;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Reflection;
using Productivity_Reporter.Classes;

namespace Productivity_Reporter
{
    public partial class Form1 : Form
    {

        int totalagents = 0;

        public Form1()
        {
            InitializeComponent();

            panelReport.Hide();
            panelGen.Hide();
            panelAVM.Hide();
            pnlADL.Hide();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string currentversion = fvi.FileVersion;
            // Debug.WriteLine(version);
            string version = "";
            var charsToRemove = new string[] { ".0" };
            foreach (var ca in charsToRemove)
            {
                version = currentversion.Replace(ca, string.Empty);
            }
            this.Text += " - V" + version;


        }




    

        private void btnExecute_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(generateReport);
            thread.IsBackground = true;
            thread.Start();
            panelGen.Show();
            panelGen.BringToFront();
            menuStrip1.Enabled = false;
            panelReport.Enabled = false;
            label3.Enabled = true;
            label3.Text = "Generating Report";




        }

        public void generateReport()
        {
            dgvOutput.Invoke((System.Action)delegate { dgvOutput.Rows.Clear(); });
            DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            SqlConnection connection = new SqlConnection();
           string connstring = $"Data Source=database;Initial Catalog=DB1;Integrated Security=SSPI;";// AD Login
            csb.ConnectionString = connstring;
            connection.ConnectionString = csb.ConnectionString;

            try
            {

                if (!System.IO.Directory.Exists("scripts"))
                {
                    System.IO.Directory.CreateDirectory("scripts");
                }
                  
                if (!System.IO.File.Exists("scripts/script1.sql"))
                {
                    StreamWriter file = new StreamWriter("scripts/script1.sql");
                    file.Close();
                }

                string date = dtDate.Value.ToString("yyyy-MM-dd");
                string date2 = dtDate.Value.AddDays(1).ToString("yyyy-MM-dd");

                //
                string SQLFILE = System.IO.File.ReadAllText("scripts/script1.sql");
                Debug.WriteLine("File Lenght: " + SQLFILE.Length);
                if (SQLFILE.Length == 0)
                {
                    throw new Exception("script1 SQL File is blank");
                }

                SQLFILE = SQLFILE.Replace("{date}", date);
                SQLFILE = SQLFILE.Replace("{date2}", date2);
                Debug.WriteLine("File: " + SQLFILE);
                connection.Open();
                SqlCommand cmd = new SqlCommand(SQLFILE, connection);
               
                /////////////////////////////////////////////////////////////
               // connection.Open();
                
                Debug.WriteLine("Date: "+date);
                Debug.WriteLine("Date + 1: " + date2);
                cmd.CommandTimeout = 600;
                SqlDataReader dr = cmd.ExecuteReader();
                // dr.Read();


                while (dr.Read())
                {
                    
                    int agents = int.Parse(dr[0].ToString());
                    int serviceid = int.Parse(dr[1].ToString());
                    string servicename = dr[2].ToString();
                    int accloaded = int.Parse(dr[3].ToString());
                    int touched =0;
                    int contacts = 0;
                    int rpc = 0;
                    int ptp = 0;
                    int debitorder = 0;
                    int attempts = 0;
                    if (dr[4].ToString() != "")
                    {
                        touched = int.Parse(dr[4].ToString());
                    }
                    if (dr[5].ToString() != "")
                    {
                        contacts = int.Parse(dr[5].ToString());
                    }
                    if (dr[6].ToString() != "")
                    {
                        rpc = int.Parse(dr[6].ToString());
                    }
                    if (dr[7].ToString() != "")
                    {
                        ptp = int.Parse(dr[7].ToString());
                    }
                    Debug.WriteLine("DR8: "+dr[8]);
                    if (dr[8].ToString() != "")
                    {
                        debitorder = int.Parse(dr[8].ToString());
                    }
                    if (dr[9].ToString() != "")
                    {
                        attempts = int.Parse(dr[9].ToString());
                    }

                    double totalacc = double.Parse(accloaded+"");
                    double touchedacc = double.Parse(touched+"");
                    double cont = double.Parse(contacts+"");
                    double rpcv = double.Parse(rpc+"");
                    double ptpv = double.Parse(ptp+"");
                    double dov = double.Parse(debitorder+"");
                    Debug.WriteLine(" | " + totalacc + " | " + touchedacc + " | " + cont + " | " + rpcv + " | " + ptpv + " | " + dov);
                    string tr = Math.Round((touchedacc / totalacc) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string cr = Math.Round((cont / touchedacc) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string rpcr = Math.Round((rpcv / cont) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string ptpr = Math.Round((ptpv / rpcv) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string dor = Math.Round((dov / rpcv) * 100.0, MidpointRounding.AwayFromZero) + "%";

                    if (touchedacc == 0)
                    {
                        cr = "0%";
                    }
                    if (totalacc == 0)
                    {
                        tr = "0%";
                    }
                    if (cont == 0)
                    {
                        rpcr = "0%";

                    }
                    if (rpcv == 0)
                    {
                        ptpr = "0%";
                        dor = "0%";

                    }

                    Debug.WriteLine(" | " + tr + " | " + cr + " | " + rpcr + " | " + ptpr + " | " + dor);
                    dgvOutput.Invoke((System.Action)delegate { dgvOutput.Rows.Add(agents, serviceid, servicename, accloaded, touched, contacts, rpc, ptp, debitorder, attempts, tr, cr, rpcr, ptpr, dor); });
                   



                }
                dr.NextResult();
                dr.NextResult();
                dr.Read();
                totalagents = int.Parse(dr[0].ToString());
                Debug.WriteLine("Next Result: "+totalagents);
                connection.Close();
                

               
             

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.ToString());
              /*  isValid = false;*/
                //  return false;
            }
            panelGen.Invoke((System.Action)delegate { panelGen.Hide(); menuStrip1.Enabled = true;  });

            panelReport.Invoke((System.Action)delegate { panelReport.Enabled = true; });
            menuStrip1.Invoke((System.Action)delegate { menuStrip1.Enabled = true; });
        }

        public void generateAVMReport()
        {
            dgvAVM.Invoke((System.Action)delegate { dgvAVM.Rows.Clear(); });
            DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            SqlConnection connection = new SqlConnection();
            string connstring = $"Data Source=database;Initial Catalog=DB1;Integrated Security=SSPI;";
            csb.ConnectionString = connstring;
            connection.ConnectionString = csb.ConnectionString;

            try
            {
                //string filename = (cmbScriptSelector.SelectedItem as ComboBoxItem).Value.ToString();
                string filename = "";
                cmbScriptSelector.Invoke((System.Action)delegate { filename=(cmbScriptSelector.SelectedItem as ComboBoxItem).Value.ToString(); });
                Debug.WriteLine("Value: "+filename);
                
                string date = dtDateAVM.Value.ToString("yyyy-MM-dd"); ;
                string date2 = dtDateAVM.Value.AddDays(1).ToString("yyyy-MM-dd");

                //
                string SQLFILE = System.IO.File.ReadAllText("scripts/"+filename);
                Debug.WriteLine("File Lenght: " + SQLFILE.Length);
                if (SQLFILE.Length==0)
                {
                    throw new Exception("script2 SQL File is blank");
                }

                SQLFILE=SQLFILE.Replace("{date}", date);
                SQLFILE=SQLFILE.Replace("{date2}", date2);
                Debug.WriteLine("File: " + SQLFILE);
                connection.Open();
                SqlCommand cmd = new SqlCommand(SQLFILE, connection);
                
               
                cmd.CommandTimeout = 600;
                SqlDataReader dr = cmd.ExecuteReader();
                // dr.Read();


                while (dr.Read())
                {

                    int bck_id = int.Parse(dr[0].ToString());
                    string servicename = dr[1].ToString();
                    int serviceid = int.Parse(dr[2].ToString());
                    int accloaded = int.Parse(dr[3].ToString());
                    int touched = 0;
                    int avm = 0;
                    int attempts = 0;
                    if (dr[4].ToString() != "")
                    {
                        touched = int.Parse(dr[4].ToString());
                    }
                    if (dr[5].ToString() != "")
                    {
                        avm = int.Parse(dr[5].ToString());
                    }
                    if (dr[6].ToString() != "")
                    {
                        attempts = int.Parse(dr[6].ToString());
                    }
                  

                    double totalacc = double.Parse(accloaded + "");
                    double touchedacc = double.Parse(touched + "");
                    double avmr = double.Parse(avm + "");
                    double attr = double.Parse(attempts + "");
  
                   
                    string tr = Math.Round((touchedacc / totalacc) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string avmrate = Math.Round((avmr / touchedacc) * 100.0, MidpointRounding.AwayFromZero) + "%";
                    string attrate = Math.Round((attr / totalacc) * 100.0, MidpointRounding.AwayFromZero) + "%";


                 
                    if (totalacc == 0)
                    {
                        tr = "0%";
                        attrate= "0%";
                    }
                    if (touchedacc == 0)
                    {
                        avmrate = "0%";

                    }
                   

                   // Debug.WriteLine(" | " + tr + " | " + cr + " | " + rpcr + " | " + ptpr + " | " + dor);
                    dgvAVM.Invoke((System.Action)delegate { dgvAVM.Rows.Add(bck_id, serviceid, servicename, accloaded, touched, avm, attempts, tr, avmrate,  attrate); });




                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.ToString());
                /*  isValid = false;*/
                //  return false;
            }
            panelGen.Invoke((System.Action)delegate { panelGen.Hide(); });

            panelReport.Invoke((System.Action)delegate { panelAVM.Enabled = true; });
            menuStrip1.Invoke((System.Action)delegate { menuStrip1.Enabled = true; });
        }



        private void btnReportCancel_Click(object sender, EventArgs e)
        {
            panelReport.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            string dateS = dtDate.Value.ToString("yyyy-MM-dd");
            if(dgvOutput.RowCount >0)
            {
                ExcelExporter exp = new ExcelExporter();
                exp.writeExcel(dateS, dgvOutput, totalagents);
            }
            else
            {
                MessageBox.Show("Cannot Export Blank Results", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

       

        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Made By Thegan Govender
         

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit the Application?", "Close Reporter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
           
           
        }

        private void genProdRepMenuItem_Click(object sender, EventArgs e)
        {
            /* if (c.ReadSetting("ADUsername")!="Error" && c.
             * 
             * ReadSetting("ADPassword") != "Error")
             {
                 panelReport.Show();
                 panelAVM.Hide();
                 pnlADL.Hide();
                 Debug.WriteLine("Show");
             }
             else
             {
                 MessageBox.Show("Please Enter Valid Credentials First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
 */

            panelReport.Show();
            panelAVM.Hide();
            pnlADL.Hide();
            Debug.WriteLine("Show");
        }

        private void aVMReportToolStripMenuItem_Click(object sender, EventArgs e)
        {


            /*if (c.ReadSetting("ADUsername") != "Error" && c.ReadSetting("ADPassword") != "Error")
            {
                panelAVM.Show();
                panelReport.Hide();
                pnlADL.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Credentials First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            try
            {
                if (!System.IO.Directory.Exists("scripts"))
                {
                    System.IO.Directory.CreateDirectory("scripts");
                }
                if (!System.IO.File.Exists("scripts/script2_default.sql"))
                {
                    StreamWriter file = new StreamWriter("scripts/script2_default.sql");
                    file.Close();
                }
                Debug.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\scripts");
                string[] filePaths = Directory.GetFiles(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\scripts", "*.sql");
                cmbScriptSelector.Items.Clear();
                foreach (var file in filePaths)
                {
                    Debug.WriteLine("File :" + Path.GetFileName(file));
                    if (Path.GetFileName(file).Contains("_report.sql"))
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Text = Path.GetFileName(file).Replace("_report.sql", "");
                        item.Value = Path.GetFileName(file);
                        cmbScriptSelector.Items.Add(item);
                        cmbScriptSelector.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex.ToString());
                /*  isValid = false;*/
                //  return false;
            }

            panelAVM.Show();

           
            panelReport.Hide();
            pnlADL.Hide();
        }

        private void btnAVMGen_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(generateAVMReport);
            thread.IsBackground = true;
            thread.Start();
            panelGen.Show();
            panelGen.BringToFront();
            menuStrip1.Enabled = false;
            panelAVM.Enabled = false;
            label3.Enabled = true;
            label3.Text = "Generating Report";

        }

        private void btnAVMCancel_Click(object sender, EventArgs e)
        {
            panelAVM.Hide();
        }

        private void btnAVMExport_Click(object sender, EventArgs e)
        {
            string dateS = dtDate.Value.ToString("yyyy-MM-dd");

          

            if (dgvAVM.RowCount > 0)
            {
                ExcelExporterAVM exp = new ExcelExporterAVM();
                exp.writeExcel(dateS, dgvAVM);
            }
            else
            {
                MessageBox.Show("Cannot Export Blank Results", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void credentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Show");
            pnlADL.Show();
            panelReport.Hide();
            panelAVM.Hide();
            ConfigFile c = new ConfigFile();
            string aduser = c.ReadSetting("ADUsername");
            string adpass = c.ReadSetting("ADPassword");
           if(aduser!= "Error" && adpass!= "Error")
            {
                txtUsername.Text = aduser;
                txtPass.Text = adpass;
            }
           

            //pnlADL.BringToFront();
        }
        public void validate()
        {
            bool valid = true;
            string username = txtUsername.Text.ToString();
            string password = txtPass.Text.ToString();
            DbConnectionStringBuilder csb = new DbConnectionStringBuilder();
            SqlConnection connection = new SqlConnection();
            //Debug.WriteLine("Userpass: "+username+password);
            string connstring = $"Data Source=database;user id=" + username + ";password=" + password + ";Initial Catalog=DB1;";
            csb.ConnectionString = connstring;
            connection.ConnectionString = csb.ConnectionString;
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                valid = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                //  Debug.WriteLine(ex.Message.ToString());
            }
            if (valid)
            {
                pnlADL.Hide();
                ConfigFile c = new ConfigFile();
               
                c.AddUpdateAppSettings("ADUsername", username);
                c.AddUpdateAppSettings("ADPassword", password);
                connection.Close();
            }
            panelGen.Invoke((System.Action)delegate { panelGen.Hide(); menuStrip1.Enabled = true; });

            pnlADL.Invoke((System.Action)delegate { pnlADL.Enabled = true; });
            menuStrip1.Invoke((System.Action)delegate { menuStrip1.Enabled = true; });
        }

        private void btnValAndSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            if (username.Equals(""))
            {
                MessageBox.Show("Username cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thread thread = new Thread(validate);
                thread.IsBackground = true;
                thread.Start();
                panelGen.Show();
                panelGen.BringToFront();
                menuStrip1.Enabled = false;
                pnlADL.Enabled = false;
                label3.Enabled = true;
                label3.Text = "Validating";
            }
          
        }

        private void btnADLCancel_Click(object sender, EventArgs e)
        {
            pnlADL.Hide();
        }
    }
}
