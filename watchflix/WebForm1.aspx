<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="watchflix.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color:black"></div>
    <div class="black" >
            <div style="background-color:darkcyan;border:ridge; margin-top:70px">

                <asp:DropDownList ID="drop_sortby" runat="server"  style="flood-color:blue; background-color:cadetblue">
                    <asp:ListItem Text="default" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Release date(newest)" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Release date(oldest)" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Rating" Value="3"></asp:ListItem>
                </asp:DropDownList>
                <asp:button id="sortby" Text="sort" runat="server" onclick="Dropdown_sort_by" class="auto-style5" style="flood-color:blue; background-color:cadetblue"></asp:button>
          
                  <asp:TextBox ID="txtsearch" runat="server" style="margin-bottom:20px;"></asp:TextBox>
                 <asp:Button ID="Btn_Search" runat="server" OnClick="Btn_Search_func" BackColor="Gray" Text="Search" /> 
            
            </div>


        <div style="background-color:darkslategrey">
  <a href="WebForm3.aspx">
  <img src="images/coming-soon.png"  
  style="display: block; 
  margin-left: auto;
  margin-right: auto;
  width: 300px; height:200px; 
  border:7px solid grey"; ">
   </a>
       </div>
   
          <br />
        <br />
        <br />
        <br />
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>" SelectCommand="SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate()"></asp:SqlDataSource>
                 
                        <asp:DataList ID="MovieList" runat="server" 
                       DataSourceID="SqlDataSource1" Height="60%"  Width="100%"
                       BackColor="#666666" BorderColor="#CCCCCC" BorderStyle="None"
                       BorderWidth="1px" CellSpacing="50" ForeColor="Black" GridLines="Horizontal"
                       HorizontalAlign="left"
                        RepeatDirection="Horizontal"
                       OnSelectedIndexChanged="MovieList_SelectedIndexChanged"
                       OnItemCommand="MovieList_ItemCommand"  RepeatLayout="Flow">

                       <EditItemStyle HorizontalAlign="Center" VerticalAlign="Middle"  Width="100%" />
                       <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                       <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                       <ItemStyle Font-Names="Garamond" ForeColor="Silver" HorizontalAlign="Left" VerticalAlign="Top" Width="30%" />
                       <ItemTemplate>
<br />
                           <table class="auto-style1">
                               <tr>
                                   <td class="auto-style2" style="text-align: center; background-color: #333333;">
                                       <asp:Label ID="Label1" runat="server" BackColor="#666699" Font-Bold="True" ForeColor="Black" Text='<%# Eval("movie_name") %>' Font-Size="Larger" ViewStateMode="Enabled" BorderColor="#666666"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td class="auto-style3" style="text-align: center">
                                       <asp:Label ID="Label3" runat="server" Text='<%# Eval("release_date", "{0:d}") %>'></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td style="text-align: center" class="auto-style3">
                                       <asp:Label ID="Label2" runat="server" Text='<%# Eval("rating") %>'></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td style="text-align: center" class="auto-style3">
                                       <asp:Button ID="Button1" runat="server"  Text="View details" BackColor="#CCCCFF" ForeColor="Black" Height="32px" Width="131px"  CommandName="viewdetail" CommandArgument='<%# Eval("movie_id") %>' />
                                   </td>
                               </tr>
                           </table>
                       </ItemTemplate>
            </asp:DataList>


    <style>
        .img {
            display:inline-block;
        }
        .img div {
            position: absolute;
 bottom: 0;
 right: 0;
 background: black;
 color: white;
 margin-bottom: 5px;
 font-family: sans-serif;
 opacity: 0;
 visibility: hidden;
 -webkit-transition: visibility 0s, opacity 0.5s linear; 
 transition: visibility 0s, opacity 0.2s linear;
        }
        .img:hover{
 cursor: pointer;
}
.img:hover div{
 width: 500px;
 padding: 8px 15px;
 visibility: visible;
 background-color:cadetblue;
 opacity: 0.7; 
 position:page;
}
        .auto-style1 {
            width: 66%;
            background-color: #122B40;
            height: 164px;
            margin-left: 81px;
            margin-right: 63px;
        }
        .auto-style2 {
            height: 57px;
            width: 532px;
        }
        .auto-style3 {
            width: 532px;
        }
        .auto-style4 {
            width: 63px;
            height: 22px;
        }
        .auto-style5 {
            width: 60px;
        }
    </style>
    </div>
           
           
            </a>
</div>
</asp:Content>
