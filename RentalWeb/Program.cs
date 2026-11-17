using Microsoft.EntityFrameworkCore;
using RentalWeb.Components;
using RentalWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContextFactory<RentalDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("Rental")
        ?? throw new InvalidOperationException("Connection string 'Rental' is missing from configuration.")));

var app = builder.Build();

// dotnet run -- import-legacy <path to HOUSE.mdf>
if (args is ["import-legacy", var mdfPath])
{
    await using var db = await app.Services.GetRequiredService<IDbContextFactory<RentalDbContext>>().CreateDbContextAsync();
    return await LegacyImport.RunAsync(db, mdfPath);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
return 0;
