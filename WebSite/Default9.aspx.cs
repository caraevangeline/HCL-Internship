using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default9 : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Cara\Documents\cara1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default6.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        c.Open();
        da = new SqlDataAdapter("select name,age,address,accno,branchname from bank", c);
        dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        c.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        c.Open();
        da = new SqlDataAdapter("select * from home", c);
        dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        c.Close();

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        c.Open();
        da = new SqlDataAdapter("select * from car", c);
        dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        c.Close();
    }
}