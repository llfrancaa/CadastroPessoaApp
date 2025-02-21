using Microsoft.EntityFrameworkCore;
using CadastroPessoaApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
var connectionString = builder.Configuration.GetConnectionString("Conexao");
builder.Services.AddDbContext<Contexto>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Adicionar serviços MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurações padrão para ambiente de desenvolvimento
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pessoas}/{action=Index}/{id?}");

app.Run();