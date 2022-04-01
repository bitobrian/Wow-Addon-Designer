using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Bitobrian.Wow.Addon.IDE;
using Bitobrian.Wow.Addon.IDE.Data.Services;
using Bitobrian.Wow.Addon.IDE.Data.ViewModels;
using BlazorStrap;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddBlazorStrap();
builder.Services.AddSingleton<DraggableViewModel>();
builder.Services
    .AddSingleton<MouseService>()
    .AddSingleton<IMouseService>(serviceProvider => serviceProvider.GetRequiredService<MouseService>());

await builder.Build().RunAsync();