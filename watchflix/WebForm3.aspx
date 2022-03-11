<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="watchflix.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>" SelectCommand="SELECT * FROM [movie] WHERE release_date>getdate() ORDER BY [release_date] DESC">
                </asp:SqlDataSource>
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
                              
                           </table>
                       </ItemTemplate>
                       <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                       <SeparatorStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
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
    </style>
    </div>
    </asp:Content>

