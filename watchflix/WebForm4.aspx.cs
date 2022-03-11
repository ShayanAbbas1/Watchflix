using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using watchflix.DataAccessLayer;
namespace watchflix
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("SignIn_Btn")).InnerText = "Sign In";
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("search")).Visible = false;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("mastercontents")).Visible = false;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("watchnonclick")).Visible = true;
            ((System.Web.UI.HtmlControls.HtmlContainerControl)Master.FindControl("watchclick")).Visible = false;
        }
        protected void BtnLogin_SignUp(object sender, EventArgs e)
        {
            String UserName = TextBoxUserName.Text;
            String Firstname = TextBoxFirstName.Text;
            String LastName = TextBoxLastName.Text;
            String email = TextBoxEmail.Text;
            String Password = TextBoxPassword.Text;
            int Account = int.Parse(TextBoxAccounttype.Text);
            int Money = int.Parse(TextBoxMoney.Text);
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid;
            valid = objmydal.func_Signup(UserName,Firstname,LastName,email,Account, Password,Money, ref DT);
            if (valid > 0)
            {
                Server.Transfer("WebForm5.aspx");
            }
            else
            {
                message.InnerHtml = Convert.ToString("Invalid user");
            }
        }
    }
}