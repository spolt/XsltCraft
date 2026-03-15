using XsltCraft.Application.Interfaces;
using XsltCraft.Application.Services;
using XsltCraft.Infrastructure.DependencyInjection;
using XsltCraft.Infrastructure.Repositories;
using XsltCraft.Infrastructure.Templates;
using XsltCraft.Infrastructure.Xslt;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddXsltCraft();

// CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("dev",
        policy =>
        {
            policy
                   .AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// TEMPLATE DISCOVERY
var discovery = app.Services.GetRequiredService<ITemplateDiscovery>();
var root = Path.Combine(app.Environment.ContentRootPath, "templates");
discovery.Discover(root);

// HOT RELOAD
var reloadService = app.Services.GetRequiredService<TemplateHotReloadService>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();

app.UseCors("dev");
app.MapControllers();

app.Run();