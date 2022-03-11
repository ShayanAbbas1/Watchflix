using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace watchflix.DataAccessLayer
{
    public class my_data_access_layer
    {
        private static readonly string connString =
            System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        public string func_firstname()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try 
            {
                cmd = new SqlCommand("select firstname from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.firstname = ds.Tables[0].Rows[0]["firstname"].ToString();
            return classusername.firstname;
        }
        public string func_lastname()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select lastname from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.lastname = ds.Tables[0].Rows[0]["lastname"].ToString();
            return classusername.lastname;
        }
        public string func_email()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select email from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.email = ds.Tables[0].Rows[0]["email"].ToString();
            return classusername.email;
        }
        public string func_password()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select [password] from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.password = ds.Tables[0].Rows[0]["password"].ToString();
            return classusername.password;
        }
        public string func_accounttype()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select accounttype from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.Account_type = ds.Tables[0].Rows[0]["accounttype"].ToString();
            return classusername.Account_type;
        }
        public DateTime? func_date()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select [date] from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.created_on = (DateTime)ds.Tables[0].Rows[0]["date"];
            return classusername.created_on;
        }
        public int? func_accountnumber()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select accountnumber from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.AccountNumber = (int)ds.Tables[0].Rows[0]["accountnumber"];
            return classusername.AccountNumber;
        }
        public int? func_moneyleft()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select money_inerted from [user] where username=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", classusername.user_name);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            classusername.Money_left = (int)ds.Tables[0].Rows[0]["money_inerted"];
            return classusername.Money_left;
        }
        public int func_Login(String username, String password, ref DataTable DT)
        {

            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("[login1]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@password1", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@username1"].Value = username;
                cmd.Parameters["@password1"].Value = password;
                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@status"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        DT = new DataTable();
                        da.Fill(DT);
                    }
                    classusername.user_name = username;
                
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public int func_search(String movie_name, ref DataTable DT)
        {
            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("[search]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@search_text", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@found", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@search_text"].Value = movie_name;
                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@found"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    DT = ds.Tables[0];
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public int func_Signup(String username, String firstname, String lastname, string email, int account_number, String password, int money, ref DataTable DT)
        {
            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("[signup1]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@firstname1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@lastname1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@email1", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@password1", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@money", SqlDbType.Int);
                cmd.Parameters.Add("@account_number", SqlDbType.Int);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@username1"].Value = username;
                cmd.Parameters["@firstname1"].Value = firstname;
                cmd.Parameters["@lastname1"].Value = lastname;
                cmd.Parameters["@email1"].Value = email;
                cmd.Parameters["@password1"].Value = password;
                cmd.Parameters["@account_number"].Value = account_number;
                cmd.Parameters["@money"].Value = money;
                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@status"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public void func_addcast(String act1, String act2, String act3, String dir1, String dir2, String wri1, String wri2, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("add_cast", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@actor1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@actor2", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@actor3", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@director1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@director2", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@writer1", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@writer2", SqlDbType.VarChar, 30);
                cmd.Parameters["@actor1"].Value = act1;
                cmd.Parameters["@actor2"].Value = act2;
                cmd.Parameters["@actor3"].Value = act3;
                cmd.Parameters["@director1"].Value = dir1;
                cmd.Parameters["@director2"].Value = dir2;
                cmd.Parameters["@writer1"].Value = wri1;
                cmd.Parameters["@writer2"].Value = wri2;
                cmd.ExecuteNonQuery();


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    DT = new DataTable();
                    da.Fill(DT);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public int func_addmovie(String moviename, DateTime date, int genre, string link)
        {
            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("add_a_movie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@movie_name", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@release_date", SqlDbType.Date);
                cmd.Parameters.Add("@movie_added", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@genre_id", SqlDbType.Int);
                cmd.Parameters.Add("@link", SqlDbType.VarChar);
                cmd.Parameters["@movie_name"].Value = moviename;
                cmd.Parameters["@release_date"].Value = date;
                cmd.Parameters["@genre_id"].Value = genre;
                cmd.Parameters["@link"].Value = link;

                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@movie_added"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public int func_like(string username, int movieid, ref DataTable DT)
        {
            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("like_a_movie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movie_id", SqlDbType.Int);
                cmd.Parameters.Add("@liked", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@movie_id"].Value = movieid;
                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@liked"].Value);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    DT = new DataTable();
                    da.Fill(DT);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public int func_watch(string username, int movieid, ref DataTable DT)
        {
            int valid = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("watch_a_movie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movie_id", SqlDbType.Int);
                cmd.Parameters.Add("@allowed", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@movie_id"].Value = movieid;


                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@allowed"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        DT = new DataTable();
                        da.Fill(DT);
                    }
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
        public void func_updatemoney(string user_name, int moremoney)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "update [user] set money_inerted=@moremoney1+money_inerted where username=@user_name";
            cmd.Parameters.Add("@user_name", SqlDbType.VarChar, 30);
            cmd.Parameters.Add("@moremoney1", SqlDbType.Int);
            cmd.Parameters["@user_name"].Value = user_name;
            cmd.Parameters["@moremoney1"].Value = moremoney;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void func_sort(string sort, ref DataTable DT)
        {

            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sort_by", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sorting", SqlDbType.VarChar, 20);
                cmd.Parameters["@sorting"].Value = sort;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    DT = new DataTable();
                    da.Fill(DT);
                }
                con.Close();

            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public void Func_rate(int movieid, string user_name, int ratenum, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("rate_a_movie", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movie_id", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@rate_num", SqlDbType.Int);
                cmd.Parameters["@username"].Value = user_name;
                cmd.Parameters["@movie_id"].Value = movieid;
                cmd.Parameters["@rate_num"].Value = ratenum;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    DT = new DataTable();
                    da.Fill(DT);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void func_writereview(string username, int movie_id, string text, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("post_a_review", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movie_id", SqlDbType.Int);
                cmd.Parameters.Add("@review_text", SqlDbType.VarChar, 100);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@movie_id"].Value = movie_id;
                cmd.Parameters["@review_text"].Value = text;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    DT = new DataTable();
                    da.Fill(DT);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet func_review(int castid, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select * from cast where cast_id="+castid, con);
                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                  
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet func_cast(int movie_id, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select username,review_text from review where movie_id=" +movie_id, con);
                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public int func_watchlater(string username,int movie_id, ref DataTable DT)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            int valid=0;
            try
            {
                cmd = new SqlCommand("add_to_watchlater", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@movie_id", SqlDbType.Int);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@movie_id"].Value = movie_id;
                cmd.ExecuteNonQuery();
                valid = Convert.ToInt32(cmd.Parameters["@status"].Value);
                if (valid == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        DT = new DataTable();
                        da.Fill(DT);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return valid;
        }
       
    }

}