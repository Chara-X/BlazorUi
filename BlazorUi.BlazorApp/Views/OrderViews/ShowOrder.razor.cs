using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.OrderViews;

[Route(nameof(ShowOrder))]
public partial class ShowOrder
{
    private Order? _order;
    [Inject] public GalleryDbContext DbContext { get; set; } = null!;
    [Parameter, SupplyParameterFromQuery] public Guid OrderId { get; set; }
    protected override void OnInitialized() => _order = DbContext.Orders.SingleOrDefault(x => x.Id == OrderId);
}