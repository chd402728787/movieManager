<%@ Page Title="" Language="C#" MasterPageFile="~/zhujiemian.Master" AutoEventWireup="true" CodeBehind="Admin_change.aspx.cs" Inherits="期末大作业.Admin_change" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #lbAddMovie{
            font-family:幼圆;
            text-decoration:none;
            color:#3399FF;
        }
        #btnQuery,#btnShowAll{
            width:100px;
            font-family:幼圆;
            background-color:#3399FF;
            color:white;
            border-color:#3399FF;
        }
    </style>
    <asp:LinkButton ID="lbAddMovie" runat="server" OnClick="lbAddMovie_Click" >添加电影</asp:LinkButton>
    <br />

    &nbsp;<br />
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
&nbsp;<asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="movieID" DataSourceID="MovieDataSource1" Font-Names="幼圆" PageSize="5">
        <Columns>
            <asp:BoundField DataField="movieID" HeaderText="movieID" ReadOnly="True" SortExpression="movieID" />
            <asp:BoundField DataField="movieName" HeaderText="movieName" SortExpression="movieName" />
            <asp:BoundField DataField="director" HeaderText="director" SortExpression="director" />
            <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
            <asp:BoundField DataField="content" HeaderText="content" SortExpression="content" />
            <asp:BoundField DataField="point" HeaderText="point" SortExpression="point" />
            <asp:BoundField DataField="imgUrl" HeaderText="imgUrl" SortExpression="imgUrl" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="MovieDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [movie] WHERE [movieID] = @movieID" InsertCommand="INSERT INTO [movie] ([movieID], [movieName], [director], [type], [time], [content], [point], [imgUrl]) VALUES (@movieID, @movieName, @director, @type, @time, @content, @point, @imgUrl)" SelectCommand="SELECT * FROM [movie]" UpdateCommand="UPDATE [movie] SET [movieName] = @movieName, [director] = @director, [type] = @type, [time] = @time, [content] = @content, [point] = @point, [imgUrl] = @imgUrl WHERE [movieID] = @movieID">
        <DeleteParameters>
            <asp:Parameter Name="movieID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="movieID" Type="Int32" />
            <asp:Parameter Name="movieName" Type="String" />
            <asp:Parameter Name="director" Type="String" />
            <asp:Parameter Name="type" Type="String" />
            <asp:Parameter Name="time" Type="String" />
            <asp:Parameter Name="content" Type="String" />
            <asp:Parameter Name="point" Type="String" />
            <asp:Parameter Name="imgUrl" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="movieName" Type="String" />
            <asp:Parameter Name="director" Type="String" />
            <asp:Parameter Name="type" Type="String" />
            <asp:Parameter Name="time" Type="String" />
            <asp:Parameter Name="content" Type="String" />
            <asp:Parameter Name="point" Type="String" />
            <asp:Parameter Name="imgUrl" Type="String" />
            <asp:Parameter Name="movieID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
</asp:Content>
