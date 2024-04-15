using System.ComponentModel.DataAnnotations;

namespace BlazorUi.BlazorApp.Models;

public class User(Guid id, string name, string password)
{
    [Key] public Guid Id { get; set; } = id;
    [Required] public string Name { get; set; } = name;
    [Required, MinLength(3)] public string Password { get; set; } = password;

    public User() : this(Guid.NewGuid(), string.Empty, string.Empty) { }
}