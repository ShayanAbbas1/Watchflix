using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {
        string conString = ConfigurationManager.ConnectionStrings["DBcon"].ToString();
        public DataSet IsValid(String username, String Password)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select* FROM [User] where username='" + username +"' AND password='" + Password + "'");
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            return ds;
        }

        public bool IsValid(object userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
