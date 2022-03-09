using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugar.IOC 
{
    public enum IocDbType
    {
        MySql,
        SqlServer,
        Sqlite,
        Oracle,
        PostgreSQL,
        Dm,
        Kdbndp,
        Oscar,
        MySqlConnector,
        Access,
        Custom = 900
    }
}
