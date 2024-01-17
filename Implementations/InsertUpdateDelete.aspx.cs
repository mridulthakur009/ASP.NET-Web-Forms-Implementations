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
    public partial class InsertUpdateDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                //SqlCommand cmd = new SqlCommand("INSERT INTO empDetails VALUES(111, 'Vishesh', 'vishesh@ditstek.com', 'Kangra')",con);

                SqlCommand cmd = new SqlCommand();
                
                cmd.CommandText = "DELETE FROM empDetails WHERE empNo = 11";
                cmd.Connection = con;
                con.Open();
                int TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Deleted: " + TotalRowsAffected.ToString()+ "</br>");

                cmd.CommandText = "Insert Into empDetails values(11, 'Vishesh', 'vishesh@ditstek.com', 'Kangra')";
                TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total rows Inserted: " + TotalRowsAffected.ToString() + "</br>");

                cmd.CommandText = "UPDATE empDetails SET email='test@ditstek.com' where empNo=11";
                TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Updated: " + TotalRowsAffected.ToString()+"</br>");
            }
        }
    }
}