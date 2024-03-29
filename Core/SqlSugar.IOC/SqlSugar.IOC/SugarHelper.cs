﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace SqlSugar.IOC
{
    internal class SugarHelper
    {
        public static SqlSugarClient GetNewSugarClient()
        {
            List<ConnectionConfig> connectionConfigList = GetConnectionList();
            SqlSugarClient result = new SqlSugarClient(connectionConfigList);
            AopConfiguration(result);
            return result;
        }

        public static List<ConnectionConfig> GetConnectionList()
        {
            string json = GetConnectionJson();
            var connectionConfigList = JsonConvert.DeserializeObject<List<ConnectionConfig>>(json);
            foreach (var item in connectionConfigList)
            {
                if (item.SlaveConnectionConfigs != null && item.SlaveConnectionConfigs.Count > 0)
                {
                    foreach (var slave in item.SlaveConnectionConfigs)
                    {
                        slave.HitRate = 100;
                    }
                }
                if (item.AopEvents == null)
                {
                    item.AopEvents = new AopEvents();
                }
            }

            return connectionConfigList;
        }

        private static void AopConfiguration(SqlSugarClient result)
        {
            if (SugarServiceCollectionExtensions.Configuration != null)
            {
                SugarServiceCollectionExtensions.Configuration(result);
            }
        }

        private static string GetConnectionJson()
        {
            List<IocConfig> configs = SugarServiceCollectionExtensions.configs;
            var json = JsonConvert.SerializeObject(configs);
            return json;
        }
    }
}
