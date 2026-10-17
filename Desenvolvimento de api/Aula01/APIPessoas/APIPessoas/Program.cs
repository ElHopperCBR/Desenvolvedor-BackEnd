using APIPessoas.Models.Contextos;

var builder = WebApplication.CreateBuilder(args);

//Criação do banco de dados e tabela
ProdutosContexto contexto = new ProdutosContexto();
contexto.Database.EnsureCreated();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
