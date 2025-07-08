using HiringPanel.Razor.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// اضافه کردن EF Core با SQLite
builder.Services.AddDbContext<HiringPanelDbContext>(options =>
    options.UseSqlite("Data Source=applicants.db"));

// اضافه کردن Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
