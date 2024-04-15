using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorUi.BlazorApp.Models;

public class ProductGrouping(Guid productId, Guid orderId, int count)
{
    [Key, ForeignKey(nameof(Product))] public Guid ProductId { get; set; } = productId;
    [Key, ForeignKey(nameof(Order))] public Guid OrderId { get; set; } = orderId;
    public int Count { get; set; } = count;
}