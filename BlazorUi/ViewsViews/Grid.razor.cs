using BlazorUi.ViewProperties;
using Microsoft.AspNetCore.Components;

namespace BlazorUi.ViewsViews;

public partial class Grid
{
    /// <summary>
    /// 数组 `行高`
    /// </summary>
    [Parameter]
    public IEnumerable<GridLength>? RowDefinitions { get; set; }

    /// <summary>
    /// 数组 `列高`
    /// </summary>
    [Parameter]
    public IEnumerable<GridLength>? ColumnDefinitions { get; set; }
}
