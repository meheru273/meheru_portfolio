using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3
{
    public partial class updatetable : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con= new SqlConnection(strcon);
                
                
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO project-form (projectimage = @projectimage, projecth3 = @projecth3, projectp = @projectp, projecta = @projecta WHERE projecth3 = @projecth3", con);
                    cmd.Parameters.AddWithValue("@projectimage", txtImage.Text);
                    cmd.Parameters.AddWithValue("@projecth3", txtHeader.Text);
                    cmd.Parameters.AddWithValue("@projectp", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@projecta", txtLink.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("~/showtable.aspx");
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception')</script>");
            }
        }
    }
}
