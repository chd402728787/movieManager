<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="期末大作业.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server"><center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="影视天堂，欢迎观赏" Font-Names="幼圆" Font-Size="36pt" ForeColor="#3399FF"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label runat="server" Text="点击下方按钮选择电影" Font-Names="幼圆"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#3399FF" BorderStyle="Double" BorderWidth="5px" Font-Names="幼圆" ForeColor="White" OnClick="Button1_Click" Text="快按我！！！" style="padding:15px;"/>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </center>
    </asp:Panel>
</asp:Content>
