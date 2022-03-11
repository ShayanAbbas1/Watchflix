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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Master.FindControl("SignIn_Btn").Visible = false;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("SignIn_Btn")).InnerText = "Sign In";
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("mastercontents")).Visible = false;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("watchnonclick")).Visible = true;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("watchclick")).Visible = false;

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            String UserName = txtUserName.Text;
            String Password = txtPassword.Text;
    
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid;
            valid = objmydal.func_Login(UserName, Password, ref DT);
            if (valid > 0)
            {
               
                Server.Transfer("WebForm1.aspx");
            }
            else
            {
              message1.InnerHtml= Convert.ToString("Invalid user");
            }
        }

    }
}
