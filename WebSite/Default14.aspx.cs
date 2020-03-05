using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default14 : System.Web.UI.Page
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
            cm = new SqlCommand("insert into home values('" + DropDownList1.SelectedItem + "','" + TextBox1.Text + "','" + Calendar1.SelectedDate + "','" + DropDownList2.SelectedItem + "','" + DropDownList3.SelectedItem + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList4.SelectedItem + "','" + TextBox4.Text + "')", c);
            cm.ExecuteNonQuery();
            Response.Write("<script>alert('You will be contacted for further details')</script>");
            c.Close();
        }

        else
            Response.Write("<script>alert('To proceed further accept the terms & conditions')</script>");
    }
}