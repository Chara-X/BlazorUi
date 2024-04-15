namespace BlazorUi.ViewProperties;

/// <summary>
/// 长度
/// </summary>
public struct Length
{
    /// <summary>
    /// 长度数值
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// 长度单位
    /// </summary>
    public LengthUnit LengthUnit { get; set; }

    public Length(double value, LengthUnit lengthUnit)
    {
        Value = value;
        LengthUnit = lengthUnit;
    }

    public override string ToString() => LengthUnit switch
    {
        LengthUnit.Pixel => $"{Value}px",
        LengthUnit.Percentage => $"{Value}%",
        LengthUnit.Weight => $"{Value}fr",
        _ => throw new ArgumentOutOfRangeException()
    };
}

/// <summary>
/// 长度单位
/// </summary>
public enum LengthUnit
{
    /// <summary>
    /// 像素单位
    /// </summary>
    Pixel,

    /// <summary>
    /// 比例单位
    /// </summary>
    Percentage,

    /// <summary>
    /// 权重单位
    /// </summary>
    Weight
}