using Jcf.AM.Control.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(builder.Configuration.GetSection("EnvironmentName").Value);

builder.Services.AddDatabaseConfiguration(builder.Configuration, builder.Environment);
builder.Services.AddAuthenticationConfiguration(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddCustomServices();
builder.Services.AddCustomOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi("v1");

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthentication();

app.MapControllers();
app.MapOpenApi();

app.Run();
