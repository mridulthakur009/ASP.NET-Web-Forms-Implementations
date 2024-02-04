using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Implementations
{
    public partial class Insert_multiple_value_using_TVP : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("RegistrationNumber", typeof(Int32));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("FatherName", typeof(string));

            dt.Rows.Add(name1.Text, reg1.Text, dep1.Text, Fname1.Text);

            string cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("insertValue",con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParam = cmd.Parameters.AddWithValue("@TempTable", dt);
            sqlParam.SqlDbType = SqlDbType.Structured;
            cmd.ExecuteNonQuery();
            con.Close();


        }
        //static DataTable CreateTable()
        //{
            
           
        //}
    }
}