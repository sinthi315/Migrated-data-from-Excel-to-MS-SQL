using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPMG
{
    public partial class Test_Connect_MySQL : Form
    {
        public Test_Connect_MySQL()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 20;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("DataSource={0};Initial Catalog={1};User ID={2};Password={3};",cboServer.Text, txtDatabase.Text,txtUsername.Text,txtPassword.Text);
            try
            {
                MySqlHelper helper = new MySqlHelper(connectionString);
                if(helper.IsConnection)
                {
                    MessageBox.Show("Test Connection Succeeded.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test_Connect_MySQL_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("localhost");
            cboServer.Items.Add(@"www.fpmgroupinc.com");
            cboServer.Items.Add(string.Format(@"{0}\MYSQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 3;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("DataSource={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                MySqlHelper helper = new MySqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", connectionString);
                    MessageBox.Show("Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
