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
    public partial class kudvenkat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;

            //Try, Catch, Finally Block

            /*SqlConnection con = new SqlConnection()*/;
            //SqlConnection con = new SqlConnection(cs);
            //try
            //{
            //con.ConnectionString = cs;
            //SqlCommand cmd = new SqlCommand("Select * from empDetails", con);
            //con.Open();
            //GridView1.DataSource = cmd.ExecuteReader();
            //GridView1.DataBind();
            //}
            //catch
            //{
            //}
            //finally { 
            //    con.Close();
            //}

            //'USING' Statement

            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand("Select * from empDetails", con);
            //    con.Open();
            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            //}

            //Implementing Execute Scalar

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select count(Name) from empDetails",con);
                con.Open();
                int TotalRows = (int)cmd.ExecuteScalar(); //Select count will give value in integer so we have to take the integer
                                                          //type and ExecuteScalar return Object Type so we must typecast it.
                Response.Write( TotalRows);

            }

        }
    }
}