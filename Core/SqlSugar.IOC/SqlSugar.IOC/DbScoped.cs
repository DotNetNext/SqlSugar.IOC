using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugar.IOC
{
    public class DbScoped  
    {
        public static SqlSugarClient Sugar
        {
            get
            {
                SqlSugarClient result = GetSqlSugarClient();
                return result;
            }
        }

        private static SqlSugarClient GetSqlSugarClient()
        {
            var sugar = IocCallContext<SqlSugarClient>.GetData(IocConst.DbKey);
            if (sugar == null)
            {
                var result= SugarHelper.GetNewSugarClient();
                IocCallContext<SqlSugarClient>.SetData(IocConst.DbKey,result);
                return result;
            }
            else 
            {
                return sugar;
            }
        }
    }
}
