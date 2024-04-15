using BlazorUi.BlazorApp.Models;
using BlazorUi.BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views.ProductsViews;

[Route(nameof(GetProducts))]
public partial class GetProducts
{
    private int _pageCount;

    private IEnumerable<Product>? _products;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public GalleryDbContext DbContext { get; set; } = null!;
    [Parameter, SupplyParameterFromQuery] public string? Keyword { get; set; }
    [Parameter, SupplyParameterFromQuery] public string? Category { get; set; }
    [Parameter, SupplyParameterFromQuery] public int Page { get; set; }

    protected override async Task OnParametersSetAsync() =>
        await Task.Run(() =>
        {
            _products = DbContext.Products.Where(x => (string.IsNullOrEmpty(Keyword) || x.Title.Contains(Keyword) || x.Content.Contains(Keyword)) && (string.IsNullOrEmpty(Category) || x.Category.ToString() == Category)).ToArray();
            _pageCount = (int)Math.Ceiling(_products.Count() / 2f);
            _products = _products.Skip(Page * 2).Take(2).ToArray();
        });

    private void OnGetProducts() => NavigationManager.NavigateTo($"{nameof(GetProducts)}?{nameof(Keyword)}={Keyword}&{nameof(Category)}={Category}&{nameof(Page)}={Page}");
}