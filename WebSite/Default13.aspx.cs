using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default13 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    SqlConnection cc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c.Open();
        cm=new SqlCommand("select * from bank  where accno='"+TextBox1.Text+"' and pwd='"+TextBox2.Text+"'",c);
        dr = cm.ExecuteReader();
        if (dr.Read())
        {
            cc.Open();
            cmd = new SqlCommand("update bank set amount=amount +'" + TextBox3.Text + "' where accno='" + TextBox4.Text + "'", cc);
            cmd1 = new SqlCommand("update bank set amount=amount -'" + TextBox3.Text + "' where accno='" + TextBox1.Text + "'", cc);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            Response.Write("<script>alert('Transfered successfully')</script>");
            cc.Close();
        }
                 else
            Response.Write("<script>alert('Check the Credentials')</script>");
        

   

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default16.aspx");
    }
}