using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cs = "Data Source=.; Initial Catalog=project-form; Integrated Security=True";
                string query = "SELECT [projecth3], [projectp], 'assets/' + [projectimage] AS [projectimage], [projecta] FROM [project-info]";

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    repProject.DataSource = dt;
                    repProject.DataBind();
                }
            }
        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=contact-from;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [contact-info]" + "(name,email,project,message) values (@name,@email,@project,@message)", con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@project", TextBox3.Text);
            cmd.Parameters.AddWithValue("@message", TextArea1.Value);
            cmd.ExecuteNonQuery();
            con.Close();

            lblMessage.Text = "Message received successfully!";
            lblMessage.Visible = true;

        }


        protected void AdminButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }


    }
}