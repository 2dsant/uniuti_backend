using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using UniUti.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using UniUti.Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using UniUti.Application.Services;
using UniUti.Infra.Data.Identity;
using Microsoft.AspNetCore.Http;
using UniUti.Domain.Interfaces;
using UniUti.Database;
using UniUti.Config;
using AutoMapper;

namespace UniUti.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer("Server=tcp:uniuti.database.windows.net,1433;Initial Catalog=uniutidatabase;Persist Security Info=False;User ID=uniuti;Password=65A$T<!\\;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;"), 
                ServiceLifetime.Transient);


            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IInstituicaoRepository, InstituicaoRepository>();
            services.AddScoped<IMonitoriaRepository, MonitoriaRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<IDisciplinaService, DisciplinaService>();
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IMonitoriaService, MonitoriaService>();
            services.AddScoped<IInstituicaoService, InstituicaoService>();
            services.AddScoped<IAuthenticateRepository, AuthenticateRepository>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<ILogService, LogService>();
            return services;
        }
    }
}
