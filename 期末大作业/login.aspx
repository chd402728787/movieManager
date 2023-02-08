<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="期末大作业.login" %>
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/logincs.css" rel="stylesheet" />
    <title>登陆</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p style="margin-left: 120px">
                <span ID="spanMain" runat="server" style="font-size: 40px; color: #3399FF" >&nbsp;影片管理系统</span>
                </p>
            </div>
            <div>
                <span id="spanuser">用户名:</span>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="30px" Width="240px" ForeColor="#3399FF"></asp:TextBox>
            </div>
 
            <div>
                <span id="spanpsd">密码:</span>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="30px" Width="240px" TextMode="Password"></asp:TextBox>
            </div>
 
            <div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">没有账号?注册</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">管理员登陆</asp:LinkButton>
                <br />
                <asp:Button ID="Button1" runat="server" Text="登 录" Width="270px" Height="40px" OnClick="Button1_Click" />
            </div>
        </div>
           
    </form>
</body>
</html>
