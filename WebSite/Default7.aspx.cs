using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default7 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cm;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c.Open();
        cm = new SqlCommand("insert into bank values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + 0 + "','" + 0 + "','" + DropDownList1.SelectedItem + "')", c);
        cm.ExecuteNonQuery();
        Response.Write("Registration successfull");
        c.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default8.aspx");
    }
}