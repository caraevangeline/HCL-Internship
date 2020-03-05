<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        #first
    {
       
        height:300px;
        width:1325px;
    }
    .w
    {
        height:434px;
        width:389px;
        float:left;
    }
    .e
    {
        height:437px;
        width:848px;
        float:right;
    }
    
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="first"
    style="background-image:url('bank1.jpg');height:656px;">
    
    <img src="img/The_Co-operative_Bank_logo.jpg" alt="bank1.jpg" 
            style="height: 148px; width: 1331px" />
        <div class ="w">
        
            <br />
        
            <asp:Label ID="Label1" runat="server" Text="User"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Pwd"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" />
        
            <br />
            <br />
            To view your details&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Click&gt;&gt;" 
                onclick="Button2_Click" />
        
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        
        </div>
        &nbsp;
       <div class="e">
     
         <asp:Image ID="Image1" runat="server" Height="435px" ImageUrl="~/img/bank1.jpg" 
             Width="829px" />
               
    </div>
    </form>
</body>
</html>
