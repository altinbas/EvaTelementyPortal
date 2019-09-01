using System.Configuration;

namespace EVA.Service.Helpers
{
    public class AppSettingHelper
    {
        public static string ValueSperater { get => ConfigurationManager.AppSettings["valueSperator"].ToString(); }
        public static string PachageSperator { get => ConfigurationManager.AppSettings["pachageSperator"].ToString(); }
    }
}
