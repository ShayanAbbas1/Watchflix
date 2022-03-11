<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="watchflix.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="body">
    <div class="form1" runat="server" style="display:block;margin-left:auto;margin-right:auto;  margin: auto; border: 3px solid darkgrey; padding: 10px;" >
        <div style="margin-top:50px">
             <h1> Sign Up </h1>
            <br />
            <br />
           UserName:<asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
          <br />
          <br />
             Password:<asp:TextBox ID="TextBoxPassword" TextMode="password" runat="server"></asp:TextBox>
        <br />
          <br />
             First Name: <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        &nbsp;
        Last Name :<asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
         <br />
          <br />
        email:<asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
          <br />
          <br />
        Account-Type:<asp:TextBox ID="TextBoxAccounttype" runat="server"></asp:TextBox>
        <br />
          <br />
           Payment:<asp:TextBox ID="TextBoxMoney" runat="server"></asp:TextBox>
        <br />
          <br />
       
            <asp:Button ID="btnSignUp" runat="server" OnClick="BtnLogin_SignUp" Text="SignUp" />
             </div>
        <div ID="message" runat="server"></div>
  
    </div>
        </div>
   
<style>
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
    </asp:Content>