using Portfolio.Server.Contexts;
using Portfolio.Server.Interfaces;
using Portfolio.Server.Repository;
using Portfolio.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// TODO: you shouldn't be pushing connection string to github but im doing it anyway for simplicity's sake

// TODO: create more tables for other navbar selections like blogs, skills, and projects

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddSingleton<DapperContext>();
// blogs should definitely be singleton or else the individual blog id's will change everytime
builder.Services.AddSingleton<IBlogsDataRepository<BlogModel>, BlogsDataRepository>();
builder.Services.AddSingleton<IProjectsDataRepository<ProjectCardModel>, ProjectsDataRepository>();
builder.Services.AddScoped<IContactsDataRepository<ContactMeModel>, ContactsDataRepository>();

string BlazorClientPolicy = "AllowAllOrigins";

builder.Services.AddCors(options => {
    options.AddPolicy(BlazorClientPolicy, builder => {
        builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UsePathBase("/");
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
