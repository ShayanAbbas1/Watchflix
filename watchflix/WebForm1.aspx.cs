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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Btn_Search_func(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate()";
            String search_word = txtsearch.Text;
            DataTable DT = new DataTable();
            my_data_access_layer objmydal = new my_data_access_layer();
            int valid;
            valid = objmydal.func_search(search_word, ref DT);
            if (valid > 0)
            {
                searchword.search_word = search_word;
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [movie_name] LIKE '%"+searchword.search_word+"%'"; ;

            }
            else
            {
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [movie_name] LIKE '%" + searchword.search_word + "%'"; ;

            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void Dropdown_sort_by(object sender, EventArgs e)
        {
            string sort = (drop_sortby.SelectedItem.Value);
            if (sort == "0")
            {
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate() ";
            }
            else if (sort == "1")
            {
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate()  ORDER BY [release_date] DESC";
            }
            else if (sort == "2")
            {
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate() ORDER BY [release_date] ";
            }
            else if (sort == "3")
            {
                SqlDataSource1.SelectCommand = "SELECT [movie_id],[movie_name], [release_date], [rating] FROM [movie] WHERE [release_date]<=getdate() ORDER BY [rating]";
            }

            my_data_access_layer objmydal = new my_data_access_layer();
            DataTable DT = new DataTable();
            objmydal.func_sort(sort,ref DT);
        }
        protected void MovieList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName=="viewdetail")
                Response.Redirect("WebForm2.aspx?id="+e.CommandArgument.ToString());
        }
    }
}