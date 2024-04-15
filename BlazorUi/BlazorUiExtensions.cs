using System.Drawing;

namespace BlazorUi;

public static class BlazorUiExtensions
{
    public static string AsString(this Color color) => $"rgb({color.R}, {color.G}, {color.B}, {color.A})";

    public static bool IsComplex(this Type type) => !type.IsPrimitive && type != typeof(string);
}

public class Style
{
    public IEnumerable<(string property, string value)> Setters { get; set; } = Array.Empty<(string property, string value)>();
    public IEnumerable<(bool condition, string property, string value)> Triggers { get; set; } = Array.Empty<(bool condition, string property, string value)>();

    public override string ToString()
    {
        var style = string.Empty;
        foreach (var (property, value) in Setters)
            style += $"{property}:{value};";
        foreach (var (_, property, value) in Triggers.Where(x => x.condition))
            style += $"{property}:{value};";
        return style;
    }
}