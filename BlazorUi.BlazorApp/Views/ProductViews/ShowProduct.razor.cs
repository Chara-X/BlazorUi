using BlazorUi.BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductViews;

public partial class ShowProduct
{
    [Parameter] public Product Product { get; set; } = null!;
}