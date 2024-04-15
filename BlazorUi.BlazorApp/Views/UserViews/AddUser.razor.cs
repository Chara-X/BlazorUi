using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.UserViews;

[Route(nameof(AddUser))]
public partial class AddUser
{
    private ValidateForm _form = null!;

    private readonly User _user = new();
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public GalleryDbContext DbContext { get; set; } = null!;

    private void OnAddUser()
    {
        if (DbContext.Users.SingleOrDefault(x => x.Name == _user.Name) != null)
        {
            _form.SetError<User>(x => x.Name, "Username registered : (");
            return;
        }

        DbContext.Users.Add(_user);
        NavigationManager.NavigateTo(nameof(GetUser));
    }
}