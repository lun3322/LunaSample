using Luna;
using Luna.Dapper;
using Luna.Dependency;
using Luna.MongoDb;
using Luna.Redis.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace LunaSample.Core
{
    [Dependency(
        typeof(LunaCoreModule),
        typeof(LunaDapperModule),
        typeof(LunaMongoDbModule),
        typeof(LunaRedisAspNetCoreModule)
    )]
    public class LunaSampleCoreModule : LunaModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }
    }
}