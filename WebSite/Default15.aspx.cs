using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default15 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlCommand cm;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            c.Open();
            cm = new SqlCommand("insert into car values ('" + DropDownList1.SelectedItem + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Calendar1.SelectedDate + "','" + DropDownList2.SelectedItem + "','" + DropDownList3.SelectedItem + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList4.SelectedItem + "')", c);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('We will contact you further process')</script>");
            c.Close();
        }
        else
            Response.Write("<script>alert('To continue further agree with the terms & conditions')</script>");
    }
}