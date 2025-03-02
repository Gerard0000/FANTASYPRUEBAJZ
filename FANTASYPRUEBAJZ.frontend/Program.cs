using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FANTASYPRUEBAJZ.frontend;
using FANTASYPRUEBAJZ.frontend.Repositories;
using CurrieTechnologies.Razor.SweetAlert2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7129") });
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddLocalization();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();