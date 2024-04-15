using BlazorUi.BlazorApp.Models;

namespace BlazorUi.BlazorApp.Services;

public class ShoppingCartService(UserService userService, GalleryDbContext dbContext)
{
    public event Action? Changed;

    public int Count => dbContext.ProductGroupings.Where(x => x.OrderId == userService.User!.Id).Sum(x => x.Count);

    public void Add(Product product)
    {
        var productGrouping = dbContext.ProductGroupings.Where(x => x.OrderId == userService.User!.Id).SingleOrDefault(x => x.ProductId == product.Id);
        if (productGrouping == null)
            dbContext.ProductGroupings.Add(new ProductGrouping(product.Id, userService.User!.Id, 1));
        else
            productGrouping.Count++;
        Changed?.Invoke();
    }

    public void Remove(Guid key)
    {
        dbContext.ProductGroupings.Remove(dbContext.ProductGroupings.Single(x => x.OrderId == userService.User!.Id && x.ProductId == key));
        Changed?.Invoke();
    }

    public void Clear()
    {
        dbContext.ProductGroupings.RemoveAll(x => x.OrderId == userService.User!.Id);
        Changed?.Invoke();
    }

    public void Update(Guid key, int value)
    {
        dbContext.ProductGroupings.Single(x => x.OrderId == userService.User!.Id && x.ProductId == key).Count = value;
        Changed?.Invoke();
    }

    public IEnumerable<ProductGrouping> GetAll() => dbContext.ProductGroupings.Where(x => x.OrderId == userService.User!.Id);
}