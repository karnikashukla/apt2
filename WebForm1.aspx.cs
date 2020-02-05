using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=New_Database;Integrated Security=True");
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from mytable",connection);
            
            dataAdapter.Fill(ds);
           
            GridView1.DataSource = ds;
            GridView1.DataBind();

            SqlCommand cmd = new SqlCommand("mytable", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}