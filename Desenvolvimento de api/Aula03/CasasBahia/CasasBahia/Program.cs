using CasasBahia.Classes.Models.Contextos;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Conectar banco de dados
ContextoLogin contexto = new ContextoLogin();
contexto.Database.EnsureCreated();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
    opcoes.SwaggerDoc("versao1", new Microsoft.OpenApi.OpenApiInfo
        {
            Title = "API para as lojas casas bahia",
            Version = "v1",
            Description = "API didática para realizar operações CRUD em banco de dados SQL, use os endpoints (rotas) para listar, criar, atualizar e excluir usuarios, produtos e vendas"

        }

    )    
);
builder.Services.AddSwaggerGen(opcoes =>
    {
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlCaminho = Path.Combine(AppContext.BaseDirectory, xmlFile);
        opcoes.IncludeXmlComments(xmlCaminho);
        
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //SWAGGER
    app.UseSwagger();
    app.UseSwaggerUI( c =>
            {
                c.SwaggerEndpoint("/swagger/versao1/swagger.json", "API lojas casas bahia");
                c.DocumentTitle = "Documentação da API didática casas bahia";

            }
        );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
