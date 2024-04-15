namespace BlazorUi.ViewProperties;

/// <summary>
/// 水平对齐
/// </summary>
public enum HorizontalAlignment
{
    /// <summary>
    /// 向左
    /// </summary>
    Left,

    /// <summary>
    /// 向右
    /// </summary>
    Right,

    /// <summary>
    /// 居中
    /// </summary>
    Center,

    /// <summary>
    /// 拉伸
    /// </summary>
    Stretch
}

public static class HorizontalAlignmentExtensions
{
    public static string AsString(this HorizontalAlignment horizontalAlignment) =>
        horizontalAlignment switch
        {
            HorizontalAlignment.Left => "start",
            HorizontalAlignment.Right => "end",
            HorizontalAlignment.Center => "center",
            HorizontalAlignment.Stretch => "stretch",
            _ => throw new ArgumentOutOfRangeException()
        };
}