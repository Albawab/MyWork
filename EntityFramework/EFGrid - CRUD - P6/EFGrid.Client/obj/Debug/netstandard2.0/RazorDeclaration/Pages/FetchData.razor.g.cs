#pragma checksum "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8343d243edc5538c5542f4058e4dd7f02602d9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EFGrid.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using EFGrid.Client;

#line default
#line hidden
#line 7 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using EFGrid.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#line 9 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
#line 10 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\_Imports.razor"
using Syncfusion.EJ2.Blazor.Data;

#line default
#line hidden
#line 2 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\Pages\FetchData.razor"
using EFGrid.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\Abdul\Desktop\EntityFramework\EFGrid - CRUD - P6\EFGrid.Client\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
