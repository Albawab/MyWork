#pragma checksum "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91802d50158c11c4c40a1ff18b9b786ab9644b04"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Blazor.Common.GridBody.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Navigatie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
using HenE.Aeolus.Blazor.Common.Menubar.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
using HenE.Aeolus.Blazor.Common.GridBody.Components;

#line default
#line hidden
#nullable disable
    public partial class BaseODataGridComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "toolsHeader");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<HenE.Aeolus.Blazor.Common.Menubar.Components.MenubarBodyComponent>(3);
            __builder.AddAttribute(4, "MenubarCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<dynamic>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<dynamic>(this, 
#nullable restore
#line 6 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
                                           Callback

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "MenubarItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<dynamic>(
#nullable restore
#line 6 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
                                                                    MenubarService.GetMenubarItems()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenComponent<HenE.Aeolus.Blazor.Common.GridBody.Components.ODataGridComponent<TItem>>(10);
            __builder.AddAttribute(11, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
                              Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Callback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.SfGrid<TItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.SfGrid<TItem>>(this, 
#nullable restore
#line 10 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
                                                           GetData

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\GridBody\Components\BaseODataGridComponent.razor"
       
    [Parameter]
    public string Url { get; set; }

    public SfGrid<TItem> DefaultGrid { get; set; }
    private void GetData(SfGrid<TItem> data)
    {
        DefaultGrid = data;
    }

    private void Callback(dynamic callback)
    {
        switch (callback.Titel)
        {
            case "Excel Exporteren":
                ExcelExport();
                break;
            case "Pdf Exporteren":
                PdfExport();
                break;
            default:
                break;
        }
    }


    public void ExcelExport()
    {
        ExcelExportProperties ExcelProperties = new ExcelExportProperties();
        ExcelTheme Theme = new ExcelTheme();

        ExcelStyle ThemeStyle = new ExcelStyle()
        {
            FontName = "Segoe UI",
            FontColor = "#666666",
            FontSize = 12
        };

        Theme.Header = ThemeStyle;
        Theme.Record = ThemeStyle;
        Theme.Caption = ThemeStyle;
        ExcelProperties.Theme = Theme;
        ExcelProperties.FileName = $"Excel file_{DateTime.Now}.xlsx";
        // ExcelProperties.ExportType = Syncfusion.Blazor.Grids.ExportType.CurrentPage;
        this.DefaultGrid.ExcelExport(ExcelProperties);
    }
    public void PdfExport()
    {
        PdfExportProperties ExportProperties = new PdfExportProperties();
        ExportProperties.FileName = $"Pdf file_{DateTime.Now}.pdf";
        this.DefaultGrid.PdfExport(ExportProperties);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMenubarSevice MenubarService { get; set; }
    }
}
#pragma warning restore 1591
