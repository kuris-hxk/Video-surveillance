using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayVideo
{

    public class SQLiteHelper
    {
        /// <summary>
        /// ConnectionString样¨´例：阰Datasource=Test.db3;Pooling=true;FailIfMissing=false
        /// </summary>
        public static SQLiteConnection conn;
        public static string dbName = "db.sqlite";
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory +  dbName;
        public static string ConnectionString = "Data Source=" + path + ";Pooling=true;FailIfMissing=false";
        //创建一个空的数据库
        public  void createNewDatabase()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                createTable();
            }
        }

        //创建一个连接到指定数据库
        public static void connectToDatabase()
        {
              conn = new SQLiteConnection(ConnectionString);// ("Data Source=MyDatabase.sqlite;Version=3;");
              conn.Open();
        }

        //在指定数据库中创建一个table
        public static void createTable()
        {
            string sql = "create table camerDevice ([Id] INTEGER PRIMARY KEY AUTOINCREMENT,name nvarchar(1024), frameSize nvarchar(50),deviceID nvarchar(1024),frameSizeIndex int)";
            ExecuteNonQuery(sql, null);
            
        }

        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string cmdText, params SQLiteParameter[] p)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Parameters.Clear();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            if (p != null)
            {
                foreach (object parm in p)
                    //cmd.Parameters.AddWithValue(string.Empty, parm);
                    cmd.Parameters.Add(parm);
            }
        }

        public static DataSet ExecuteQuery(string cmdText, params SQLiteParameter[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    DataSet ds = new DataSet();
                    PrepareCommand(command, conn, cmdText, p);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                    da.Fill(ds);
                    return ds;
                }
            }
        }


        public static int ExecuteNonQuery(string cmdText, params SQLiteParameter[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    PrepareCommand(command, conn, cmdText, p);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static SQLiteDataReader ExecuteReader(string cmdText, params SQLiteParameter[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    PrepareCommand(command, conn, cmdText, p);
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
        }

        public static object ExecuteScalar(string cmdText, params SQLiteParameter[] p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    PrepareCommand(command, conn, cmdText, p);
                    return command.ExecuteScalar();
                }
            }
        }


    }
}
