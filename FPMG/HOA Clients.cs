using ExcelDataReader;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FPMG
{
    public partial class HOA_Clients : Form
    {
        public HOA_Clients()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        public System.Data.DataTable hoa_clients = new System.Data.DataTable();
        public System.Data.DataTable inactive_clients = new System.Data.DataTable();
        public System.Data.DataTable new_hoa_clients = new System.Data.DataTable();
        public DataSet set = new DataSet();

        private void Button3_Click(object sender, EventArgs e)
        {
            //Compile data from original excel file.
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (System.Data.DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoa_clients = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = hoa_clients;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            string constring = setting.GetConnectionString("cn");
            //ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["cn"];
            //string constring = conSettings.ConnectionString;
            try
            {
                int inserted = 0;
                //string constring = @"server=localhost;database=fpmg;uid=root;pwd=1234;";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Column1"].Value);
                    if (isSelected)
                    {
                        using (MySqlConnection cnn = new MySqlConnection(constring))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO importhoa VALUES(@association_name, @board_member_name, @mailing_address, @phone_number, @contacted)", cnn))
                            {
                                cmd.Parameters.AddWithValue("@association_name", row.Cells["Association Name"].Value);
                                cmd.Parameters.AddWithValue("@board_member_name", row.Cells["Board Member Name"].Value);
                                cmd.Parameters.AddWithValue("@mailing_address", row.Cells["PA Mailing Address"].Value);
                                cmd.Parameters.AddWithValue("@phone_number", row.Cells["Board Member Phone"].Value);
                                cmd.Parameters.AddWithValue("@contacted", row.Cells["Column1"].Value);
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                        }
                        inserted++;
                    }
                }

                if (inserted > 0)
                {
                    MessageBox.Show(string.Format("{0} records inserted.", inserted), "Message");
                }

                string query = "TRUNCATE importhoa";

                using (MySqlConnection sqlCon = new MySqlConnection(constring))
                {
                    sqlCon.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM importhoa", sqlCon);
                    System.Data.DataTable dtb1 = new System.Data.DataTable();
                    sqlDa.Fill(dtb1);
                    dataGridView2.DataSource = dtb1;
                    MySqlCommand c = new MySqlCommand(query, sqlCon);
                    c.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove("Column1");
            // Compile excel file of inactive members and store it into a data-table (dt1).
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            foreach (System.Data.DataTable table in tableCollection)
                            {
                                inactive_clients = tableCollection[table.ToString()];
                            }
                        }
                    }
                }
            }
            dataGridView1.DataSource = inactive_clients;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove("Column1");
            //Remove the inactive members from original data.
            List<DataRow> inactiveClients = new List<DataRow>();
            foreach (DataRow dr in hoa_clients.Rows)
            {
                foreach (DataRow d in inactive_clients.Rows)
                {
                    if (dr["Board Member Name"].ToString() == d["Column2"].ToString())
                    {
                        inactiveClients.Add(dr);
                    }
                }
            }

            foreach (var r in inactiveClients)
            {
                hoa_clients.Rows.Remove(r);
            }
            dataGridView1.DataSource = hoa_clients;

            //Creating final excel file to a user defined location.
            hoa_clients.Columns.Add("City-State-Zip", typeof(string), "Column12+','+Column13+','+Column14").ToString();
            new_hoa_clients = hoa_clients.DefaultView.ToTable(false, "Board Member Name", "PA Mailing Address", "City-State-Zip");

            ExcelUtility obj = new ExcelUtility();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Save Excel Files",

                DefaultExt = "xlsx",
                Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog1.FileName;

            }
            else
            {
                return;
            }

            if(!File.Exists(textBox2.Text))
            {
                obj.WriteDataTableToExcel(new_hoa_clients, textBox4.Text, textBox2.Text);
                MessageBox.Show("Successfully Create Excel File!");
            }
            else
            {
                obj.CreateNewSSTOExcel(new_hoa_clients, textBox4.Text, textBox2.Text);
                MessageBox.Show("Data has been added in a new sheet of this file!");
            }
        }
    }
}
