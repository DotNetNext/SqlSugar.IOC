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
        OpenGauss,
        QuestDB,
        HG,
        ClickHouse,
        GBase,
        Odbc,
        OceanBaseForOracle,
        TDengine,
        GaussDB,
        OceanBase,
        Tidb,
        Vastbase,
        PolarDB,
        Doris,
        Xugu,
        GoldenDB,
        TDSQLForPGODBC,
        TDSQL,
        HANA,
        DB2,
        GaussDBNative,
        DuckDB,
        MongoDb,
        Custom = 900
    }
}
