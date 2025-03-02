using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DataConnection
{
    class Class1
    {

        public static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataConnection.mdf;Integrated Security=True");

        public static DataTable CRUD(String qtype, String tblnm, String Parameter, String Parameter2)
        {
            DataTable DT = new DataTable();
            SqlDataAdapter DA;
            if (qtype == "Insert")
            {
                String InsertQuery = "Insert Into " + tblnm + " values('" + Parameter + "')";
                DA = new SqlDataAdapter(InsertQuery, con);
                DA.Fill(DT);
                return DT;
            }
            else if (qtype == "Select")
            {
                String SelectQuery = "Select * From " + tblnm;
                DA = new SqlDataAdapter(SelectQuery, con);
                DA.Fill(DT);
                return DT;
            }
            else if(qtype == "Update")
            {
                String UpdateQuery = "Update " + tblnm + " set "+Parameter+" Where id='"+Parameter2+"'";
                DA = new SqlDataAdapter(UpdateQuery, con);
                DA.Fill(DT);
                return DT;
            }
            else if (qtype == "Delete")
            {
                String DeleteQuery = "Delete " + tblnm +" Where id='" + Parameter + "'";
                DA = new SqlDataAdapter(DeleteQuery, con);
                DA.Fill(DT);
                return DT;
            }
            return DT;
        }

        public static String Login(String tblnm, String perem)
        {
            String SelectQuery = "Select * From " + tblnm + " Where " + perem + "";
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(SelectQuery, con);
            DA.Fill(DT);
            if (DT.Rows.Count == 1)
            {
                String active = DT.Rows[0][3].ToString();
                if (active == "Y")
                {
                    return "1";

                }
                else
                {
                    return "2";
                }
            }
            else
            {
                return "3";
            }

            
        }  
    }
}
