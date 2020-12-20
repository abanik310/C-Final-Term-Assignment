using Diary.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data_Access
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }

        public User UserDataRetrive(string userName, string passWord)
        {
            /*[Name] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Entry] [nvarchar](max) NOT NULL,
	[EntryDate] [date] NOT NULL,
	[Title] [varchar](50) NOT NULL,*/

            string sql = "SELECT * FROM Users WHERE Username='" + userName + "' AND Password='" + passWord + "'";
            SqlDataReader reader = dataAccess.GetData(sql);

            string name = reader["Name"].ToString();
            string username = reader["UserName"].ToString();
            string password = reader["Password"].ToString();
            string email = reader["Email"].ToString();
            string dateOfBirth = reader["DateOfBirth"].ToString();
            string gender = reader["Gender"].ToString();
            string entry = reader["Entry"].ToString();
            string entryDate = reader["EntryDate"].ToString();
            string title = reader["Title"].ToString();

            User user = new User(name, username, password, email, dateOfBirth, gender, entry, entryDate, title);

            return user;
        }


    }
}
