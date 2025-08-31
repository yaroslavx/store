using Store.Api.Data;
using Store.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<GameStoreContext>(builder.Configuration.GetConnectionString("GameStore"));

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();