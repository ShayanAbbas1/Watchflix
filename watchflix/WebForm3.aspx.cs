using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace watchflix
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
        protected void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void MovieList_ItemCommand(object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName== "viewdetail")
                Response.Redirect("WebForm2.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}