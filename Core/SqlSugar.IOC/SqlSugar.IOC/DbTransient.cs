using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugar.IOC
{
    public class DbTransient  
    {
        public static SqlSugarClient Sugar => SugarHelper.GetNewSugarClient();
    }
}
