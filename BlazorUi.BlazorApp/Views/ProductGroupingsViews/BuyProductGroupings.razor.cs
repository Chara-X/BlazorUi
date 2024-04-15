using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductGroupingsViews;

[Route(nameof(BuyProductGroupings))]
public partial class BuyProductGroupings
{
    [Inject] private UserService UserService { get; set; } = null!;
    [Inject] private ShoppingCartService ShoppingCartService { get; set; } = null!;
    [Inject] private GalleryDbContext DbContext { get; set; } = null!;
    public double Price => ShoppingCartService.GetAll().Sum(x => DbContext.Products.Single(y => y.Id == x.ProductId).Price * x.Count);
    protected override void OnInitialized() => ShoppingCartService.Changed += StateHasChanged;

    private void OnBuy()
    {
        var orderId = Guid.NewGuid();
        foreach (var x in ShoppingCartService.GetAll().ToArray())
            DbContext.ProductGroupings.Add(new ProductGrouping(x.ProductId, orderId, x.Count));
        DbContext.Orders.Add(new Order(orderId, ShoppingCartService.Count, Price, UserService.User!.Id));
        ShoppingCartService.Clear();
    }

    public void Dispose() => ShoppingCartService.Changed -= StateHasChanged;
}