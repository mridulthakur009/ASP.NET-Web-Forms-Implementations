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
    public partial class InsertMultipleRec2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        } 
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string cs=ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            DataTable Dt = new DataTable();
            Dt.Columns.Add("StudentName");
            Dt.Columns.Add("RegistrationNumber");
            Dt.Columns.Add("Department");
            Dt.Columns.Add("FatherName");

            for (int i = 1; i <= 4; i++)
            {
                string StudentName = Request.Form["name" + i].ToString();
                string RegistrationNumber = Request.Form["reg" + i].ToString();
                string Department = Request.Form["dep" + i].ToString();
                string FatherName = Request.Form["Fname" + i].ToString();
                Dt.Rows.Add(StudentName, RegistrationNumber, Department, FatherName);
            }

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertStudentDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@DetailInsersion", Dt);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblStatus.Text = "Details Saved into Database";
            }
            catch (Exception es)
            {
                throw es;
            }
        }
    }
}