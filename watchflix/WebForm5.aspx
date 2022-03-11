<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="watchflix.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="body">
    <div class="form1" runat="server" style="display:block;width:300px;margin-left:auto;margin-right:auto;  margin: auto; border: 3px solid darkgrey; padding: 10px;" >
        <div style="margin-top:50px">
             <h1> Login </h1>
            <br />
            <br />
            <asp:Label ID="label1" runat="server" Text="UserName"></asp:Label>
       <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
             <br /> 
            <br />
            <asp:Label ID="label2" runat="server" Text="Password"></asp:Label>
       <asp:TextBox ID="txtPassword" TextMode="password" runat="server"></asp:TextBox>
             <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" />           
               <br />
            <br />
             <div ID="message1" runat="server"></div>
        </div>
        <a href="WebForm4.aspx" style="background-color:lightblue; color:black">Don't have an account? Create one
        </a>
    </div>
</div>
<style>
    #btnSave {
  position:center;
  color:black;
  border-style: solid;
  border-width : 1px 1px 1px 1px;
  text-decoration : none;
  padding : 4px;
  border-color : #000000;
  background-color:darkgray;
    }
    #body {
        background-color:black;
        color:aliceblue;     
  display: grid;
  grid-auto-rows: 30px;
    }
    #form1 div {
        background-color:dimgray;
    }
</style>
    <script>
    </script>
    </asp:Content>