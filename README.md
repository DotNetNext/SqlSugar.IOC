# 1、简介
SqlSugar.IOC 是SqlSugar官方IOC框架，简单好用  10秒包会

## 版本支持：
 .NET CORE 3.1

 .NET5

SqlSugarCore 5.0.2.6 +



# 2、功能
1、SqlSugar注入

2、类注入

3、接口注入



# 3、安装
Nuget： SqlSugar.IOC

用到 DbScoped.Sugar 的类库就需要引用 SqlSugarCore,否则不需要安装


#4、用法
在注入实体类的同时,实体所继承的接口也注入进去了
```cs
//注入SqlSugar对象
services.AddSqlSugar(new IocConfig()
{
                ConnectionString = "server=.;uid=sa;pwd=haosql;database=qq1",
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
});



//注入控制器

services.AddIoc(this, "NETAPI", it => it.Name.Contains("Controller"));
```

//注入带有Test的类和Test继承的接口
services.AddIoc(this,"BizTest", it => it.Name.Contains("Test"));
上面代码只注入了带有Test所有类，那么接口也可以用了
```cs

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        IFace interface1;
    
        public WeatherForecastController(IFace i1)
        {
            this.interface1 = i1;
        }


        [HttpGet]
        public DateTime Get()
        {
            var datetime =   interface1;.GetDate();
            return datetime;
        }
    }
    ```
原因很简单: Test1继承了IFace，只要注入的类有继承关注就能用


```cs

 public class Test1:IFace  
  {
        public int Id { get; set; }
  }


```
