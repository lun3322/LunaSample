using Luna;
using Luna.Dapper;
using Luna.Dependency;
using Luna.MongoDb;
using Luna.Redis.AspNetCore;
using Luna.Web;
using LunaSample.Core;
using LunaSample.Service;
using Microsoft.Extensions.DependencyInjection;

namespace LunaSample.Web
{
    [Dependency(
        typeof(LunaCoreModule),
        typeof(LunaDapperModule),
        typeof(LunaWebModule),
        typeof(LunaMongoDbModule),
        typeof(LunaRedisAspNetCoreModule),
        typeof(LunaSampleCoreModule),
        typeof(LunaSampleServiceModule)
    )]
    public class LunaSampleWebModule : LunaModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }
    }
}