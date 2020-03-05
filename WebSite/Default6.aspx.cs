using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default6 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cm;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c.Open();
        
            cm = new SqlCommand("update bank set accno='" + TextBox4.Text + "' where  name='" + TextBox1.Text + "' and address='" + TextBox3.Text + "'", c);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('Updated successfully')</script>");
            c.Close();
        
        


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}