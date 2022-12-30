using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Project.Infra.RepositoryAsync;
using WebApi.EF;
using WebApi.Middleware;
using WebApi.Repository;
using WebApi.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
var connectionMysql = builder.Configuration.GetConnectionString("ConnectionMysql");

builder.Services.AddDbContext<MyContext>(x => x.UseMySql(connectionMysql, ServerVersion.Parse("8.0.30-mysql")));


builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUnitOfWorkAsync, UnitOfWorkAsync>();
builder.Services.AddTransient<IFuncionarioService, FuncionarioService>();

builder.Services.AddControllers(options => options.RespectBrowserAcceptHeader = true)
    .AddJsonOptions(jsonOpt => jsonOpt.JsonSerializerOptions.PropertyNamingPolicy = null)
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<GlobalErrorHandling>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();