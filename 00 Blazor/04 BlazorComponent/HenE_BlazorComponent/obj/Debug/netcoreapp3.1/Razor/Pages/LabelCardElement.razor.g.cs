#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4ffe005c345452baf25e243ff053086e6d4a56"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    public partial class LabelCardElement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "class", "d-flex" + "  col-" + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                          CardElement.Columns

#line default
#line hidden
#nullable disable
            ) + " offset-" + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                                                      CardElement.Column

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                                                                          Bold

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                                                                                VAlign

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                                                                                        HAlign

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
                                                                                                TextSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
         CardElement.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\LabelCardElement.razor"
       

    [Parameter]
    public CardLabelElement CardElement { get; set; }

    private string Bold
    {
        get
        {
            return CardElement.Type == CardLabelSoorten.Nadruk ? "font-weight-bold" : string.Empty;
        }
    }

    private string HAlign
    {
        get
        {
            return $"justify-content-{@CardElement.HorizontalAlign.ToBootstrap()}";
        }
    }

    private string VAlign
    {
        get
        {
            return $"align-items-{@CardElement.VerticalAlign.ToBootstrap()}";
        }
    }

    private string TextSize{
        get
        {
            return CardElement.Type == CardLabelSoorten.Kop ? "h4 text-danger" : string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
