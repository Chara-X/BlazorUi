using BlazorUi.BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductsViews;

public partial class ShowProducts
{
    [Parameter] public IEnumerable<Product> Products { get; set; } = default!;
}