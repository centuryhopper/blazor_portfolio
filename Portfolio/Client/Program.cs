using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Personal_Portfolio.Services;
using Portfolio.Client;
using Portfolio.Interfaces;
using Portfolio.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBlogsDataRepository<BlogModel>, BlogsDataRepository>();

await builder.Build().RunAsync();
