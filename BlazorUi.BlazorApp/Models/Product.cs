using System.ComponentModel.DataAnnotations;

namespace BlazorUi.BlazorApp.Models;

public class Product(Guid id, string title, string content, string imageUri, double price, ProductCategory category)
{
    [Key] public Guid Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public string ImageUri { get; set; } = imageUri;
    public double Price { get; set; } = price;
    public ProductCategory Category { get; set; } = category;
}

public enum ProductCategory { Male, Female }