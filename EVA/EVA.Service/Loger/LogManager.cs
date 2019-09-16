using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA.Service.Loger
{
    /// <summary>
    /// Log manager use for logging.
    /// </summary>
    public class LogManager
    {
        /// <summary>
        /// Connectionstring for local database
        /// </summary>
        readonly string mConnectionString;
        /// <summary>
        /// Connection ojbect
        /// </summary>
        SQLiteConnection mConnection;
        public LogManager(string argConnectionString)
        {
            mConnectionString = argConnectionString;
            mConnection = new SQLiteConnection(mConnectionString);
        }

        public void fnLog(LogModel argLogModel)
        {
            try
            {
                if (mConnection.State != System.Data.ConnectionState.Open)
                {
                    mConnection.Open();
                }
                var lcCommend = new SQLiteCommand(mConnection);
                lcCommend.CommandText = $"INSERT INTO Logs(OperationCode,Value,Date,Title) VALUES({argLogModel.OperationCode},{argLogModel.Value},'{argLogModel.Date}','{argLogModel.Title}')";
                var lcResult = lcCommend.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
        public List<LogModel> fnGetLogs(String argType = "All")
        {
            try
            {
                if (mConnection.State != System.Data.ConnectionState.Open)
                {
                    mConnection.Open();
                }
                var lcList = new List<LogModel>();
                var lcCommend = new SQLiteCommand(mConnection);
                if (argType.Equals("All"))
                {
                    lcCommend.CommandText = $"SELECT OperationCode,Value,Date,Title FROM Logs ORDER BY Date DESC LIMIT 1000";
                }
                else
                {
                    lcCommend.CommandText = $"SELECT OperationCode,Value,Date,Title FROM Logs WHERE Title='{argType}'  ORDER BY Date DESC LIMIT 1000";
                }
                var lcReader = lcCommend.ExecuteReader();
                while (lcReader.Read())
                {
                    var lcModel = new LogModel();
                    lcModel.OperationCode = lcReader.GetInt32(0);
                    lcModel.Value = lcReader.GetDouble(1);
                    lcModel.Title = lcReader.GetString(3);
                    lcModel.Date = lcReader.GetString(2);
                    lcList.Add(lcModel);
                }
                return lcList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<string> fnGetLogTyps()
        {
            try
            {
                if (mConnection.State != System.Data.ConnectionState.Open)
                {
                    mConnection.Open();
                }
                var lcList = new List<string>();
                var lcCommend = new SQLiteCommand(mConnection);
                lcCommend.CommandText = $"SELECT Title FROM Logs GROUP BY Title";
                var lcReader = lcCommend.ExecuteReader();
                while (lcReader.Read())
                {
                    lcList.Add(lcReader.GetString(0));
                }
                return lcList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
