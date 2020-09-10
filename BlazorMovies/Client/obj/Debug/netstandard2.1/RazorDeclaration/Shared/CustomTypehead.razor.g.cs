#pragma checksum "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Shared\CustomTypehead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b22f366a8e05a03f87314526207b95bf5477ee5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Shared\CustomTypehead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypehead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Shared\CustomTypehead.razor"
       
    [Parameter]
    public string Placeholder { get; set; }
    [Parameter]
    public int MinimumLength { get; set; } = 3;
    [Parameter]
    public int Debounce { get; set; } = 300;
    [Parameter]
    public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter]
    public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter]
    public RenderFragment NotFoundTemplate { get; set; }
    [Parameter]
    public EventCallback<TItem> ValueChanged { get; set; }


    private bool IsSearching = false;
    private bool IsShowingSuggestions = false;
    private bool IsMouseInSuggestion = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    public TItem[] Suggestions { get; set; } = new TItem[0];

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        base.OnInitialized();
    }

    private bool ShowNotFound()
    {
        return !Suggestions.Any() && IsShowingSuggestions;
    }

    private async Task SelectSuggestion(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }

    protected async void Search(Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        IsShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);

        Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();

        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }

    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            if (value.Length == 0)
            {
                IsShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }

        }
    }

    private bool ShouldShowSuggestions()
    {
        return IsShowingSuggestions && Suggestions.Any();
    }

    private void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            IsShowingSuggestions = true;
        }
    }

    private void OnFocusOut()
    {
        if (!IsMouseInSuggestion)
        {
            IsShowingSuggestions = true;
        }
    }


    private void OnMouseOverSuggestion()
    {
        IsMouseInSuggestion = true;
    }

    private void OnMouseOutSuggestion()
    {
        IsMouseInSuggestion = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
