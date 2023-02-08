<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="期末大作业.register" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <link href="css/registercs.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <br />
                <h2>欢迎来到影视天堂</h2>
      
                <h3>每一天，记录美。</h3>
       
                
       
                <br />
 
       <asp:ScriptManager ID="ScriptManager1" runat="server">
               </asp:ScriptManager> 
       
     
           <asp:TextBox runat="server" ID="rUserNameText"   Height="40px" Width="490px" CssClass="Tb"></asp:TextBox>
 
               <br />  
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
                  <asp:CustomValidator ID="CustomValidator1" runat="server" 
    ControlToValidate="rUserNameText" ErrorMessage="*" 
    onservervalidate="CustomValidator1_ServerValidate">
</asp:CustomValidator>
             </ContentTemplate>
           
             </asp:UpdatePanel>
                <br />
            <asp:TextBox runat="server" ID="rPsdText"  TextMode="Password" Height="40px" Width="490px" CssClass="Tb"></asp:TextBox>
            <br /> 
         <asp:UpdatePanel ID="UpdatePanel2" runat="server">
             <ContentTemplate>
 <asp:CustomValidator ID="CustomValidator2" runat="server" 
    ControlToValidate="rPsdText" ErrorMessage="*" 
    onservervalidate="CustomValidator2_ServerValidate">
</asp:CustomValidator>
             </ContentTemplate>
           
             </asp:UpdatePanel>
            <br />
           <asp:TextBox runat="server" ID="rrPsdText"  TextMode="Password" Height="40px" Width="490px" CssClass="Tb" ></asp:TextBox>
           <br />
      <asp:UpdatePanel ID="UpdatePanel3" runat="server">
             <ContentTemplate>
       <asp:CustomValidator ID="CustomValidator3" runat="server" 
    ControlToValidate="rrPsdText" ErrorMessage="*" 
    onservervalidate="CustomValidator3_ServerValidate">
</asp:CustomValidator>
             </ContentTemplate>
           
             </asp:UpdatePanel>
           
         <br />
         <table>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked="true" />
                </td>
                <td>
                     <span>同意</span>  <asp:LinkButton runat="server" Text="服务条款" ID="ckItem"></asp:LinkButton>
                </td>
                <td>
                                           
                                           
                           
                </td>
                <td>
                  
                    <asp:LinkButton ID="linkToLogin" runat="server" Text="已有账号?登录" OnClick="linkToLogin_Click"></asp:LinkButton>
                </td>
            </tr>
        </table>
        
           
      
 
       
 
        <asp:Button ID="btnRegister" runat="server" CssClass="transButton" Height="49px" Text="注    册" Width="500px" OnClick="btnRegister_Click" />
                 
    
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                 
    
    </form>
    </body>
        <script type="text/javascript">  
        function watermark(id, value) {  
            var obj = document.getElementById(id);
            var isPsdMode = false;
            if (obj.type == "password")
            {
                obj.type = "text";
                isPsdMode = true;
            }
            obj.value = value;  
            obj.style.color = "Gray";
            //获取焦点事件  
            obj.onfocus = function () {
                
                obj.style.color = "Black";
                if (isPsdMode)
                {
                    obj.type = "password";
                }
                if (this.value == value) {  
                    this.value = '';  
                }  
            };  
            //失去焦点事件  
            obj.onblur = function () {  
                if (this.value == "") {
                    if (isPsdMode) {
                        obj.type = "text";
                    }
                    this.value = value;  
                    obj.style.color = "Gray";
                }  
                else {  
                    obj.style.color = "Black";
                }  
            };  
        }  
        window.onload = function () {  
            var arr = [{ 'id': 'rUserNameText', 'desc': '用户名' }, { 'id': 'rPsdText', 'desc': '密码' },{ 'id': 'rrPsdText', 'desc': '确认密码' }];
            for (var i = 0; i < arr.length; i++) {  
                watermark(arr[i].id, arr[i].desc);  
            }  
        };  
    </script> 
</html>