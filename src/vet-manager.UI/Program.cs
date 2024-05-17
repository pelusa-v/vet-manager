using vet_manager.Application;
using vet_manager.DataAccess;
using vet_manager.DataAccess.Seed;
using vet_manager.UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Layers
builder.Services.AddDataAccessLayer(builder.Configuration); 
builder.Services.AddApplicationLayer(builder.Configuration);

var app = builder.Build();


using (var serviceScope = app.Services.CreateScope())
{
    SeedData.Initialize(serviceScope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
