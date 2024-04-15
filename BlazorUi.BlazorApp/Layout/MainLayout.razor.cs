using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Layout;

public partial class MainLayout
{
    [Inject] private UserService UserService { get; set; } = null!;
    [Inject] private ShoppingCartService ShoppingCartService { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;

    protected override void OnInitialized()
    {
        UserService.Changed += StateHasChanged;
        ShoppingCartService.Changed += StateHasChanged;
    }

    public void Dispose()
    {
        UserService.Changed += StateHasChanged;
        ShoppingCartService.Changed -= StateHasChanged;
    }
}