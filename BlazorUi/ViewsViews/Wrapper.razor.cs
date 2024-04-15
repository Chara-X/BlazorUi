using BlazorUi.ViewProperties;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.ViewsViews;

public partial class Wrapper
{
    /// <summary>
    /// 方向
    /// </summary>
    [Parameter]
    public Direction Direction { get; set; } = Direction.Left;
}