using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugar.IOC
{
    public class SugarIocServices
    {
        public static void AddSqlSugar(IocConfig ioc)
        {
            SugarServiceCollectionExtensions.configs.Add(ioc);
        }
        public static void AddSqlSugar(List<IocConfig> iocList)
        {
            SugarServiceCollectionExtensions.configs.AddRange(iocList);
        }
    }
}
