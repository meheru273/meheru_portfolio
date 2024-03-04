using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication3
{
    public partial class login : Page
    {
        string cs = "Data Source=.;Initial Catalog=project-form;Integrated Security=True";
        string query = "SELECT [type] FROM [logininfo]";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string userType = rd["type"].ToString();
                            if (userType.Equals("admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Response.Redirect("showtable.aspx");
                            }
                            else
                            {
                                Response.Redirect("WebForm1.aspx");
                            }
                        }
                    }
                    else
                    {
                        TextBox1.Text = "Incorrect email";
                        TextBox2.Text = "Incorrect password";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
