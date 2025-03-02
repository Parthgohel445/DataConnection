using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConnection
{
    public partial class Form2: Form
    {
        int RowPosition = 0, TotalRow = 0;
            
            
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void txtsnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtscou_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsadr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Do You Want To Exit ? ", "Student Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            Clear();
        }
        
        private void insertData_Click(object sender, EventArgs e)
        {
            if (txtsnm.Text != "" && txtsage.Text != "" && txtscou.Text != "" && txtsmob.Text != "" && txtsadr.Text != "")
            {
                String InsertQuery = txtsnm.Text + "','" + txtsage.Text + "','" + txtscou.Text + "','" + txtsmob.Text + "','" + txtsadr.Text;
                Class1.CRUD("Insert", "Student_Details", InsertQuery,"");
                Clear();
                LoadData();
                BtnStateDisable();
            }
            else
            {
                MessageBox.Show("Fill All the Feilds !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (txtsnm.Text != "" && txtsage.Text != "" && txtscou.Text != "" && txtsmob.Text != "" && txtsadr.Text != "")
            {
                String Perameter = "S_Name='" + txtsnm.Text + "',S_Age='" + txtsage.Text + "',S_Course='" + txtscou.Text + "',S_Mobile='" + txtsmob.Text + "',S_Address='" + txtsadr.Text + "'";
                String Perameter2 = Class1.CRUD("Select", "Student_Details", "","").Rows[RowPosition][0].ToString();
                Class1.CRUD("Update", "Student_Details", Perameter, Perameter2);
                LoadData();
                Clear();
                BtnStateDisable();
            }
            else
            {
                MessageBox.Show("Fill All the Feilds !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }  
        }

        
        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (txtsnm.Text != "" && txtsage.Text != "" && txtscou.Text != "" && txtsmob.Text != "" && txtsadr.Text != "")
            {
                String Perameter = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][0].ToString();
                Class1.CRUD("Delete", "Student_Details", Perameter,"");
                LoadData();
                Clear();
                BtnStateDisable();
            }
            else
            {
                MessageBox.Show("Fill All the Feilds !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            Clear();
            BtnStateDisable();
        }

        private void FirstData_Click(object sender, EventArgs e)
        {
            if (TotalRow >= 0)
            {
                RowPosition = 0;
                Navigate();
                BtnStateEnable();
            }
            else
            {
                MessageBox.Show("No Feild Selected Or This Is Last Feild !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NextData_Click(object sender, EventArgs e)
        {
            if(RowPosition < TotalRow)
            {
                RowPosition++;
                Navigate();
                BtnStateEnable();
            }
            else
            { 
                MessageBox.Show("No Feild Selected Or This Is Last Feild !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PervData_Click(object sender, EventArgs e)
        {
            if (RowPosition > 0)
            {
                RowPosition--;
                Navigate();
                BtnStateEnable();
            }
            else
            {
                MessageBox.Show("No Feild Selected Or This Is Last Feild !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void LastData_Click(object sender, EventArgs e)
        {
            if (TotalRow >= 0)
            {
                RowPosition = TotalRow;
                Navigate();
                BtnStateEnable();
            }
            else
            {
                MessageBox.Show("No Feild Selected Or This Is Last Feild !", "Student Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadData()
        {
            dataGridView1.DataSource = Class1.CRUD("Select", "Student_Details", "", "");
            TotalRow = Class1.CRUD("Select", "Student_Details", "", "").Rows.Count - 1;
        }

        private void Navigate()
        {
            if (TotalRow >= 0)
            {
                txtsnm.Text = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][1].ToString();
                txtsage.Text = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][2].ToString();
                txtscou.Text = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][3].ToString();
                txtsmob.Text = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][4].ToString();
                txtsadr.Text = Class1.CRUD("Select", "Student_Details", "", "").Rows[RowPosition][5].ToString();
            }
        }
    
        private void BtnStateEnable()
        {
            UpdateData.Enabled = true;
            UpdateData.BackColor = Color.Crimson;
            DeleteData.Enabled = true;
            DeleteData.BackColor = Color.Crimson;
            insertData.Enabled = false;
            insertData.BackColor = Color.Gray;
        }

        private void BtnStateDisable()
        {
            UpdateData.Enabled = false;
            UpdateData.BackColor = Color.Gray;
            DeleteData.Enabled = false;
            DeleteData.BackColor = Color.Gray;
            insertData.Enabled = true;
            insertData.BackColor = Color.Crimson;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear()
        {
            txtsnm.Text = txtsage.Text = txtscou.Text = txtsmob.Text = txtsadr.Text = "";
            txtsnm.Focus();
        }
    }
}

