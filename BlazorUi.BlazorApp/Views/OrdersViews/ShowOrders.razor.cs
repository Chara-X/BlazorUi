using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.OrdersViews;

[Route(nameof(ShowOrders))]
public partial class ShowOrders
{
    private IEnumerable<Order>? _orders;
    [Inject] private UserService UserService { get; set; } = null!;
    [Inject] private GalleryDbContext DbContext { get; set; } = null!;
    protected override void OnInitialized() => _orders = DbContext.Orders.Where(x => x.UserId == UserService.User!.Id);
    private IEnumerable<Product> GetProducts(Order order) => DbContext.ProductGroupings.Where(x => x.OrderId == order.Id).Select(x => DbContext.Products.Single(y => y.Id == x.ProductId));
}