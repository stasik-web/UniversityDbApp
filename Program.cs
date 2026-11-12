using Microsoft.EntityFrameworkCore;
using UniversityDbApp.Data;

var builder = WebApplication.CreateBuilder(args);

// DbContext тіркеу: байланыс жолы appsettings.json ішінен алынады
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Дерекқор жұмыс істейтінін тексеру беті: кафедралар және оқытушылар (JSON)
app.MapGet("/", async (AppDbContext db) =>
    await db.Departments
        .Select(d => new
        {
            d.Id,
            d.Name,
            Teachers = d.Teachers.Select(t => new { t.Id, t.FullName, t.Position })
        })
        .ToListAsync());

app.Run();
