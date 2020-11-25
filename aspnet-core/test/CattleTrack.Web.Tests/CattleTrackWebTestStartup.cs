﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace CattleTrack
{
    public class CattleTrackWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<CattleTrackWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}