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
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = classusername.user_name;
            if (userName == "Admin")
            {
                addmovie.Visible = true;
            }
            A1.InnerHtml = userName;
            
        }
        
    }
}