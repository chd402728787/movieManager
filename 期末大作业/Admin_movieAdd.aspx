<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="Admin_movieAdd.aspx.cs" Inherits="期末大作业.Admin_movieAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        div{
            align-content:center;
            font-family:幼圆;
        }
        #Button1,#Button2{
            width:50px;
            font-family:幼圆;
            background-color:#3399FF;
            color:white;
            border-color:#3399FF;
        }
    </style>
    <div>
        <asp:Label ID="Label1" runat="server" Text="movieID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="movieName:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="director:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="type:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="time:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="content:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="point:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="imgUrl:"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="添加" BorderStyle="None" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="返回" BorderStyle="None" OnClick="Button2_Click" />
    </div>
</asp:Content>
