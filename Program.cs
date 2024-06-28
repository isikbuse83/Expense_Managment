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

//connection string i tekrar tekrar yazmamak i�in adddb context ile appsettings deki connection stringim�zi tan�mlad�k

builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//reporsitories leri tek bir nesne ad� alt�nda toparlamak i�in ve transection lar� tek bir yerden y�netmek i�in unitofork olu�tu�rduk.ve 
//unit od work ba��ml�l���n� y�netmek i�in scoped iile servislere ekledik.

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
