using System.Drawing;
using BlazorUi.ViewProperties;
using Microsoft.AspNetCore.Components;

namespace BlazorUi;

public abstract partial class View : ComponentBase
{
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object>? AdditionAttributes { get; set; }
    /// <summary>
    /// 样式
    /// </summary>
    [Parameter] public Action<View>? Style { get; set; }
    protected override void OnParametersSet() => Style?.Invoke(this);
}
/// <summary>
/// 图形界面
/// </summary>
public abstract partial class View
{
    /// <summary>
    /// 高度
    /// </summary>
    [Parameter] public double? Height { get; set; }
    /// <summary>
    /// 宽度
    /// </summary>
    [Parameter] public double? Width { get; set; }
    /// <summary>
    /// 背景
    /// </summary>
    [Parameter] public Color? BackgroundColor { get; set; }
    /// <summary>
    /// 能见度
    /// </summary>
    [Parameter] public Visibility? Visibility { get; set; }
    /// <summary>
    /// 边框
    /// </summary>
    [Parameter] public Border? Border { get; set; }

    public override string ToString() => new Style
    {
        Setters = new[] { ("overflow", "auto") },
        Triggers = new[]
        {
            (Height != null, "height", $"{Height}px"),
            (Width != null, "width", $"{Width}px"),
            (BackgroundColor != null, "background-color", $"{BackgroundColor?.AsString()}"),
            (Visibility != null, "visibility", $"{Visibility}"),
            (Border != null, "border", $"{Border}"),
            (Border?.CornerRadius != null, "border-radius", $"{Border?.CornerRadius}"),
        },
    }.ToString();
}

/// <summary>
/// 数据的图形界面
/// </summary>
/// <typeparam name="T">数据的类型</typeparam>
public abstract class View<T> : View
{
    /// <summary>
    /// 数据内容
    /// </summary>
    [Parameter]
    public T? Value { get; set; }

    /// <summary>
    /// 字体颜色
    /// </summary>
    [Parameter]
    public Color? FontColor { get; set; }

    /// <summary>
    /// 字体大小
    /// </summary>
    [Parameter]
    public double? FontSize { get; set; }

    /// <summary>
    /// 字体粗细
    /// </summary>
    [Parameter]
    public double? FontWeight { get; set; }

    public override string ToString() => base.ToString() + new Style
    {
        Triggers = new[]
        {
            (FontColor != null, "color", $"{FontColor?.AsString()}"),
            (FontSize != null, "font-size", $"{FontSize}px"),
            (FontWeight != null, "font-weight", $"{FontWeight}00"),
        }
    };
}