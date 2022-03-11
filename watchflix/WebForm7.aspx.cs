using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using watchflix.DataAccessLayer;
using System.Data.SqlClient;

namespace watchflix
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            my_data_access_layer obj = new my_data_access_layer();
            obj.func_firstname();
            obj.func_lastname();
            obj.func_password();
            obj.func_accountnumber();
            obj.func_accounttype();
            obj.func_moneyleft();
            obj.func_date();
            obj.func_email();
            label_username.Text = classusername.user_name;
            label_firstname.Text = classusername.firstname;
            label_lastname.Text = classusername.lastname ;
            label_email.Text = classusername.email;
            label_password.Text = classusername.password;
            label_accnum.Text = classusername.AccountNumber.ToString();
            label_date.Text = classusername.created_on.ToString();
            label_money.Text = classusername.Money_left.ToString();
            if (classusername.Account_type == "P")
                Image1.Visible = true;
            SqlDataSource2.SelectCommand = "select * from watchlater as w join movie as m on w.movie_id=m.movie_id where w.[user_id]= '" + classusername.user_name + "'";
            SqlDataSource3.SelectCommand = "select * from watched as w join movie as m on w.movie_id=m.movie_id where w.[user_id]= '" + classusername.user_name + "'";

        }

        protected void remove_from_watchlater(object sender, EventArgs e)
        {
            string userName = classusername.user_name;
            Button btn = (Button)sender;
            int movie_id = int.Parse(btn.CommandArgument);
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid = objmydal.func_watchlater(userName, movie_id, ref DT);
            if (valid <= 0)
            {
                DataList1.DataBind();
            }
        }
        protected void MovieList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "viewdetail")
                Response.Redirect("WebForm2.aspx?id=" + e.CommandArgument.ToString());
        }
        protected void show_watchlater(object source, EventArgs e)
        {
            if (DataList1.Visible == false)
            { DataList1.Visible = true; }
            else
            { DataList1.Visible = false; }
        }
        protected void show_history(object source, EventArgs e)
        {
            if (DataList2.Visible == false)
            { DataList2.Visible = true; }
            else
            { DataList2.Visible = false; }
        }
    }
}