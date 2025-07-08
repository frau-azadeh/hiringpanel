using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// کانفیگ DbContext با SQLite
builder.Services.AddDbContext<HiringPanelDbContext>(options =>
    options.UseSqlite("Data Source=hiringpanel.db"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// حذف لیست محلی applicants

// GET همه متقاضی‌ها از دیتابیس
app.MapGet("/api/applicants", async (HiringPanelDbContext db) =>
{
    var result = await db.Applicants.ToListAsync();
    return Results.Ok(result);
});

// POST متقاضی جدید به دیتابیس
app.MapPost("/api/applicants", async (Applicant applicant, HiringPanelDbContext db) =>
{
    db.Applicants.Add(applicant);
    await db.SaveChangesAsync();
    return Results.Ok(applicant);
});

app.Run();


