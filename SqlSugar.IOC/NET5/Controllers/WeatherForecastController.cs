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
        [HttpGet]
        public DateTime Get()
        {
            var datetime= DbScoped.Sugar.GetDate();
            return datetime;
        }
    }
}
