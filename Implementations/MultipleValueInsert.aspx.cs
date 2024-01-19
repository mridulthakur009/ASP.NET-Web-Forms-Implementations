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
    public partial class MultipleValueInsert : System.Web.UI.Page
    {
        private SqlParameter prmReturn;

        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            //DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn("ItemNumber", typeof(string)));
            //dt.Columns.Add(new DataColumn("ItemCode", typeof(string)));
            //dt.Columns.Add(new DataColumn("Name", typeof(string)));
            //dt.Columns.Add(new DataColumn("Price", typeof(int)));

            //dt.Rows.Add("1000", "1", "Samsung", 20000);
            //dt.Rows.Add("1001", "2", "One Plus", 30000);
            //dt.Rows.Add("1002", "3", "iPhone", 50000);
            //SqlCommand cmd = new SqlCommand("usp_InsertProducts", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@tableproducts", dt);
            //con.Open();
            //cmd.ExecuteReader();

            DataTable dt = new DataTable();
            //Add columns  
            dt.Columns.Add(new DataColumn("ItemNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("ItemCode", typeof(string)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
            //Add rows  
            dt.Rows.Add("1000", "Code1", "Phone1", 20000);
            dt.Rows.Add("1001", "Code2", "Phone2", 30000);
            dt.Rows.Add("1002", "Code3", "Phone3", 50000);

            //sqlcon as SqlConnection  
            SqlCommand sqlcom = new SqlCommand("usp_InsertProducts", con);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.AddWithValue("@tableproducts", dt);
            sqlcom.Parameters.Add(prmReturn);
            con.Open();
            sqlcom.ExecuteNonQuery();
        }
    }
}