using Microsoft.AspNetCore.Components;

namespace BlazorUi;

/// <summary>
/// 图形界面集合的图形界面
/// </summary>
public abstract class ViewsView : View
{
    /// <summary>
    /// 数组 `图形界面`
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}