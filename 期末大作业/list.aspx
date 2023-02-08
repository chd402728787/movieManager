<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="期末大作业.list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton class="lb" ID="lbPoint" runat="server" OnClick="lbPoint_Click">评分排序</asp:LinkButton>
    &nbsp;
    <asp:LinkButton class="lb" ID="lbFirst" runat="server" OnClick="lbFirst_Click">首字母排序</asp:LinkButton>
    &nbsp;
    <asp:LinkButton class="lb" ID="lbID" runat="server" OnClick="lbID_Click">默认排序</asp:LinkButton>
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
</asp:Content>
