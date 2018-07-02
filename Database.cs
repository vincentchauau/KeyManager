using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace KeyManager
{
    public class Database
    {
        private string _sql;
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private List<string> _columns = new List<string>() { "ID", "ADDRESS", "DESCRIPTION" };
        // 1. Create, open database, tables
        public void Open(string file)
        {
            if (File.Exists(file))
            {
                _connection = new SQLiteConnection("Data Source=" + file + ";Version=3;");
                _connection.Open();
            }
            else
            {
                _connection = new SQLiteConnection("Data Source=" + file + ";Version=3;");
                _connection.Open();
                _sql = "CREATE TABLE KEY(ID TEXT, ADDRESS TEXT, DESCRIPTION TEXT)";
                _command = new SQLiteCommand(_sql, _connection);
                _command.ExecuteNonQuery();
                StreamReader reader = new StreamReader("database.txt");
                string line = "";
                string[] words;
                while ((line = reader.ReadLine()) != null)
                {
                    words = line.Split('\t');
                    _sql = string.Format("INSERT INTO KEY(ID,ADDRESS,DESCRIPTION) VALUES ('{0}','{1}','{2}')", words[0], words[1], words[2]);
                    _command = new SQLiteCommand(_sql, _connection);
                    _command.ExecuteNonQuery();
                }
            }
        }
        // 2. Get keys
        public DataTable GetKeys(List<string> values)
        {
            DataTable dataTable = new DataTable();
            string likeString = "";
            for (int i = 0; i < values.Count; ++i)
            {
                if (values[i] != "" && values[i] != null)
                {
                    likeString += _columns[i] + " LIKE '%" + values[i] + "%' AND ";
                }
                else { }
            }
            _sql = "SELECT * FROM KEY";
            if (likeString != "")
            {
                _sql += " WHERE " + likeString.Substring(0, likeString.Length - 5);
            }
            else { }
            _command = new SQLiteCommand(_sql, _connection);
            SQLiteDataReader reader = _command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }
        // 3. Set a key
        public void SetKey(string id, string column, string value)
        {
            _sql = "UPDATE KEY SET " + column + "='" + value + "' WHERE ID='" + id + "'";
            _command = new SQLiteCommand(_sql, _connection);
            _command.ExecuteNonQuery();
        }
        public void SetDatabase(DataTable dataTable)
        {
            _sql = string.Format("SELECT * FROM {0}", dataTable.TableName);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(_sql, _connection);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
            adapter.Update(dataTable);
        }
        public void Close()
        {
            _connection.Close();
        }
    }
}
