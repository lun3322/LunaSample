using Luna;
using Luna.Dapper;
using Luna.Dependency;
using Luna.MongoDb;
using Luna.Redis.AspNetCore;
using LunaSample.Core;
using Microsoft.Extensions.DependencyInjection;

namespace LunaSample.Service
{
    [Dependency(
        typeof(LunaCoreModule),
        typeof(LunaDapperModule),
        typeof(LunaMongoDbModule),
        typeof(LunaRedisAspNetCoreModule),
        typeof(LunaSampleCoreModule)
    )]
    public class LunaSampleServiceModule : LunaModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }
    }
}