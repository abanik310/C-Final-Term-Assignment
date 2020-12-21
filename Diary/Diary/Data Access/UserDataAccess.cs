using Diary.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "SELECT * FROM Users2 WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if(reader.Read())
            {               
                    return true;
                
            }
            return false;
        }

        public string getUserID(string userName, string passWord)
        {
            string sql = "SELECT ID FROM Users2 where Username='"+userName+"' and Password = '"+passWord+"'";

            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = new DataTable();
            dataTable = dataAccess.GetDataTable(sql);
            
            return dataTable.Rows[0]["ID"].ToString();

            
        }

        public DataTable getUserData(string sql)
        {

            DataAccess dataAccess = new DataAccess();
            DataTable dataTable = new DataTable();
            dataTable = dataAccess.GetDataTable(sql);

            return dataTable;

        }

        public DataTable ReturnDataTable(string ID)
        {
            string sql = "SELECT Title,EnrtyDate,ID from Entries wHERE EntryID = '" + ID + "'";

            DataAccess dataAccess = new DataAccess();

            return dataAccess.GetDataTable(sql);
        }


    }
}
