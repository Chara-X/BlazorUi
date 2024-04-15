using Blazored.LocalStorage;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorUi.BlazorApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddBlazoredLocalStorage();
        builder.Services.AddBootstrapBlazor();
        builder.Services.AddScoped<UserService>();
        builder.Services.AddScoped<ShoppingCartService>();
        builder.Services.AddScoped<GalleryDbContext>();
        builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddOptions();
        builder.Services.AddAuthorizationCore(_ => { });
        builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

        await builder.Build().RunAsync();
    }
}