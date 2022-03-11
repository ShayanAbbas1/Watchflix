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
    public partial class WebForm6 : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT genre_id, genre_type FROM genre"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        genrelist.DataSource = cmd.ExecuteReader();
                        genrelist.DataTextField = "genre_type";
                        genrelist.DataValueField = "genre_id";
                        genrelist.DataBind();
                        con.Close();
                    }
                }
            }
        }
        
        protected void AddMovie(object sender, EventArgs e)
        {
            String moviename = textmoviename.Text;
            DateTime date = DateTime.Parse(textdate.Text);
            int genre = int.Parse(genrelist.SelectedItem.Value);
            string link = Link_for_movie.Text;
            my_data_access_layer objmydal = new my_data_access_layer();
            int Valid;
            Valid = objmydal.func_addmovie(moviename, date, genre,link);
            if (Valid > 0)
            {
                Server.Transfer("WebForm1.aspx");
            }
            else
            {
                messageadd.InnerHtml = Convert.ToString("movie already exists");
            }
        }
        protected void cast_button(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();

            String act1 = actor1.Text;
            String act2 = actor2.Text;
            String act3 = actor3.Text;
            String dir1 = director1.Text;
            String dir2 = director2.Text;
            String wri1 = writer1.Text;
            String wri2 = writer2.Text;
            my_data_access_layer objmydal = new my_data_access_layer();
            objmydal.func_addcast(act1, act2, act3, dir1, dir2, wri1, wri2,ref DT);
        }

    }
}