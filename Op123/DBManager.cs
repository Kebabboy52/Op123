using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Op123
{
    public class DBManager : IDisposable
    {
        SQLiteConnection conn;
        public DBManager(string path)
        {
            //conn = new SQLiteConnection(string.Format("Data Source={0}", path));
            conn = new SQLiteConnection("Data Source =" + path);
            conn.Open();

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (conn != null)
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Dispose();
                    conn = null;
                }
            }
        }
        ~DBManager()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Dispose();

            }
        }
        private string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] raw_string = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_string);
            string hash = Encoding.Unicode.GetString(raw_hash);
            sha256.Clear();
            return hash;
        }

        public bool AddUser(string username, string password)
        {

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SQLiteCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO users VALUES('" + username + "', '" + getHash(password) + "')";
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);

                    return false;
                }
            }
            return false;
        }
        public bool CheckUser(string username, string password)
        {

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SQLiteCommand command = conn.CreateCommand();

                    command.CommandText = "SELECT * FROM users Where Login='" + username + "' and password='" + getHash(password) + "'";
                    object result = command.ExecuteScalar();

                    if (result == null)
                        return false;
                    else
                        return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);

                    return false;
                }
            }
            return false;
        }

    }
}
