#pragma checksum "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55032642c2a7d12f9b51ad90d67800843a6c1ca3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Pages.Movies
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
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\Downloads\Edu\Programming in Blazor - ASP.NET Core 3.1 2020-5\0. Project\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
       
    [Parameter]
    public Movie Movie { get; set; }
    [Parameter]
    public EventCallback OnValidSubmit { get; set; }
    [Parameter]
    public List<Genre> SelectedGenres { get; set; } = new List<Genre>();
    [Parameter]
    public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter]
    public List<Person> SelectedActors { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();

    private string imageURL;


    protected override void OnInitialized()
    {
        Selected = SelectedGenres
            .Select(x => new MultipleSelectorModel(x.ToString(), x.Name))
            .ToList();

        NotSelected = NotSelectedGenres
            .Select(x => new MultipleSelectorModel(x.ToString(), x.Name))
            .ToList();

        if (!string.IsNullOrEmpty(Movie.Poster))
        {
            imageURL = Movie.Poster;
            Movie.Poster = null;
        }
    }

    private void PosterSelected(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return new List<Person>() {
            new Person() { Id= 1, Name = "Tom Holland", Picture = "https://m.media-amazon.com/images/M/MV5BNTAzMzA3NjQwOF5BMl5BanBnXkFtZTgwMDUzODQ5MTI@._V1_UY317_CR23,0,214,317_AL_.jpg" },
            new Person() {Id = 2, Name = "Tom Hanks", Picture = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY317_CR2,0,214,317_AL_.jpg" }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
