using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp6.Classes
{
    class Tools : MainDatabase
    {
        private static string encryption(string pass, HashAlgorithm alg)
        {
            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(pass);
            byte[] passByte = alg.ComputeHash(byteValue);
            return Convert.ToBase64String(passByte);
        }
        public string MD5Convert(string pass)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return encryption(pass, pwd);
        }
        public int userGetID(string userName)
        {
            int userID = 0;
            mainConnect();
            MySqlCommand userIDCommand = new MySqlCommand("SELECT id from users WHERE username='" + userName + "' ", mainDatabeseConn);
            MySqlDataReader reader = userIDCommand.ExecuteReader();
            reader.Read();
            userID = reader.GetInt32("id");
            mainConnect();
            return userID;
        }
        public string userGetUserName(string id)
        {
            string userName = null;
            mainConnect();
            MySqlCommand userIDCommand = new MySqlCommand("SELECT username from users WHERE id='" + id + "' ", mainDatabeseConn);
            MySqlDataReader reader = userIDCommand.ExecuteReader();
            reader.Read();
            userName = reader.GetString("username").ToString();
            mainConnect();
            return userName;
        }
    }
}
