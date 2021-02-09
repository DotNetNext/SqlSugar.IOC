using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugar.IOC 
{
    public class IocConfig
    {

        public dynamic ConfigId { get; set; }

        public IocDbType DbType { get; set; }

        public string ConnectionString { get; set; }

        public bool IsAutoCloseConnection { get; set; }

        public List<IocConfig> SlaveConnectionConfigs { get; set; }
    }
}
