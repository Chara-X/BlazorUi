using BlazorUi.ViewProperties;
using Microsoft.AspNetCore.Components;

namespace BlazorUi;

/// <summary>
/// 图形界面的图形界面
/// </summary>
public abstract class ViewView : View
{
    /// <summary>
    /// 图形界面
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// 水平内容对齐
    /// </summary>
    [Parameter]
    public HorizontalAlignment HorizontalContentAlignment { get; set; } = HorizontalAlignment.Stretch;

    /// <summary>
    /// 垂直内容对齐
    /// </summary>
    [Parameter]
    public VerticalAlignment VerticalContentAlignment { get; set; } = VerticalAlignment.Stretch;

    /// <summary>
    /// 填充
    /// </summary>
    [Parameter]
    public Thickness? Padding { get; set; }

    public override string ToString() => base.ToString() + new Style
    {
        Setters = new[]
        {
            ("display", "grid"),
            ("grid-auto-rows", "1fr"),
            ("grid-auto-columns", "1fr"),
            ("justify-items", $"{HorizontalContentAlignment.AsString()}"),
            ("align-items", $"{VerticalContentAlignment.AsString()}"),
        },
        Triggers = new[] { (Padding != null, "padding", $"{Padding}"), }
    };
}