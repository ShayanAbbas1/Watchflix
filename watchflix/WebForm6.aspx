<%@ Page Title="AddMovie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="watchflix.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="form1" runat="server" style="display:block;margin-left:auto;margin-right:auto;  margin: auto; border: 3px solid darkgrey; padding: 10px;" >
         <div style="margin-top:50px">
             <h1> Add a Movie </h1>
             <br />
            <br />
              actor 1 : <asp:textbox ID="actor1" runat="server"></asp:textbox>
            
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
              actor 2 : <asp:textbox ID="actor2" runat="server"></asp:textbox>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              actor 3 : <asp:textbox ID="actor3" runat="server"></asp:textbox>
             <br />
            <br />
              director 1:<asp:textbox ID="director1" runat="server"></asp:textbox>
             &nbsp;&nbsp;&nbsp;
             director 2:<asp:textbox ID="director2" runat="server"></asp:textbox>
            <br />
            <br />
             writer 1:<asp:textbox ID="writer1" runat="server"></asp:textbox>
             writer 2:<asp:textbox ID="writer2" runat="server"></asp:textbox>
             <br />
            <br />
 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
            <asp:Button ID="AddCast" runat="server" OnClick="cast_button" Text="Add cast for this movie" BackColor="#009999" style="margin-left: 0" />
              <br />
             <br />
            <br />
             Genre : <asp:DropDownList ID="genrelist" runat="server"></asp:DropDownList>
             <br />
            <br />
             Name of movie : <asp:TextBox ID="textmoviename" runat="server"></asp:TextBox>
             <br />
            <br />
             Link to the movie : <asp:TextBox ID="Link_for_movie" runat="server"  Width="345px"></asp:TextBox>
             <br />
            <br />
             Release Date :<asp:TextBox ID="textdate" runat="server"></asp:TextBox>
             <br />
            &nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Add" runat="server" OnClick="AddMovie" Text="Add  movie" BackColor="#009999"/>
             <div ID="messageadd" runat="server"></div>
             </div>

         </div>
    </asp:content>
