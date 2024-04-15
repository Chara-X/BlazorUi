using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorUi.BlazorApp.Models;

public class Order(Guid id, int count, double price, Guid userId)
{
    [Key] public Guid Id { get; set; } = id;
    public DateTime CreateTime { get; set; } = DateTime.Now;
    public int Count { get; set; } = count;
    public double Price { get; set; } = price;
    [ForeignKey(nameof(User))] public Guid UserId { get; set; } = userId;
}