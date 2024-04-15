using System.Drawing;

namespace BlazorUi.ViewProperties;

/// <summary>
/// 边框
/// </summary>
public struct Border
{
    /// <summary>
    /// 边框厚度
    /// </summary>
    public double Thickness { get; set; }

    /// <summary>
    /// 边框颜色
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// 边框样式
    /// </summary>
    public BorderStyle Style { get; set; }

    /// <summary>
    /// 圆角半径
    /// </summary>
    public CornerRadius CornerRadius { get; set; }

    public Border(double thickness, Color color, BorderStyle style, CornerRadius cornerRadius)
    {
        Thickness = thickness;
        Color = color;
        Style = style;
        CornerRadius = cornerRadius;
    }

    public Border(double thickness, Color color, BorderStyle style) : this(thickness, color, style, new CornerRadius()) { }
    public Border(double thickness, Color color) : this(thickness, color, BorderStyle.Solid, new CornerRadius()) { }
    public override string ToString() => $"{Thickness}px {Style} {Color.AsString()}";
}

/// <summary>
/// 边框样式
/// </summary>
public enum BorderStyle
{
    /// <summary>
    /// 实线边框
    /// </summary>
    Solid,

    /// <summary>
    /// 虚线边框
    /// </summary>
    Dashed,

    /// <summary>
    /// 点线边框
    /// </summary>
    Dotted,

    /// <summary>
    /// 双线边框
    /// </summary>
    Double
}