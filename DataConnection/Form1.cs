using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DataConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Do You Want To Exit ? ","DataConnection",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtunm.Text != "" && txtpass.Text != "")
            {
                String SelectQuery = "username='" + txtunm.Text + "' and password='" + txtpass.Text + "'";
                String Login = Class1.Login("Login", SelectQuery);
                if (Login == "1")
                {
                    Form2 F2 = new Form2();
                    F2.Show();
                    this.Hide();
                }
                else if(Login == "2")
                {
                    MessageBox.Show("Your Account Is Banned Please Contect To Admin !", "Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                }
                else if(Login == "3")
                {
                    MessageBox.Show("Invalid Username Or Password !", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter Values In Both Feilds !", "DataConnection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
        }
        
        private void Clear()
        {
            txtunm.Text = txtpass.Text = "";
            txtunm.Focus();
        }
        private void txtunm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
