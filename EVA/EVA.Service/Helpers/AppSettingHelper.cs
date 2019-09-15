using System.Configuration;

namespace EVA.Service.Helpers
{
    public class AppSettingHelper
    {
        public static string ValueSperater { get => ConfigurationManager.AppSettings["valueSperator"].ToString(); }
        public static string PachageSperator { get => ConfigurationManager.AppSettings["pachageSperator"].ToString(); }
        public static string Host { get => ConfigurationManager.AppSettings["webHost"].ToString(); }
        public static string SQLiteConnection { get => ConfigurationManager.AppSettings["sqlite"].ToString(); }
        public static string HostSecyrityKey { get => ConfigurationManager.AppSettings["securityCode"].ToString(); }
    }
}
