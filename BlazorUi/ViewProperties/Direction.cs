namespace BlazorUi.ViewProperties;

/// <summary>
/// 方向
/// </summary>
public enum Direction
{
    /// <summary>
    /// 向左
    /// </summary>
    Left,

    /// <summary>
    /// 向上
    /// </summary>
    Top,

    /// <summary>
    /// 向右
    /// </summary>
    Right,

    /// <summary>
    /// 向下
    /// </summary>
    Bottom
}

public static class DirectionExtensions
{
    public static string AsString(this Direction direction) =>
        direction switch
        {
            Direction.Left => "row",
            Direction.Top => "column",
            Direction.Right => "row-reverse",
            Direction.Bottom => "column-reverse",
            _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
        };
}