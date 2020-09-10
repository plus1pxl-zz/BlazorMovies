#pragma checksum "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2033be24f3c956e0a85023647458129048bc60b5"
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
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelector.razor"
       
    private string removeAllText = "<<";
    [Parameter]
    public List<MultipleSelectorModel> NotSelected { get; set; }
        = new List<MultipleSelectorModel>();
    [Parameter]
    public List<MultipleSelectorModel> Selected { get; set; }
        = new List<MultipleSelectorModel>();

    private void Select(MultipleSelectorModel item)
    {
        NotSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NotSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NotSelected);
        NotSelected.Clear();
    }

    private void DeselectAll()
    {
        NotSelected.AddRange(Selected);
        Selected.Clear();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
