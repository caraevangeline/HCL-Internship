using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default16 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cm;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c.Open();
        cm = new SqlCommand("select amount from bank where accno='"+TextBox1.Text+"' and pwd='"+TextBox3.Text+"'",c);
        dr = cm.ExecuteReader();
        if (dr.Read())
        {
            TextBox2.Text = dr[0].ToString();
        }
        else
            Response.Write("<script>alert('Check the credentials')</script>");
        c.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}