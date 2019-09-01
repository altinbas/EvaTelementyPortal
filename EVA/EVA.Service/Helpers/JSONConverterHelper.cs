using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EVA.Service.Helpers
{
    /// <summary>
    /// The class use for reading and converting from data json file.
    /// </summary>
    public class JSONConverterHelper
    {
        /// <summary>
        /// Opens the data json file and returns the file streem.
        /// </summary>
        /// <returns></returns>
        protected FileStream fnGetJSONFile()
        {
            try
            {
                return File.OpenRead("Modules.json");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Models.JSONFileMainModel>> fnGetDataFromJsonAsync()
        {
            try
            {
                var lcStreem = fnGetJSONFile();
                var lcByteData = new byte[lcStreem.Length];
                await lcStreem.ReadAsync(lcByteData, 0, int.Parse(lcStreem.Length.ToString()));
                var lcJsonData = System.Text.Encoding.UTF8.GetString(lcByteData);
                return JsonConvert.DeserializeObject<List<Models.JSONFileMainModel>>(lcJsonData);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
