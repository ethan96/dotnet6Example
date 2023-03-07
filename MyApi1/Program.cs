using MyApi1.Service;
using MyApi1.Models;
using MyApi1.Middlewares;
using System.Reflection;
using MediatR;
using MyApi1.Exceptions;
using Serilog;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Serilog.Events;
using Microsoft.AspNetCore.Authentication.Cookies;

Log.Logger = new LoggerConfiguration()
.MinimumLevel.Verbose()
.MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Information)
.Enrich.FromLogContext()
.WriteTo.Console()
.CreateLogger();

var builder = WebApplication.CreateBuilder(args);

//Chapter 17 Serilog
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddScoped<ITestService, TestService>();

builder.Services.AddTransient<Mes3Context>();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services(System.Reflection.Assembly.GetExecutingAssembly());

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(
        builder => {
            builder.WithOrigins("http://localhost:5001", "https://localhost:7168")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
        }
    );
});

builder.Services.AddControllers(options =>
{
    options.Filters.Add<HttpResponseExceptionFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Test API",
        Description = "Test API Document",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Example contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Example license",
            Url = new Uri("https://example.com/license")
        }
    });
    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
});

//Chapter 22 Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options => builder.Configuration.Bind("JwtSetttings", options))
.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options => builder.Configuration.Bind("CookieSettings", options));

var app = builder.Build();

//app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI(options => {
    //     options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    //     options.RoutePrefix = string.Empty;
    // });

    //Chaper 15 Exception sample 1
    //app.UseExceptionHandler("/error");

    //Chaper 15 Exception sample 2
    // app.UseExceptionHandler(exceptionHandlerApp => {
    //     exceptionHandlerApp.Run(async context =>
    //     {
    //         context.Response.StatusCode = StatusCodes.Status500InternalServerError;

    //         context.Response.ContentType = "application/json";

    //         await context.Response.WriteAsJsonAsync(Newtonsoft.Json.JsonConvert.SerializeObject(new { Msg = "Error msg" }));
    //     });
    // });
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

//Cust middleware practice
// app.UseCustom();
// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Run" + Environment.NewLine);
// });

//app.MapGet("/", () => "Hello World");

app.Run();
Log.CloseAndFlush();