namespace BlazorUi.ViewProperties;

/// <summary>
/// 网格长度
/// </summary>
public struct GridLength
{
    /// <summary>
    /// 长度
    /// </summary>
    public Length? Length { get; set; } = null;

    /// <summary>
    /// 网格长度类型
    /// </summary>
    public GridLengthType GridLengthType { get; set; }

    public GridLength(double value, LengthUnit lengthUnit)
    {
        Length = new Length(value, lengthUnit);
        GridLengthType = GridLengthType.Manual;
    }

    public GridLength(GridLengthType gridLengthType) => GridLengthType = gridLengthType;
    public GridLength() : this(1, LengthUnit.Weight) { }

    public override string ToString() => GridLengthType switch
    {
        GridLengthType.Manual => Length.ToString()!,
        GridLengthType.Auto => "max-content",
        _ => throw new ArgumentOutOfRangeException()
    };
}

/// <summary>
/// 网格长度类型
/// </summary>
public enum GridLengthType
{
    /// <summary>
    /// 手动长度
    /// </summary>
    Manual,

    /// <summary>
    /// 自动长度
    /// </summary>
    Auto
}