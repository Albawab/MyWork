#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87022ef39dcc2fb3ce7edb22930e643d99f06c6d"
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
#line 15 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Buttons;

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
#line 3 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inPlaceEditor")]
    public partial class InPlaceEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>InPlaceEditor</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2 style=\"color:red\">popup</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateSfInPlaceEditor_0(__builder, 4, 5, 
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                           RenderMode.Popup

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                   InputType.AutoComplete

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 13 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                   AutoValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<h2 style=\"color:red\">DropDownList</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateSfInPlaceEditor_1(__builder, 13, 14, 
#nullable restore
#line 21 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                           RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 21 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                    InputType.DropDownList

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 21 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                    DropdownValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<h2 style=\"color:red\">Buttons</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateSfInPlaceEditor_2(__builder, 22, 23, 
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                           RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                    InputType.Text

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                           AutoValue

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                  SaveBtn

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 28 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                         CancelBtn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.AddMarkupContent(32, "<h2 style=\"color:red\">Server</h2>\r\n    ");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table-section");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddMarkupContent(38, "<td class=\"sample-td\"> Enter your name: </td>\r\n            ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "class", "sample-td");
            __builder.AddMarkupContent(41, "\r\n                ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateSfInPlaceEditor_3(__builder, 42, 43, "Skill", 44, "https://ej2services.syncfusion.com/development/web-services/api/Editor/UpdateData", 45, "FrameWork", 46, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                      AdaptorType.UrlAdaptor

#line default
#line hidden
#nullable disable
            , 47, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                    RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                       true

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                   InputType.MultiSelect

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                 MultiSelectValue

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 40 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                                                               MultiSelectData

#line default
#line hidden
#nullable disable
            , 53, (__builder2) => {
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(55);
                __builder2.AddAttribute(56, "OnActionSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.InPlaceEditor.ActionEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.InPlaceEditor.ActionEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                          OnSuccess

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(63, "div");
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.AddMarkupContent(65, "<h2 style=\"color:red\">Validation</h2>\r\n    ");
            __builder.OpenElement(66, "table");
            __builder.AddAttribute(67, "class", "table-section");
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.AddMarkupContent(71, "<td> Default Error Message </td>\r\n            ");
            __builder.OpenElement(72, "td");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<string>>(74);
            __builder.AddAttribute(75, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.InPlaceEditor.RenderMode>(
#nullable restore
#line 56 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                       RenderMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "EmptyText", "dd/mm/yyyy");
            __builder.AddAttribute(77, "Name", "Today");
            __builder.AddAttribute(78, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                               Validate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.InPlaceEditor.InputType>(
#nullable restore
#line 56 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                               InputType.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                      DateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenElement(84, "tr");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.AddMarkupContent(86, "<td> Customized Error Message </td>\r\n            ");
            __builder.OpenElement(87, "td");
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<string>>(89);
            __builder.AddAttribute(90, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.InPlaceEditor.RenderMode>(
#nullable restore
#line 63 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                       RenderMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "EmptyText", "dd/mm/yyyy");
            __builder.AddAttribute(92, "Name", "TodayCustom");
            __builder.AddAttribute(93, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                     Validation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.InPlaceEditor.InputType>(
#nullable restore
#line 63 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                       InputType.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                              DateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(98);
                __builder2.AddAttribute(99, "Validating", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.InPlaceEditor.ValidateEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.InPlaceEditor.ValidateEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                     OnValidation

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
       
    public string AutoValue = "Australia";
    public string DropdownValue = "Australia";
    public string[] MultiSelectValue = new string[] { "JavaScript", "jQuery" };


    public ButtonModel SaveBtn = new ButtonModel()
    {
        Content = "OK",
        CssClass = "e-outline"
    };

    public MultiSelectModel<string> MultiSelectData = new MultiSelectModel<string>()
    {
        Placeholder = "Select skill",
        Mode = VisualMode.Box,
        DataSource = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" }
    };
    public ButtonModel CancelBtn = new ButtonModel()
    {
        Content = "Cancel",
        CssClass = "e-outline"
    };

    public void OnSuccess(ActionEventArgs args)
    {
        Console.WriteLine("Event is triggered");
    }


    public DatePickerModel DateModel = new DatePickerModel()
    {
        Placeholder = "Select date"
    };
    public object Validate = new
    {
        Today = new { required = true }
    };
    public object Validation = new
    {
        TodayCustom = new { required = true }
    };
    private void OnValidation(ValidateEventArgs args)
    {
        args.ErrorMessage = "Field should not be empty";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfInPlaceEditor_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateSfInPlaceEditor_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateSfInPlaceEditor_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Object __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "SaveButton", __arg3);
        __builder.AddAttribute(__seq4, "CancelButton", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateSfInPlaceEditor_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Syncfusion.Blazor.InPlaceEditor.AdaptorType __arg3, int __seq4, global::Syncfusion.Blazor.InPlaceEditor.RenderMode __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::Syncfusion.Blazor.InPlaceEditor.InputType __arg6, int __seq7, TValue __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Url", __arg1);
        __builder.AddAttribute(__seq2, "PrimaryKey", __arg2);
        __builder.AddAttribute(__seq3, "Adaptor", __arg3);
        __builder.AddAttribute(__seq4, "Mode", __arg4);
        __builder.AddAttribute(__seq5, "EnableEditMode", __arg5);
        __builder.AddAttribute(__seq6, "Type", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "SubmitOnEnter", __arg8);
        __builder.AddAttribute(__seq9, "Model", __arg9);
        __builder.AddAttribute(__seq10, "ChildContent", __arg10);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
