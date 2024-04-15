using BlazorUi.ViewProperties;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.ViewsViews;

public partial class StackPanel
{
    /// <summary>
    /// 方向
    /// </summary>
    [Parameter] public Direction Direction { get; set; } = Direction.Top;
}