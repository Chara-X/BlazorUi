using System.Security.Claims;
using BlazorUi.BlazorApp.Models;

namespace BlazorUi.BlazorApp.Extensions;

public static class BlazorAppExtensions
{
    public static ClaimsPrincipal ToClaimsPrincipal(this User user) => new(new ClaimsIdentity(new Claim[]
    {
        new(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new(ClaimTypes.Name, user.Name),
        new(ClaimTypes.Hash, user.Password)
    }, "CustomAuthenticationType"));
}