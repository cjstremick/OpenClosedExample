using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenClosedExample.Processors;
using OpenClosedExample.Services;

namespace OpenClosedExample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // The move service knows how to perform moves.
            services.AddTransient<IMoveService, MoveService>();

            // Move processors know how to process specific types of moves.  When we register them this way, where
            // we have many processors registered which could resolve to "MoveProcessor", the injector will provide
            // all the processors as an IEnumerable.  To see what this looks like, see the MoveService constructor.
            services.AddTransient<MoveProcessor, JetMoveProcessor>();
            services.AddTransient<MoveProcessor, TrainMoveProcessor>();
            services.AddTransient<MoveProcessor, HorseMoveProcessor>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}