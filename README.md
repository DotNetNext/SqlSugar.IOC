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


# 4、用法

```cs
//注入SqlSugar对象
services.AddSqlSugar(new IocConfig()
{
                ConnectionString = "server=.;uid=sa;pwd=haosql;database=qq1",
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
});
```
 
### 使用注入后SqlSugar对象
```cs
  public List<UserOrgMapping> GetMapping() 
  {
            List<UserOrgMapping> result=DbScoped.Sugar.Queryable<UserOrgMapping>()
                .Mapper(it => it.OrgInfo, it => it.OrgId)
                .Mapper(it => it.UserInfo, it => it.UserId)
                .ToList();
             DbScoped.Sugar.Deleteable<Student>().In(1).ExecuteCommand();
            return result;
  }
```

# 5.更多用法
http://www.donet5.com/Doc/10/2253
