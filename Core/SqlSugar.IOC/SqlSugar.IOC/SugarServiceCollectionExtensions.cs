using Microsoft.Extensions.DependencyInjection;
using SqlSugar.IOC;
using System;
using Newtonsoft.Json;
using SqlSugar;
using System.Collections.Generic;

public static class SugarServiceCollectionExtensions
{
    internal static List<IocConfig> configs = new List<IocConfig>();
    public static void AddSqlSugar(this IServiceCollection server, IocConfig ioc)
    {
        configs.Add(ioc);
    }
    public static void AddSqlSugar(this IServiceCollection server, List<IocConfig> iocList)
    {
        configs.AddRange(iocList);
    }
}

