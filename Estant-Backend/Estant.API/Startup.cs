using Estant.Core.Handlers;
using Estant.Material;
using Estant.Service.FirebaseService;
using Estant.Service.Interface;
using Estant.Service.LocalDataService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Config Constants
            ConfigConstants.JwtKey = Configuration["JwtConfig:Key"];
            ConfigConstants.JwtIssuer = Configuration["JwtConfig:Issuer"];
            ConfigConstants.ApiKey = Configuration["FirebaseConfig:ApiKey"];
            ConfigConstants.ProjectID = Configuration["FirebaseConfig:ProjectID"];
            ConfigConstants.PrivateKeyPath = Configuration["FirebaseConfig:PrivateKeyPath"];
            #endregion

            //add authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtOptions =>
            {
                jwtOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = ConfigConstants.JwtIssuer,
                    ValidAudience = ConfigConstants.JwtIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigConstants.JwtKey))
                };
            });

            services.AddControllers();


            #region DI - Dependency Injection
            services.AddSingleton<AuthHandler>();
            services.AddSingleton<VocabularyHandler>();
            services.AddSingleton<GrammarHandler>();
            services.AddSingleton<NewsHandler>();
            services.AddSingleton<UserHandler>();

            services.AddSingleton<IAuthenticationService, AuthFirebaseService>();
            services.AddSingleton<IUserService, UserFirestoreService>();
            services.AddSingleton<ITopicService, TopicFirestoreService>();
            services.AddSingleton<IVocabularyService, VocabularyFirestoreService>();
            services.AddSingleton<IGrammarService, LocalGrammarService>();
            #endregion

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Estant API",
                    Version = "1.0",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Estant API V1.0");
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
