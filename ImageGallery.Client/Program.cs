using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews()
    .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

// create an HttpClient used for accessing the API
builder.Services.AddHttpClient("APIClient", client =>
    {
        client.BaseAddress = new Uri("https://localhost:44366/");
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Shared/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Gallery}/{action=Index}/{id?}");
});


app.Run();
