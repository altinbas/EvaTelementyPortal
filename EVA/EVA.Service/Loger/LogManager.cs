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
                lcCommend.CommandText = $"INSERT INTO Logs(OperationCode,Value,Date,Title) VALUES({argLogModel.OperationCode},{argLogModel.Value},'{argLogModel.Date.ToString("yyyy-MM-dd-HH:mm:ms")}','{argLogModel.Title}')";
                var lcResult = lcCommend.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
