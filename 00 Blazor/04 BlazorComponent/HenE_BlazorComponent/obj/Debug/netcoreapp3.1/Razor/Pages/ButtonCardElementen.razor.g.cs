#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045c14787df647dff310cf096d472d053b659763"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 1 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
    public partial class ButtonCardElementen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "label");
            __builder.AddAttribute(1, "class", "d-flex" + " col-" + (
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                              cardButtonElement.Columns

#line default
#line hidden
#nullable disable
            ) + "  align-items-" + (
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                                                                      cardButtonElement.HorizontalAlign.ToBootstrap()

#line default
#line hidden
#nullable disable
            ) + " justify-content-" + (
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                                                                                                                                       cardButtonElement.VerticalAlign.ToBootstrap()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.SplitButtons.SfProgressButton>(3);
            __builder.AddAttribute(4, "Content", "Change Value");
            __builder.AddAttribute(5, "EnableProgress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "CssClass", "e-round-corner e-danger");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                                                                                                                    MouseClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.SplitButtons.ProgressButtonSpinSettings>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.SplitButtons.ProgressButtonAnimationSettings>(12);
                __builder2.AddAttribute(13, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.SplitButtons.AnimationEffect>(
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
                                                     AnimationEffect.ZoomIn

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\ButtonCardElementen.razor"
       
    [Parameter]
    public CardButtonElement cardButtonElement { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> MouseClicked { get; set; }


    public SpinPosition Position
    {
        get
        {
            switch (cardButtonElement.ButtonSpinPosition)
            {
                case ButtonSpinPosition.Right:
                    return SpinPosition.Right;
                case ButtonSpinPosition.Top:
                    return SpinPosition.Top;
                case ButtonSpinPosition.Bottom:
                    return SpinPosition.Bottom;
                case ButtonSpinPosition.Center:
                    return SpinPosition.Center;
                default:
                    return SpinPosition.Center;
            };
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591