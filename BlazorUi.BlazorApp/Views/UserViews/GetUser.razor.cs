using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.UserViews;

[Route(nameof(GetUser))]
public partial class GetUser
{
    private ValidateForm _form = null!;

    private readonly User _user = new();
    [Inject] private UserService UserService { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;
    [Inject] private GalleryDbContext DbContext { get; set; } = null!;
    [Parameter, SupplyParameterFromQuery] public string? ReturnUrl { get; set; }

    private void OnGetUser()
    {
        var user = DbContext.Users.SingleOrDefault(x => x.Name == _user.Name);
        if (user == null || user.Password != _user.Password)
        {
            _form.SetError<User>(x => x.Name, "Username or Password error : (");
            return;
        }

        UserService.User = user;
        NavigationManager.NavigateTo(ReturnUrl ?? string.Empty);
    }
}