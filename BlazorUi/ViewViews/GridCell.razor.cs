using Microsoft.AspNetCore.Components;

namespace BlazorUi.ViewViews;

public partial class GridCell
{
    /// <summary>
    /// 行标
    /// </summary>
    [Parameter]
    public uint Row { get; set; }

    /// <summary>
    /// 列标
    /// </summary>
    [Parameter]
    public uint Column { get; set; }

    /// <summary>
    /// 跨行
    /// </summary>
    [Parameter]
    public uint RowSpan { get; set; } = 1;

    /// <summary>
    /// 跨列
    /// </summary>
    [Parameter]
    public uint ColumnSpan { get; set; } = 1;
}