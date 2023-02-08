<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="chooseMovie.aspx.cs" Inherits="期末大作业.chooseMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #btnQuery,#btnShowAll{
            width:100px;
            font-family:幼圆;
            background-color:#3399FF;
            color:white;
            border-color:#3399FF;
        }
    </style>
    <asp:Label ID="Label1" runat="server" Text="关键字类型：" Font-Names="幼圆"></asp:Label>
    <asp:DropDownList ID="ddlkey" runat="server" Font-Names="幼圆">
        <asp:ListItem>movieName</asp:ListItem>
        <asp:ListItem>director</asp:ListItem>
        <asp:ListItem>type</asp:ListItem>
        <asp:ListItem>time</asp:ListItem>
        <asp:ListItem>content</asp:ListItem>
        <asp:ListItem>point</asp:ListItem>
        <asp:ListItem>imgUrl</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="关键字：" Font-Names="幼圆"></asp:Label>
    <asp:TextBox ID="txtKey" runat="server" Font-Names="幼圆"></asp:TextBox>
&nbsp;<asp:Button ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click"/>
&nbsp;<asp:Button ID="btnShowAll" runat="server" Text="显示全部" OnClick="btnShowAll_Click" />
    <br />
    <asp:Table ID="Table1" runat="server"></asp:Table>
</asp:Content>
