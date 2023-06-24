using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Parth\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            show();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "insert into first values('" + textbox4.Text + "','" + textbox1.Text + "','" + textbox2.Text + "','" + textbox3.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response.Write("Inserted Data");
            show();
            clear();
        }
        public void show()
        {
            string sql = "select * from first";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
           
        }
        public void clear()
        {
            textbox4.Text = "";
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update first set First_Name ='" + textbox1.Text + "', Last_Name ='" + textbox2.Text + "', Mobile_No ='" + textbox3.Text + "' where Id='" + textbox4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            show();
            clear();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from first where Id='" + textbox4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            show();
            clear();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}