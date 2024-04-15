using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductGroupingViews;

public partial class ShowProductGrouping
{
    [Inject] private ShoppingCartService ShoppingCartService { get; set; } = null!;
    [Inject] private GalleryDbContext DbContext{ get; set; } = null!;
    [Parameter] public ProductGrouping ProductGrouping { get; set; } = null!;
    [Parameter] public bool IsReadonly { get; set; }

    private void OnCountChanged(int count)
    {
        ProductGrouping.Count = count;
        ShoppingCartService.Update(ProductGrouping.ProductId, count);
    }

    private void OnRemove() => ShoppingCartService.Remove(ProductGrouping.ProductId);
}