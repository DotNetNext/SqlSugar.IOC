using BizTest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        Test1 class1;
        ITest interface1;
        public WeatherForecastController(Test1 c1,ITest i1) 
        {
             this.class1 = c1;
             this.interface1 = i1;
        }


        [HttpGet]
        public DateTime Get()
        {
            var datetime= DbScoped.Sugar.GetDate();
            var datetime2 = DbScoped.Sugar.GetConnection("2").GetDate();
            return datetime;
        }
    }
}
