using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middlelayer
{
    public class UserBO
    {
        private string username="";
        private string password="";

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        DataAccess da = new DataAccess();
        public bool GetUser()
        {
            if (da.IsValid(username, Password).Tables[0].Rows.Count == 0)
                return true;
            else
                return false;
        }
    }
}
