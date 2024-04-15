namespace BlazorUi.ViewProperties;

/// <summary>
/// 垂直对齐
/// </summary>
public enum VerticalAlignment
{
    /// <summary>
    /// 向上
    /// </summary>
    Top,

    /// <summary>
    /// 向下
    /// </summary>
    Bottom,

    /// <summary>
    /// 居中
    /// </summary>
    Center,

    /// <summary>
    /// 拉伸
    /// </summary>
    Stretch
}

public static class VerticalAlignmentExtensions
{
    public static string AsString(this VerticalAlignment verticalAlignment) =>
        verticalAlignment switch
        {
            VerticalAlignment.Top => "start",
            VerticalAlignment.Bottom => "end",
            VerticalAlignment.Center => "center",
            VerticalAlignment.Stretch => "stretch",
            _ => throw new ArgumentOutOfRangeException()
        };
}