<%@ Page Title="AddMovie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="watchflix.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="form1" runat="server" style="display:block;margin-left:auto;margin-right:auto;  margin: auto; border: 3px solid darkgrey; padding: 10px;" >
         <div>
           <asp:SqlDataSource  ID="SqlDataSource1"  runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>"></asp:SqlDataSource>
                 <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>"></asp:SqlDataSource>

              <div style="margin-top:50px">
             <h1> Profile </h1>

                  <div style="background-color: #996633; color: #FFFFFF;  width: 440px; margin-right: 43px; margin-bottom: 20px; height: 518px; margin-left: 52px; margin-top: 61px;">
                      &nbsp;<asp:Image Visible="false" ID="Image1" runat="server" Height="99px" ImageUrl="~/images/red.jpg" style="margin-left: 0px; margin-top: 1px;" Width="87px" CssClass="pull-right" />
                       <h4 class="text-left" style="width: 101px; height: 61px" >&nbsp;<span style="text-decoration: underline">Firstname<asp:Label ID="label_firstname"  runat="server" Height="26px" style="margin-left: 148px; margin-bottom: 0px; margin-top: 0px;" Font-Underline="False" ForeColor="#000099" Width="140px" ></asp:Label>
                           </span></h4>
                      <h4 class="text-left" style="width: 98px; height: 52px" >&nbsp;<span style="text-decoration: underline">Lastname </span><asp:Label ID="label_lastname"   runat="server" Height="53px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" ></asp:Label>
                          </h4>
                       <h4 class="text-left" style="width: 97px; height: 49px" >&nbsp;<span style="text-decoration: underline">Username </span><asp:Label ID="label_username"   runat="server" Height="53px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" ></asp:Label>
                          </h4>
                       <h4 class="text-left" style="width: 95px; height: 55px" >&nbsp;<span style="text-decoration: underline">Password </span><asp:Label ID="label_password"   runat="server" Height="53px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" ></asp:Label>
                          </h4>
                      <h4 class="text-left" style="width: 77px; height: 54px" >&nbsp;<span style="text-decoration: underline">Email id  </span><asp:Label ID="label_email"   runat="server" Height="45px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" Width="124px" ></asp:Label>
                          </h4>
                       <h4 class="text-left" style="width: 184px; height: 47px" >&nbsp;<span style="text-decoration: underline">Account creation date </span><asp:Label ID="label_date"   runat="server" Height="50px" style="margin-left: 193px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" Width="217px" ></asp:Label>
                          </h4>
                      <h4 class="text-left" style="width: 106px; height: 42px" >&nbsp;<span style="text-decoration: underline">Account No. </span><asp:Label ID="label_accnum"   runat="server" Height="53px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" ></asp:Label>
                          </h4>
                       <h4 class="text-left" style="width: 115px; height: 50px" ><span style="text-decoration: underline">Money left </span><asp:Label ID="label_money"  runat="server" Height="26px" style="margin-left: 142px; margin-bottom: 0px" Font-Underline="False" ForeColor="#000099" Width="113px" ></asp:Label>
                          </h4>
                      <h4 class="text-left" style="width: 100px; height: 50px" >&nbsp;</h4>
                      </div>
                

                 
                  </div>
             <asp:Button ID="Button2" runat="server" Text="Watchlater_list" OnClick="show_watchlater" />
             <asp:DataList ID="DataList1" runat="server" OnItemCommand="MovieList_ItemCommand" DataSourceID="SqlDataSource2" Visible="false">
                 <ItemTemplate>
                     <table class="nav-justified" style="width: 64%; height: 89px; margin-left: 19px; margin-right: 7px; margin-bottom: 1px; background-color: #6666FF;">
                         <tr>
                             <td>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("movie_name") %>'></asp:Label>
                             </td>
                         </tr>
                          <tr>
                                   <td style="text-align: center" class="auto-style3">
                                       <asp:Button ID="Button1" runat="server"  Text="View details" BackColor="#CCCCFF" ForeColor="Black" Height="32px" Width="100%"  CommandName="viewdetail" CommandArgument='<%# Eval("movie_id") %>' />
                                   </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Button ID="remove_w" runat="server" Text="Remove" OnClick="remove_from_watchlater" CommandArgument='<%# Eval("movie_id") %>' />
                             </td>
                         </tr>
                     </table>
                 </ItemTemplate>
             </asp:DataList>
              <asp:Button ID="Button3" runat="server" Text="History" OnClick="show_history" />
             <asp:DataList ID="DataList2" runat="server" OnItemCommand="MovieList_ItemCommand" DataSourceID="SqlDataSource3" Visible="false">
                 <ItemTemplate>
                     <table class="nav-justified" style="width: 64%; height: 89px; margin-left: 19px; margin-right: 7px; margin-bottom: 1px; background-color: #6666FF;">
                         <tr>
                             <td>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("movie_id") %>'></asp:Label>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Eval("date_time") %>'></asp:Label>
                             </td>
                         </tr>
                          <tr>
                                   <td style="text-align: center" class="auto-style3">
                                       <asp:Button ID="Button1" runat="server"  Text="View details" BackColor="#CCCCFF" ForeColor="Black" Height="32px" Width="100%"  CommandName="viewdetail" CommandArgument='<%# Eval("movie_id") %>' />
                                   </td>
                         </tr>
                        
                     </table>
                 </ItemTemplate>
             </asp:DataList>
         </div>
         </div>
    </asp:content>
