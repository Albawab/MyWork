#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b55585deb63ccfd2413fab6e6166ac8a53043b7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\Pages\FetchData.razor"
using WebApplication1.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\02 FormEdit-syncfusion\WebApplication1\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
