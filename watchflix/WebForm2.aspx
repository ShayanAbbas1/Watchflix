<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="watchflix.WebForm2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br />
    
    <div>
    <asp:DataList ID="DataList1" style="margin:0px 43px 284px auto;"  runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" Height="1965px">
        <ItemTemplate>
            <table class="nav-justified" style="  will-change:auto; background-color: #333333; width: 70%; height: 316px;">
                <tr>
                    <td class="modal-sm"  style="width: auto; background-color: #333333;"  aria-orientation="vertical">
                        <table  style="border:7px outset darkgray;width: 80%; height: 271px; margin-left: 10%; background-color: #999999; color: #666699; margin-top: 10%;">
                            <tr>
                                <td style="border:3px outset blue">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("movie_name", "{0}") %>'  Font-Bold="True" Font-Size="Large" ForeColor="#990033"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border:3px outset pink">
                                    <strong>&nbsp;&nbsp; Release Date</strong>:
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("release_date", "{0:d}") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 35px; border:3px outset yellow">
                                    <strong>&nbsp;&nbsp; Likes: </strong><asp:Label ID="Label4" runat="server" Text='<%# Eval("likes", "{0}") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border:3px outset brown">
                                    <strong>&nbsp;&nbsp;&nbsp; Rating(1-5):&nbsp; </strong><asp:Label ID="Label5" runat="server" Text='<%# Eval("rating", "{0}") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="border:3px outset green">
                                    <strong>&nbsp;&nbsp;&nbsp; Views</strong><asp:Label ID="Label6" runat="server" Text='<%# Eval("watched_by", "{0}") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>&nbsp;&nbsp;&nbsp; Published on:&nbsp; </strong>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("publish_date", "{0:d}") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        &nbsp;&nbsp;&nbsp;
                    </td>
                    
                </tr>
            </table>
            <br />
            <br />
        </ItemTemplate>
     
    </asp:DataList>
        <asp:DataList ID="DataList20" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" Width="300px">
    <ItemTemplate>
            
        <asp:Button ID="w_later"  runat="server" OnClick="Btn_Watchlater" CommandArgument='<%# Eval("movie_id") %>' Text="Watchlater" Height="34px" style="border-radius:10px 10px; background-color:mediumpurple; margin-left: 28px; margin-bottom:30px; margin-top: 0" Width="137px" />
        </ItemTemplate>
    </asp:DataList>

       


    <asp:SqlDataSource  ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlCon1 %>" SelectCommand="SELECT * FROM [movie] WHERE ([movie_id] = @movie_id)">
    <SelectParameters>
            <asp:QueryStringParameter Name="movie_id" QueryStringField="id" Type="Int32" /> 
    </SelectParameters>
    </asp:SqlDataSource>
      
      
               <br/>
           <asp:DropDownList ID="Rating_drop"  Font-Size="Larger" Width="15%" style=" margin-left:146px; border-radius:10px 10px; margin-bottom: 0; margin-top: 0;" Height="10%"  runat="server" BackColor="Yellow" ForeColor="#9900CC" CssClass="navbar-header">
             <asp:ListItem Text="Rate this movie"></asp:ListItem>
            <asp:ListItem Text="5" value="5"></asp:ListItem>
            <asp:ListItem Text="4" value="4"></asp:ListItem>
            <asp:ListItem Text="3" value="3"></asp:ListItem>
            <asp:ListItem Text="2" value="2"></asp:ListItem>
            <asp:ListItem Text="1" value="1"></asp:ListItem>

        </asp:DropDownList>
        <asp:DataList ID="DataList3" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" Width="300px">
    <ItemTemplate>
            
                 <asp:Button ID="Button_rate" Width="40%" OnClick="Btn_rate" Text="Rate"  runat="server" CommandArgument='<%# Eval("movie_id") %>' BackColor="#CC6600" Height="31px" style=" border-radius:10px 10px; margin-left: 5px; margin-top: 9px"/>
