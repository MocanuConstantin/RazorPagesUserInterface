using Microsoft.EntityFrameworkCore;   
using RazorPagesUserInterface.Models;

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapRazorPages();

app.Run();