<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="期末大作业.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #Panel1 {

        }
        .textbox {
            border: solid 1px;
            background: rgba(0, 0, 0, 0);
        }
        div {
            margin: 30px auto;
            align-content: center;
            font-family: 幼圆;
        }
        #Button1 {
            border-radius: 2px;
            border: solid 1px;
            background-color: transparent;
            margin-left: 150px;
            margin-top: 10px;
            font-family: 幼圆;
        }
    </style>
    <asp:Panel ID="Panel1" runat="server">
        <div>
            <div>
                <br />
                <span ID="spanMain" runat="server" style="font-size: 40px; color: #3399FF" >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 管理员登录</span>
                <br />
            </div>
            <div>
                <span id="spanuser">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户名:</span>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="30px" Width="240px"></asp:TextBox>
            </div>
 
            <div>
                <span id="spanpsd">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密码:</span>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="30px" Width="240px" TextMode="Password"></asp:TextBox>
            </div>
 
            <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="登 录" Width="270px" Height="40px" OnClick="Button1_Click"/>
            </div>
            <br />
        </div>
    </asp:Panel>
           
</asp:Content>