</ItemTemplate>
    </asp:DataList>
        <asp:DataList ID="DataList6" runat="server" DataKeyField="movie_id" Visible="false" DataSourceID="SqlDataSource1" CssClass="navbar-header" Width="300px">
        <ItemTemplate>
            <asp:Button ID="Button1" CommandArgument='<%# Eval("movie_id") %>'  runat="server" Text="Write a Review" OnClick="Btn_writereview" />
     </ItemTemplate>
    </asp:DataList>
        
       <asp:TextBox ID="TextBox1" runat="server" Visible="false"  CssClass="navbar-header" Width="309px" style="margin-left: 26px; margin-right: 0px" BackColor="#CCCCFF"></asp:TextBox>
 
        <asp:DataList ID="DataList8" runat="server" DataKeyField="movie_id" Visible="false" DataSourceID="SqlDataSource1" CssClass="navbar-header" Width="44px" style="margin-left: 0px">
        <ItemTemplate>
            <asp:Button ID="Button1" CommandArgument='<%# Eval("movie_id") %>'  runat="server" Text="Post" OnClick="Btn_postreview" />
 </ItemTemplate>
    </asp:DataList>
        <br/>
    <asp:DataList ID="DataList2" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" Width="300px">
    <ItemTemplate>
            <asp:ImageButton ID="Like" style=" margin-left:5px; border-radius:10px 10px" runat="server" Height="20%"
            ImageUrl="~/images/orangelikebuttton.jpg" Width="40%" OnClick="Btn_like" CommandArgument='<%# Eval("movie_id") %>'  />
    </ItemTemplate>
    </asp:DataList>
    <asp:DataList ID="DataList4" Visible="false" style="float:left;" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" RepeatDirection="Horizontal" Width="300px">
    <ItemTemplate>
        <asp:ImageButton ID="Unlike"  style=" margin-left:5px; border-radius:10px 10px" runat="server" Height="10%"
            ImageUrl="~/images/dislike.jpg" Width="40%" OnClick="Btn_like" CommandArgument='<%# Eval("movie_id") %>'  />       
    </ItemTemplate>
    </asp:DataList>
        <div ID="Div1" runat="server"></div>
                 <div id="moneymessage" runat="server"></div>
        <asp:Button ID="Btnmore_money" style="float:left" text="insert more money" runat="server" OnClick="Btn_money"  Visible="false" />
        <br/><br />
                         <div id="message1" visible="false" runat="server"></div>
                 <asp:TextBox ID="moremoneytext" runat="server" Visible="false"></asp:TextBox>
                <asp:Button ID="Btn_add_mon" Text="add" runat="server" OnClick="Btn_add_money" Visible="false" />

        <asp:DataList ID="DataList5" style="float:left;" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1">
        <ItemTemplate>
        <asp:ImageButton style="margin-left:15px; border-radius:10px 10px" ID="ImageButton2" runat="server" Height="15%" 
            ImageUrl="~/images/playbutton.jpg" Width="42%" OnClick="Btn_watch" OnClientClick="target ='_blank';" CommandArgument='<%# Eval("movie_id") +";"+Eval("link") %>' />
     </ItemTemplate>
    </asp:DataList>
         <asp:DataList ID="DataList7" style="float:left;" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1">
        <ItemTemplate>
        <asp:ImageButton style="margin-left:15px; border-radius:10px 10px" ID="ImageButton2" runat="server" Height="15%" 
            ImageUrl="~/images/cast.jpg" Width="42%" OnClick="Btn_View_reviews"  CommandArgument='<%# Eval("cast_id") %>' />
     </ItemTemplate>
    </asp:DataList>
         <asp:DataList ID="DataList10" runat="server">
        </asp:DataList>
         <asp:DataList ID="DataList9" runat="server" DataKeyField="movie_id" DataSourceID="SqlDataSource1" CssClass="navbar-header" >
        <ItemTemplate>
        <asp:ImageButton style="margin-left:15px; border-radius:10px 10px" ID="ImageButton2" runat="server" Height="15%" 
            ImageUrl="~/images/reviews.jpg" Width="42%" OnClick="Btn_View_cast"  CommandArgument='<%# Eval("movie_id") %>' />
     </ItemTemplate>
    </asp:DataList>
         <asp:GridView ID="GridView1" runat="server" visible="false" BackColor="White" BorderColor="#9999FF" BorderStyle="Double" CellSpacing="5" Font-Italic="True" Font-Strikeout="False" ForeColor="#660066" GridLines="None" HorizontalAlign="Center" Width="331px">
        </asp:GridView>
        &nbsp
         <asp:GridView ID="GridView2" runat="server" visible="false" BackColor="White" BorderColor="#9999FF" BorderStyle="Double" CellSpacing="5" Font-Italic="True" Font-Strikeout="False" ForeColor="#660066" GridLines="None" HorizontalAlign="Center" Width="331px">
        </asp:GridView>
    </div> 
        
        
   
   
    </asp:Content>

