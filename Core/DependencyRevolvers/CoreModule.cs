using Core.CrossCuttingCorcerns.Caching;
using Core.CrossCuttingCorcerns.Caching.Microsoft;
using Core.Utilitiess.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyRevolvers
{
    //Uygulamadaki service bagımlılıklarını çözümleyecegiz.
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();//_memoryCache'in çalışabilmesi için
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();

        }
    }
}
