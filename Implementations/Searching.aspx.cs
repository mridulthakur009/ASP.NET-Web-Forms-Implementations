using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Implementations
{
    public partial class SQLInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Name,Email,Address FROM empDetails where empNo LIKE'" + TextBox1.Text + "%'OR Name LIKE'"+ TextBox1.Text +"%'OR Email LIKE'"+ TextBox1.Text + "%'";
                GridView1.DataSource = cmd.ExecuteReader(); 
                GridView1.DataBind(); //OR Name or Email
            }
        }
    }
}