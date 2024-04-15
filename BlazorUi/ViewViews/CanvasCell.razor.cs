using Microsoft.AspNetCore.Components;

namespace BlazorUi.ViewViews;

public partial class CanvasCell
{
    /// <summary>
    /// 左偏
    /// </summary>
    [Parameter]
    public double? Left { get; set; }

    /// <summary>
    /// 上偏
    /// </summary>
    [Parameter]
    public double? Top { get; set; }

    /// <summary>
    /// 右偏
    /// </summary>
    [Parameter]
    public double? Right { get; set; }

    /// <summary>
    /// 下偏
    /// </summary>
    [Parameter]
    public double? Bottom { get; set; }
}