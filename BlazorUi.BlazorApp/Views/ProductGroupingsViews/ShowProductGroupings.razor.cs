using BlazorUi.BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductGroupingsViews;

public partial class ShowProductGroupings
{
    [Parameter] public IEnumerable<ProductGrouping> ProductGroupings { get; set; } = null!;
    [Parameter] public bool IsReadonly { get; set; }
}