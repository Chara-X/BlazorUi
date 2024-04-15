using Microsoft.AspNetCore.Components;

namespace BlazorUi.BlazorApp.Views;

public abstract class ViewConstructor<T> : OwningComponentBase
{
    [Parameter] public T Viewmodel { get; set; } = default!;

    protected override void OnInitialized() => Viewmodel ??= ScopedServices.GetService<T>()!;
}