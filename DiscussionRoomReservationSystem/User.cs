using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    internal class User
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());



        /*==============================MEMBER FIELD====================================*/
        public static string username;
        private string password;
        private string role;



        /*==============================GET AND SET METHOD====================================*/
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }


        /*==============================CONSTRUCTOR====================================*/

        /*
         * Call User Constractor from
         * Frm02_Login
         */
        public User(string un, string pw)
        {
            username = un;
            password = pw;
            role = "";
        }

        /*
         * Call User Constractor from
         * Frm03_Signup.cs
         */
        public User(string un, string pw, string rl)
        {
            username = un;
            password = pw;
            role = rl;
        }




        /*==============================METHOD====================================*/
        /*******************************Frm2****************************************/
        /*
         * User Login
         * parameter @username @password
         * return none
         */
        public string userLogin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Users where username= @username COLLATE SQL_Latin1_General_CP1_CS_AS and password= @password COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            //Return the number of user (this case the number of user should be one), if the user matches with database
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            //if count is 1
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                cmd2.Parameters.AddWithValue("@username", username);
                string userRole = cmd2.ExecuteScalar().ToString();
                con.Close();
                return userRole;
            }
            else
            {
                MessageBox.Show("Incorrect username/password");
                con.Close();
                return "";
            }

        }



        /*******************************Frm3****************************************/
        /*
         * User Sign Up
         * parameter @username @password @confirm password
         * return none
         */
        public bool userSignup(string cpw)
        {
            bool validation = true;

            //if pasword and confirm password is the same
            if (password == cpw)
            {
                //The new username had already the same one in database or not?
                con.Open();
                SqlCommand cmd = new SqlCommand("select username from Users", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd.GetString(0) == username)
                    {
                        validation = false;
                    }

                }
                con.Close();

                //validate if username is already stored in the database or not.
                if (validation == true)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into Users (username, password, role) values(@username, @password, 'student')", con);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@password", password);
                    int i = cmd2.ExecuteNonQuery(); //execute sql and return the number of rows which are updated
                    con.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("Registration Successful");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Unable to register.");
                    }

                    return false;
                }
                else
                {
                    MessageBox.Show("Username Already Exist");
                }

                return false;
            }
            else
            {
                MessageBox.Show("Password Missmatch");
            }

            return false;
        }
    }
}




