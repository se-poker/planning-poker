using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using poker_backend.Hubs;

namespace poker_backend
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(builder => builder
                    .WithOrigins("http://poker-frontend.local:8080")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            }

            if (env.IsProduction())
            {
                app.UseCors(builder => builder
                    .WithOrigins("https://planning-poker-se.netlify.app")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            }
            

            app.UseRouting();

            app.UseWebSockets(webSocketOptions());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<GameHub>("/game");

                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }

        private WebSocketOptions webSocketOptions()
        {
            var options = new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromSeconds(120)
            };
            options.AllowedOrigins.Add("http://poker-backend.local:5000");
            options.AllowedOrigins.Add("https://poker-backend.local:5001");
            options.AllowedOrigins.Add("http://poker-frontend.local:8080");
            options.AllowedOrigins.Add("https://planning-poker-se.netlify.app");
            return options;
        }
    }
}