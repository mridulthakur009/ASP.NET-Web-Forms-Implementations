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
    public partial class MultipleValueInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["testDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try 
            {
                SqlCommand cmd = new SqlCommand();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}