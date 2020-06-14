namespace FPMG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.associationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardmembernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fpmgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpmgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFilename.Location = new System.Drawing.Point(138, 20);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(384, 35);
            this.txtFilename.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Location = new System.Drawing.Point(533, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(257, 83);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Condominiiums Clients";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name:";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(138, 73);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 27);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.CboSheet_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(16, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(803, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Already Contacted";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet:";
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnImport.Location = new System.Drawing.Point(906, 471);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(460, 64);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "&Import data into Database";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(533, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inactive Clients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.associationnameDataGridViewTextBoxColumn,
            this.boardmembernameDataGridViewTextBoxColumn,
            this.mailingaddressDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.contactedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.importBindingSource2;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(837, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(717, 406);
            this.dataGridView2.TabIndex = 8;
            // 
            // associationnameDataGridViewTextBoxColumn
            // 
            this.associationnameDataGridViewTextBoxColumn.DataPropertyName = "association_name";
            this.associationnameDataGridViewTextBoxColumn.HeaderText = "association_name";
            this.associationnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.associationnameDataGridViewTextBoxColumn.Name = "associationnameDataGridViewTextBoxColumn";
            this.associationnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // boardmembernameDataGridViewTextBoxColumn
            // 
            this.boardmembernameDataGridViewTextBoxColumn.DataPropertyName = "board_member_name";
            this.boardmembernameDataGridViewTextBoxColumn.HeaderText = "board_member_name";
            this.boardmembernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.boardmembernameDataGridViewTextBoxColumn.Name = "boardmembernameDataGridViewTextBoxColumn";
            this.boardmembernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mailingaddressDataGridViewTextBoxColumn
            // 
            this.mailingaddressDataGridViewTextBoxColumn.DataPropertyName = "mailing_address";
            this.mailingaddressDataGridViewTextBoxColumn.HeaderText = "mailing_address";
            this.mailingaddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mailingaddressDataGridViewTextBoxColumn.Name = "mailingaddressDataGridViewTextBoxColumn";
            this.mailingaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactedDataGridViewTextBoxColumn
            // 
            this.contactedDataGridViewTextBoxColumn.DataPropertyName = "contacted";
            this.contactedDataGridViewTextBoxColumn.HeaderText = "contacted";
            this.contactedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactedDataGridViewTextBoxColumn.Name = "contactedDataGridViewTextBoxColumn";
            this.contactedDataGridViewTextBoxColumn.Width = 150;
            // 
            // importBindingSource2
            // 
            this.importBindingSource2.DataMember = "import";
            this.importBindingSource2.DataSource = this.fpmgDataSetBindingSource;
            // 
            // importBindingSource1
            // 
            this.importBindingSource1.DataMember = "import";
            this.importBindingSource1.DataSource = this.fpmgDataSetBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(384, 35);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data from Excel File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(831, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data from Database";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(533, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 82);
            this.button2.TabIndex = 13;
            this.button2.Text = "Create New File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(154, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(368, 35);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(7, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "File Path";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilename);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSheet);
            this.panel1.Location = new System.Drawing.Point(28, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 128);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(28, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 128);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(28, 736);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 147);
            this.panel3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 26);
            this.textBox4.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(-3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 26);
            this.label8.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(7, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sheet Name:";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1570, 456);
            this.panel4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1590, 895);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImport);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.BindingSource importBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fpmgDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn associationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardmembernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailingaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource importBindingSource1;
        private System.Windows.Forms.BindingSource importBindingSource2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

