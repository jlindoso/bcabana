using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using business.Context;
using business.Model.Services;
using business.Model.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using business.Model.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<CabanaContext>(optionsAction: 
    opt=>opt.UseNpgsql("User ID =timvyrhkevxieb;Password=d5695b961299c5dc365e2e2f50e0ba67ad317f649163407a9163e19b01dfa703;Server=ec2-3-224-164-189.compute-1.amazonaws.com;Port=5432;Database=d12gvl6so6hahr;Integrated Security=true;Pooling=true;"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IProdutoService,ProdutoService>();
builder.Services.AddScoped<IUsuarioService,UsuarioService>();
builder.Services.AddScoped<ICaixaService,CaixaService>();
builder.Services.AddScoped<IEmpresaService,EmpresaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseAuthentication();
    app.UseAuthorization();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
