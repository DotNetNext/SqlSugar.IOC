using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace SqlSugar.IOC
{
    internal class SugarHelper
    {
        public static SqlSugarClient GetNewSugarClient()
        {
            string json = GetConnectionJson();
            var connectionConfigList = JsonConvert.DeserializeObject<List<ConnectionConfig>>(json);
            SqlSugarClient result = new SqlSugarClient(connectionConfigList);
            return result;
        }

        private static string GetConnectionJson()
        {
            List<IocConfig> configs = SugarServiceCollectionExtensions.configs;
            var json = JsonConvert.SerializeObject(configs);
            return json;
        }
    }
}
