using Expense_Managment.configuration;
using Expense_Managment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//connection string i tekrar tekrar yazmamak için adddb context ile appsettings deki connection stringimþzi tanýmladýk

builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//reporsitories leri tek bir nesne adý altýnda toparlamak için ve transection larý tek bir yerden yönetmek için unitofork oluþtuýrduk.ve 
//unit od work baðýmlýlýðýný yönetmek için scoped iile servislere ekledik.

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
