using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp6.Classes
{
    class UserWords : UserWordsDatabase
    {
        public bool userWordTableCreate(int id)
        {
            bool tableCreateResult = false;
            string tableName = "Words_" + id;
            userWordConnect();
            MySqlCommand tableCreateCommand = new MySqlCommand("CREATE TABLE " + tableName + "(id INT PRIMARY KEY AUTO_INCREMENT, word_id VARCHAR(11),level INT,first_date DATE,last_date DATE) ", userWordConnection);
            if (tableCreateCommand.ExecuteNonQuery().ToString() == "0")
            {
                tableCreateResult = true;
            }
            userWordConnect();
            return tableCreateResult;
        }

        public bool userWordAdd(int userID,int wordID)
        {
            bool addResult = false;
            try
            {
                userWordConnect();
                DateTime time = new DateTime();
                time = DateTime.Today;
                MySqlCommand addWordCommand = new MySqlCommand("INSERT INTO words_"+userID+ " (word_id,level,first_date,last_date) VALUES ('" + wordID + "','" + 1 + "','" + time + "','" + time + "')", userWordConnection);
                addWordCommand.ExecuteNonQuery();
                addResult = true;
                userWordConnect(); 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return addResult;
        }

        public bool userWordDelete(int userID,int wordID)
        {
            bool deleteResult = false;
            try
            {
                userWordConnect();
                MySqlCommand deleteWordCommand = new MySqlCommand("DELETE FROM words_"+userID+" WHERE word_id=" + wordID , userWordConnection);
                deleteWordCommand.ExecuteNonQuery();
                deleteResult = true;
                userWordConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return deleteResult;
        }
        public int userWordSearch(int wordID, int userID)
        {
            int wordLevel = 0;
            userWordConnect();
            MySqlCommand uWSearchCommand = new MySqlCommand("Select * from words_"+userID+" WHERE word_id="+wordID,userWordConnection);
            MySqlDataReader reader = uWSearchCommand.ExecuteReader();
            while(reader.Read())
            {
                wordLevel =Convert.ToInt32( reader.GetString("level"));
            }
            userWordConnect();
            return wordLevel;
        }
        public ListView listUserWords(int userID)
        {
            ListView myWords = new ListView();
            List<int> myWordsLevel = new List<int>();
            List <int> myWordsID = new List<int>();
            userWordConnect();
            MySqlCommand listUserWordsCommand = new MySqlCommand("Select * from words_" + userID, userWordConnection);
            MySqlDataReader reader = listUserWordsCommand.ExecuteReader();
            while (reader.Read())
            {
                myWordsID.Add(reader.GetInt32("word_id"));
                myWordsLevel.Add(reader.GetInt32("level"));
                
            }
            userWordConnect();
            if (myWordsID.Count!=0)
            {
                Words wrds = new Words();
                myWords= wrds.myListSearch(myWordsID, myWordsLevel);
            }
            else
            {
                myWords = null;
            }
            

            return myWords;

        }
    }
    
}
