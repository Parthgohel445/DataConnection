namespace DataConnection
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsnm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtscou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsmob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsadr = new System.Windows.Forms.TextBox();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataConnectionDataSet = new DataConnection.DataConnectionDataSet();
            this.student_DetailsTableAdapter = new DataConnection.DataConnectionDataSetTableAdapters.Student_DetailsTableAdapter();
            this.FirstData = new System.Windows.Forms.Button();
            this.NextData = new System.Windows.Forms.Button();
            this.LastData = new System.Windows.Forms.Button();
            this.PervData = new System.Windows.Forms.Button();
            this.insertData = new System.Windows.Forms.Button();
            this.UpdateData = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.ClearData = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsrh = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dataConnectionDataSet1 = new DataConnection.DataConnectionDataSet1();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter1 = new DataConnection.DataConnectionDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Enter Student Information";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1048, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Age";
            // 
            // txtsage
            // 
            this.txtsage.Location = new System.Drawing.Point(167, 97);
            this.txtsage.Name = "txtsage";
            this.txtsage.Size = new System.Drawing.Size(305, 31);
            this.txtsage.TabIndex = 1;
            this.txtsage.TextChanged += new System.EventHandler(this.txtsage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name";
            // 
            // txtsnm
            // 
            this.txtsnm.Location = new System.Drawing.Point(167, 54);
            this.txtsnm.Name = "txtsnm";
            this.txtsnm.Size = new System.Drawing.Size(305, 31);
            this.txtsnm.TabIndex = 0;
            this.txtsnm.TextChanged += new System.EventHandler(this.txtsnm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Student Course";
            // 
            // txtscou
            // 
            this.txtscou.Location = new System.Drawing.Point(167, 143);
            this.txtscou.Name = "txtscou";
            this.txtscou.Size = new System.Drawing.Size(305, 31);
            this.txtscou.TabIndex = 2;
            this.txtscou.TextChanged += new System.EventHandler(this.txtscou_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mobile No.";
            // 
            // txtsmob
            // 
            this.txtsmob.Location = new System.Drawing.Point(170, 183);
            this.txtsmob.Name = "txtsmob";
            this.txtsmob.Size = new System.Drawing.Size(302, 31);
            this.txtsmob.TabIndex = 3;
            this.txtsmob.TextChanged += new System.EventHandler(this.txtsmob_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student Address";
            // 
            // txtsadr
            // 
            this.txtsadr.Location = new System.Drawing.Point(170, 224);
            this.txtsadr.Name = "txtsadr";
            this.txtsadr.Size = new System.Drawing.Size(302, 31);
            this.txtsadr.TabIndex = 4;
            this.txtsadr.TextChanged += new System.EventHandler(this.txtsadr_TextChanged);
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.dataConnectionDataSet;
            // 
            // dataConnectionDataSet
            // 
            this.dataConnectionDataSet.DataSetName = "DataConnectionDataSet";
            this.dataConnectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FirstData
            // 
            this.FirstData.BackColor = System.Drawing.SystemColors.Highlight;
            this.FirstData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstData.Location = new System.Drawing.Point(12, 262);
            this.FirstData.Name = "FirstData";
            this.FirstData.Size = new System.Drawing.Size(152, 33);
            this.FirstData.TabIndex = 21;
            this.FirstData.Text = "FirstData";
            this.FirstData.UseVisualStyleBackColor = false;
            this.FirstData.Click += new System.EventHandler(this.FirstData_Click);
            // 
            // NextData
            // 
            this.NextData.BackColor = System.Drawing.SystemColors.Highlight;
            this.NextData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextData.Location = new System.Drawing.Point(170, 261);
            this.NextData.Name = "NextData";
            this.NextData.Size = new System.Drawing.Size(127, 33);
            this.NextData.TabIndex = 22;
            this.NextData.Text = "NextData";
            this.NextData.UseVisualStyleBackColor = false;
            this.NextData.Click += new System.EventHandler(this.NextData_Click);
            // 
            // LastData
            // 
            this.LastData.BackColor = System.Drawing.SystemColors.Highlight;
            this.LastData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastData.Location = new System.Drawing.Point(441, 261);
            this.LastData.Name = "LastData";
            this.LastData.Size = new System.Drawing.Size(129, 33);
            this.LastData.TabIndex = 24;
            this.LastData.Text = "LastData";
            this.LastData.UseVisualStyleBackColor = false;
            this.LastData.Click += new System.EventHandler(this.LastData_Click);
            // 
            // PervData
            // 
            this.PervData.BackColor = System.Drawing.SystemColors.Highlight;
            this.PervData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PervData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PervData.Location = new System.Drawing.Point(303, 261);
            this.PervData.Name = "PervData";
            this.PervData.Size = new System.Drawing.Size(132, 33);
            this.PervData.TabIndex = 25;
            this.PervData.Text = "PrevData";
            this.PervData.UseVisualStyleBackColor = false;
            this.PervData.Click += new System.EventHandler(this.PervData_Click);
            // 
            // insertData
            // 
            this.insertData.BackColor = System.Drawing.Color.Crimson;
            this.insertData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertData.ForeColor = System.Drawing.Color.Black;
            this.insertData.Location = new System.Drawing.Point(13, 261);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(110, 35);
            this.insertData.TabIndex = 27;
            this.insertData.Text = "Insert";
            this.insertData.UseVisualStyleBackColor = false;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // UpdateData
            // 
            this.UpdateData.BackColor = System.Drawing.Color.Gray;
            this.UpdateData.Enabled = false;
            this.UpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateData.ForeColor = System.Drawing.Color.Black;
            this.UpdateData.Location = new System.Drawing.Point(129, 261);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(110, 35);
            this.UpdateData.TabIndex = 28;
            this.UpdateData.Text = "Update";
            this.UpdateData.UseVisualStyleBackColor = false;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.BackColor = System.Drawing.Color.Gray;
            this.DeleteData.Enabled = false;
            this.DeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteData.ForeColor = System.Drawing.Color.Black;
            this.DeleteData.Location = new System.Drawing.Point(246, 261);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(110, 35);
            this.DeleteData.TabIndex = 29;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseVisualStyleBackColor = false;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.Color.Crimson;
            this.ClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearData.Location = new System.Drawing.Point(362, 261);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(110, 35);
            this.ClearData.TabIndex = 30;
            this.ClearData.Text = "Clear";
            this.ClearData.UseVisualStyleBackColor = false;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(12, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(560, 31);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Student Information";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(10, 9);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(1032, 31);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "Search Data";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Enter   Student   Mobile   No.   For   Search                            ";
            // 
            // txtsrh
            // 
            this.txtsrh.Location = new System.Drawing.Point(498, 50);
            this.txtsrh.Name = "txtsrh";
            this.txtsrh.Size = new System.Drawing.Size(409, 31);
            this.txtsrh.TabIndex = 35;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Crimson;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSearch.Location = new System.Drawing.Point(913, 48);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(174, 33);
            this.BtnSearch.TabIndex = 37;
            this.BtnSearch.Text = "SearchData";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataConnectionDataSet1
            // 
            this.dataConnectionDataSet1.DataSetName = "DataConnectionDataSet1";
            this.dataConnectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.dataConnectionDataSet1;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(10, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtsmob);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtsnm);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtsage);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ClearData);
            this.splitContainer1.Panel1.Controls.Add(this.txtscou);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteData);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.UpdateData);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.insertData);
            this.splitContainer1.Panel1.Controls.Add(this.txtsadr);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.FirstData);
            this.splitContainer1.Panel2.Controls.Add(this.NextData);
            this.splitContainer1.Panel2.Controls.Add(this.LastData);
            this.splitContainer1.Panel2.Controls.Add(this.PervData);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 308);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAgeDataGridViewTextBoxColumn,
            this.sCourseDataGridViewTextBoxColumn,
            this.sMobileDataGridViewTextBoxColumn,
            this.sAddressDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.studentDetailsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(558, 197);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // sAgeDataGridViewTextBoxColumn
            // 
            this.sAgeDataGridViewTextBoxColumn.DataPropertyName = "S_Age";
            this.sAgeDataGridViewTextBoxColumn.HeaderText = "S_Age";
            this.sAgeDataGridViewTextBoxColumn.Name = "sAgeDataGridViewTextBoxColumn";
            this.sAgeDataGridViewTextBoxColumn.Width = 80;
            // 
            // sCourseDataGridViewTextBoxColumn
            // 
            this.sCourseDataGridViewTextBoxColumn.DataPropertyName = "S_Course";
            this.sCourseDataGridViewTextBoxColumn.HeaderText = "S_Course";
            this.sCourseDataGridViewTextBoxColumn.Name = "sCourseDataGridViewTextBoxColumn";
            // 
            // sMobileDataGridViewTextBoxColumn
            // 
            this.sMobileDataGridViewTextBoxColumn.DataPropertyName = "S_Mobile";
            this.sMobileDataGridViewTextBoxColumn.HeaderText = "S_Mobile";
            this.sMobileDataGridViewTextBoxColumn.Name = "sMobileDataGridViewTextBoxColumn";
            this.sMobileDataGridViewTextBoxColumn.Width = 120;
            // 
            // sAddressDataGridViewTextBoxColumn
            // 
            this.sAddressDataGridViewTextBoxColumn.DataPropertyName = "S_Address";
            this.sAddressDataGridViewTextBoxColumn.HeaderText = "S_Address";
            this.sAddressDataGridViewTextBoxColumn.Name = "sAddressDataGridViewTextBoxColumn";
            this.sAddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(DataConnection.Form2);
            // 
            // form2BindingSource1
            // 
            this.form2BindingSource1.DataSource = typeof(DataConnection.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1099, 413);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsrh);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConnectionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsnm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtscou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsmob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsadr;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.BindingSource form2BindingSource1;
        private DataConnectionDataSet dataConnectionDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private DataConnectionDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.Button FirstData;
        private System.Windows.Forms.Button NextData;
        private System.Windows.Forms.Button LastData;
        private System.Windows.Forms.Button PervData;
        private System.Windows.Forms.Button insertData;
        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsrh;
        private System.Windows.Forms.Button BtnSearch;
        private DataConnectionDataSet1 dataConnectionDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private DataConnectionDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddressDataGridViewTextBoxColumn;
    }
}