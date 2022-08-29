using HungryPizza.API;
using HungryPizza.API.EndPoints;
using HungryPizza.Service;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Hungry Pizza",
        Description = "API para manter e registrar pedidos e clientes."
    });

});




#region DIServiceAndPersistence
builder.Services.AddDependencyInjection(builder.Configuration);
builder.Services.AddServiceModule();
#endregion DIServiceAndPersistence

var app = builder.Build();

#region AddEndPoints
app.AddOrderEndpoints();
app.AddClientEndpoints();
#endregion #region AddEndPoints

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
