using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductViews;

[Route(nameof(BuyProduct))]
public partial class BuyProduct
{
    private Product? _product;
    [Inject] private ShoppingCartService ShoppingCartService { get; set; } = null!;
    [Inject] public GalleryDbContext DbContext { get; set; } = null!;
    [Parameter,SupplyParameterFromQuery] public Guid ProductId { get; set; }
    protected override void OnParametersSet() => _product = DbContext.Products.SingleOrDefault(x => x.Id == ProductId);
    private void OnBuy() => ShoppingCartService.Add(_product!);
}