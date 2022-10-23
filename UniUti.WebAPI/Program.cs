using Microsoft.AspNetCore.HttpOverrides;
using UniUti.Infra.IoC;
using UniUti.WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//string mySqlConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<ApplicationDbContext>
//(options => options.UseMySql(
//    mySqlConnectionString,
//    ServerVersion.AutoDetect(mySqlConnectionString))
//);

//IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

//builder.Services.AddSingleton(mapper);
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddScoped<IAuthRepository, AuthRepository>();
//builder.Services.AddScoped<IInstituicaoRepository, InstituicaoRepository>();
//builder.Services.AddScoped<IMonitoriaRepository, MonitoriaRepository>();
//builder.Services.AddScoped<ICursoRepository, CursoRepository>();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddInfrastructureJWT(builder.Configuration);
builder.Services.AddInfrastructureSwagger();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ApiLoggingFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseRouting();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
