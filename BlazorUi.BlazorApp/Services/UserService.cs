using System.Security.Claims;
using Blazored.LocalStorage;
using BlazorUi.BlazorApp.Extensions;
using BlazorUi.BlazorApp.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorUi.BlazorApp.Services;

public class UserService
{
    private const string Key = "User";

    private User? _user;

    private readonly ISyncLocalStorageService _localStorage;

    public event Action? Changed;

    public UserService(ISyncLocalStorageService localStorage)
    {
        _localStorage = localStorage;
        Changed += () => _user = _localStorage.ContainKey(Key) ? _localStorage.GetItem<User>(Key) : null;
    }

    public User? User
    {
        get
        {
            if (_user != null)
                return _user;
            _user = _localStorage.ContainKey(Key) ? _localStorage.GetItem<User>(Key) : null;
            return _user;
        }
        set
        {
            _localStorage.SetItem(Key, value);
            Changed?.Invoke();
        }
    }

    public void Clear()
    {
        _localStorage.RemoveItem(Key);
        Changed?.Invoke();
    }
}

public class CustomAuthenticationStateProvider : AuthenticationStateProvider, IDisposable
{
    private readonly UserService _userService;

    private readonly Action _changed;

    public CustomAuthenticationStateProvider(UserService userService)
    {
        _userService = userService;
        _changed = () => NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        _userService.Changed += _changed;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(new AuthenticationState(_userService.User?.ToClaimsPrincipal() ?? new ClaimsPrincipal()));

    public void Dispose() => _userService.Changed -= _changed;
}