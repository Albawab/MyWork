#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cddf3e74de86b3213ef8dea5dd4994b0869fe19"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages.Oefenen
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
#line 11 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Data;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/sidebar")]
    public partial class Sidebar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 col-sm-12 col-md-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "wrapper");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfSidebar>(6);
            __builder.AddAttribute(7, "Width", "220px");
            __builder.AddAttribute(8, "DockSize", "72px");
            __builder.AddAttribute(9, "EnableDock", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarPosition>(
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
                                                                             Syncfusion.Blazor.Navigations.SidebarPosition.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "HtmlAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
                                                                                                                                                                  htmlAttribute

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "dock");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "ul");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "sidebar-item");
                __builder2.AddAttribute(21, "id", "toggle");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
                                                                        Toggle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "\r\n                            <span class=\"e-icons expand\"></span>\r\n                            ");
                __builder2.AddMarkupContent(24, "<span class=\"e-text\" title=\"menu\">Menu</span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.AddMarkupContent(26, "<li class=\"sidebar-item\">\r\n                            <span class=\"e-icons home\"></span>\r\n                            <span class=\"e-text\" title=\"home\">Home</span>\r\n                        </li>\r\n                        ");
                __builder2.AddMarkupContent(27, "<li class=\"sidebar-item\">\r\n                            <span class=\"e-icons profile\"></span>\r\n                            <span class=\"e-text\" title=\"profile\">Profile</span>\r\n                        </li>\r\n                        ");
                __builder2.AddMarkupContent(28, "<li class=\"sidebar-item\">\r\n                            <span class=\"e-icons info\"></span>\r\n                            <span class=\"e-text\" title=\"info\">Info</span>\r\n                        </li>\r\n                        ");
                __builder2.AddMarkupContent(29, "<li class=\"sidebar-item\">\r\n                            <span class=\"e-icons settings\"></span>\r\n                            <span class=\"e-text\" title=\"settings\">Settings</span>\r\n                        </li>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
            }
            ));
            __builder.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
                                                                                                                                        sidebar = (Syncfusion.Blazor.Navigations.SfSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n        \r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<title>Essential JS 2 (Preview) for ASP.Net Core Sidebar-> Dock</title>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.AddMarkupContent(37, "<style>\r\n    .title {\r\n        text-align: center;\r\n        font-size: 20px;\r\n        padding: 15px;\r\n    }\r\n\r\n    .sub-title {\r\n        text-align: center;\r\n        font-size: 16px;\r\n        padding: 10px;\r\n    }\r\n\r\n    #wrapper .sub-title .column {\r\n        display: inline-block;\r\n        padding: 10px;\r\n    }\r\n    /* custom code start */\r\n    .center {\r\n        text-align: center;\r\n        display: none;\r\n        font-size: 13px;\r\n        font-weight: 400;\r\n        margin-top: 20px;\r\n    }\r\n\r\n    .sb-content-tab .center {\r\n        display: block;\r\n    }\r\n    /* custom code end */\r\n    /* end of content area styles */\r\n    /* Sidebar styles */\r\n    .dockSidebar.e-sidebar.e-right.e-close {\r\n        visibility: visible;\r\n        transform: translateX(0%);\r\n    }\r\n\r\n    .dockSidebar .e-icons::before {\r\n        font-size: 25px;\r\n    }\r\n    /* dockbar icon Style */\r\n    .dockSidebar .home::before {\r\n        content: \'\\e102\';\r\n    }\r\n\r\n    .dockSidebar .profile::before {\r\n        content: \'\\e10c\';\r\n    }\r\n\r\n    .dockSidebar .info::before {\r\n        content: \'\\e11b\';\r\n    }\r\n\r\n    .dockSidebar .settings::before {\r\n        content: \'\\e10b\';\r\n    }\r\n\r\n    .e-sidebar .expand::before,\r\n    .e-sidebar.e-right.e-open .expand::before {\r\n        content: \'\\e10f\';\r\n    }\r\n\r\n    .e-sidebar.e-open .expand::before,\r\n    .e-sidebar.e-right .expand::before {\r\n        content: \'\\e10e\';\r\n    }\r\n    /* end of dockbar icon Style */\r\n    .dockSidebar.e-close .sidebar-item {\r\n        padding: 5px 20px;\r\n    }\r\n\r\n    .dockSidebar.e-dock.e-close span.e-text {\r\n        display: none;\r\n    }\r\n\r\n    .dockSidebar.e-dock.e-open span.e-text {\r\n        display: inline-block;\r\n    }\r\n\r\n    .dockSidebar li {\r\n        list-style-type: none;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .dockSidebar ul {\r\n        padding: 0px;\r\n    }\r\n\r\n    .dockSidebar.e-sidebar ul li:hover span {\r\n        color: white\r\n    }\r\n\r\n    .dockSidebar span.e-icons {\r\n        color: #c0c2c5;\r\n        line-height: 2\r\n    }\r\n\r\n    .e-open .e-icons {\r\n        margin-right: 16px;\r\n    }\r\n\r\n    .e-open .e-text {\r\n        overflow: hidden;\r\n        text-overflow: ellipsis;\r\n        line-height: 23px;\r\n        font-size: 15px;\r\n    }\r\n\r\n    .sidebar-item {\r\n        text-align: center;\r\n        border-bottom: 1px #e5e5e58a solid;\r\n    }\r\n\r\n    .e-sidebar.e-open .sidebar-item {\r\n        text-align: left;\r\n        padding-left: 15px;\r\n        color: #c0c2c5;\r\n    }\r\n\r\n    .dockSidebar.e-sidebar {\r\n        background: #2d323e;\r\n        overflow: hidden;\r\n    }\r\n    /* custom generated icons styles */\r\n    @font-face {\r\n        font-family: \'e-icons\';\r\n        src: url(data:application/x-font-ttf;charset=utf-8;base64,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) format(\'truetype\');\r\n        font-weight: normal;\r\n        font-style: normal;\r\n    }\r\n    /* end of custom generated icons styles */\r\n    /* custom code start */\r\n    .ej2-new .sb-header,\r\n    .ej2-new .sb-bread-crumb,\r\n    .ej2-new #action-description,\r\n    .ej2-new .sb-action-description,\r\n    .ej2-new .e-tab-header,\r\n    .ej2-new .description-section,\r\n    .ej2-new #description-section,\r\n    .ej2-new #description,\r\n    .ej2-new .sb-footer, .ej2-new #left-sidebar, .sb-component-name {\r\n        display: none\r\n    }\r\n\r\n    .ej2-new .sb-right-pane.e-view {\r\n        margin-left: 0px !important;\r\n    }\r\n\r\n    .sb-action-description.sb-rightpane-padding {\r\n        padding-bottom: 0;\r\n    }\r\n\r\n    .description-section {\r\n        padding-top: 0;\r\n    }\r\n\r\n    #sb-content-header {\r\n        display: none\r\n    }\r\n\r\n    #content-tab.sb-content-tab {\r\n        height: 100% !important;\r\n    }\r\n\r\n    .ej2-new .container-fluid,\r\n    .ej2-new .container-fluid .control-section,\r\n    #sidebar-section, description-section sb-rightpane-padding {\r\n        padding: 0;\r\n    }\r\n\r\n    .sb-component-name.sb-rightpane-padding {\r\n        margin-top: -56px;\r\n    }\r\n\r\n    .sb-right-pane.e-view {\r\n        left: 0;\r\n        padding-left: 0;\r\n        padding-right: 0;\r\n        top: 0;\r\n        overflow-y: hidden;\r\n    }\r\n\r\n    .sb-desktop-wrapper {\r\n        height: 100%;\r\n    }\r\n\r\n    .sb-component-name h1 {\r\n        padding-top: 0;\r\n    }\r\n\r\n    .ej2-new .sb-content.e-view {\r\n        top: 0;\r\n    }\r\n    /* end of newTab support */\r\n    /* custom code end */\r\n    /* end of sidebar styles */\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Sidebar.razor"
       
    SfSidebar sidebar;
    public bool Leftbtn = true;
    public void Toggle()
    {
        this.sidebar.Toggle();
    }

    Dictionary<string, object> htmlAttribute = new Dictionary<string, object>()
{
        {"class", "dockSidebar" }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
