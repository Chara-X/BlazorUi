namespace BlazorUi.ViewProperties;

/// <summary>
/// 厚度
/// </summary>
public struct Thickness
{
    /// <summary>
    /// 左边厚度
    /// </summary>
    public double Left { get; set; }

    /// <summary>
    /// 上边厚度
    /// </summary>
    public double Top { get; set; }

    /// <summary>
    /// 右边厚度
    /// </summary>
    public double Right { get; set; }

    /// <summary>
    /// 下边厚度
    /// </summary>
    public double Bottom { get; set; }

    public Thickness(double left, double top, double right, double bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    public Thickness(double horizontalThickness, double verticalThickness) : this(horizontalThickness, verticalThickness, horizontalThickness, verticalThickness) { }
    public Thickness(double uniformThickness) : this(uniformThickness, uniformThickness, uniformThickness, uniformThickness) { }
    public override string ToString() => $"{Top}px {Right}px {Bottom}px {Left}px";
}