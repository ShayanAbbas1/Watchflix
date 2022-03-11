using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using watchflix.DataAccessLayer;
using System.Data.SqlClient;

namespace watchflix
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string movielink = Request.QueryString["link"];

            }


        }

        protected void Btn_like(object sender, EventArgs e)
        {
            string userName = classusername.user_name;
            ImageButton btn = (ImageButton)sender;
            int movie_id = int.Parse(btn.CommandArgument);
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid = objmydal.func_like(userName, movie_id, ref DT);
            if (valid > 0)
            {
                DataList4.Visible = true;
                DataList2.Visible = false;

            }
            else
            {
                DataList4.Visible = false;
                DataList2.Visible = true;

            }
            DataList1.DataBind();
            DataList2.DataBind();
            DataList3.DataBind();
            DataList4.DataBind();
            DataList5.DataBind();

        }
        protected void Btn_watch(object sender, EventArgs e)
        {
            string[] arg = new string[2];
            string userName = classusername.user_name;
            ImageButton btn = (ImageButton)sender;
            arg = btn.CommandArgument.Split(';');
            int movie_id = int.Parse(arg[0]);
            string linkurl = arg[1];
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid = objmydal.func_watch(userName, movie_id, ref DT);
            if (valid > 0)
            {
                Response.Redirect(linkurl);
            }
            else
            {
                moneymessage.InnerHtml = Convert.ToString("You have less than 5 dollars in your account");
                Btnmore_money.Visible = true;
            }
            DataList1.DataBind();
            DataList2.DataBind();
            DataList3.DataBind();
            DataList4.DataBind();
            DataList5.DataBind();
        }
        protected void Btn_money(object sender, EventArgs e)
        {
            message1.InnerHtml = Convert.ToString("Enter the amount you want to add in your account : ");
            message1.Visible = true;
            moremoneytext.Visible = true;
            Btn_add_mon.Visible = true;

        }
        protected void Btn_add_money(object sender, EventArgs e)
        {
            string userName = classusername.user_name;
            int moremoney = int.Parse(moremoneytext.Text);
            my_data_access_layer objmydal = new my_data_access_layer();
            objmydal.func_updatemoney(userName, moremoney);
            message1.Visible = false;
            moremoneytext.Visible = false;
            Btn_add_mon.Visible = false;
            moneymessage.Visible = false;
            Btnmore_money.Visible = false;

        }
        protected void Btn_writereview(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            DataList8.Visible = true;
            DataList6.Visible = false;
        }
        protected void Btn_postreview(object sender, EventArgs e)
        {

            string text = TextBox1.Text;
            string userName = classusername.user_name;
            Button btn = (Button)sender;

            int movie_id = int.Parse(btn.CommandArgument);
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            objmydal.func_writereview(userName, movie_id, text, ref DT);
            DataList1.DataBind();
            DataList2.DataBind();
            DataList3.DataBind();
            DataList4.DataBind();
            DataList5.DataBind();
            DataList6.DataBind();
            DataList8.DataBind();
            TextBox1.Visible = false;
            DataList8.Visible = false;
        }
        protected void Btn_rate(object sender, EventArgs e)
        {
            if (Rating_drop.SelectedItem.Value != "1" && Rating_drop.SelectedItem.Value != "2" && Rating_drop.SelectedItem.Value != "3" && Rating_drop.SelectedItem.Value != "4" && Rating_drop.SelectedItem.Value != "5")
            {

            }
            else
            {
                int rate_num = int.Parse(Rating_drop.SelectedItem.Value);
                DataTable DT = new DataTable();
                string userName = classusername.user_name;
                Button btn = (Button)sender;
                int movie_id = int.Parse(btn.CommandArgument);
                my_data_access_layer objmydal = new my_data_access_layer();
                objmydal.Func_rate(movie_id, userName, rate_num, ref DT);
                DataList1.DataBind();
                DataList2.DataBind();
                DataList3.DataBind();
                DataList4.DataBind();
                DataList5.DataBind();
                DataList6.Visible = true;
            }
        }
        protected void Btn_View_reviews(object sender, EventArgs e)
        {
            if (GridView1.Visible == true)
            {
                GridView1.Visible = false;
            }
            else
            {
                ImageButton btn = (ImageButton)sender;
                int castid = int.Parse(btn.CommandArgument);
                DataTable DT = new DataTable();
                my_data_access_layer objmydal = new my_data_access_layer();
                GridView1.DataSource = objmydal.func_review(castid, ref DT);
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }
        protected void Btn_View_cast(object sender, EventArgs e)
        {
            if (GridView2.Visible == true)
            {
                GridView2.Visible = false;
            }
            else
            {
                ImageButton btn = (ImageButton)sender;
                int castid = int.Parse(btn.CommandArgument);
                DataTable DT = new DataTable();
                my_data_access_layer objmydal = new my_data_access_layer();
                GridView2.DataSource = objmydal.func_cast(castid, ref DT);
                GridView2.DataBind();
                GridView2.Visible = true;
            }

        }
        protected void Btn_Watchlater(object sender, EventArgs e)
        {
            string userName = classusername.user_name;
            Button btn = (Button)sender;
            int movie_id = int.Parse(btn.CommandArgument);
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid = objmydal.func_watchlater(userName, movie_id, ref DT);
            
        }
    }
}