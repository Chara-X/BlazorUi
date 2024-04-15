namespace BlazorUi.ViewProperties;

/// <summary>
/// 圆角半径
/// </summary>
public struct CornerRadius
{
    /// <summary>
    /// 上左半径
    /// </summary>
    public double TopLeft { get; set; }

    /// <summary>
    /// 上右半径
    /// </summary>
    public double TopRight { get; set; }

    /// <summary>
    /// 下左半径
    /// </summary>
    public double BottomLeft { get; set; }

    /// <summary>
    /// 下右半径
    /// </summary>
    public double BottomRight { get; set; }

    public CornerRadius(double topLeft, double topRight, double bottomLeft, double bottomRight)
    {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
    }

    public CornerRadius(double uniformRadius) : this(uniformRadius, uniformRadius, uniformRadius, uniformRadius) { }
    public override string ToString() => $"{TopLeft}px {TopRight}px {BottomRight}px {BottomLeft}px";
}