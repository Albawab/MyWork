#pragma checksum "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\Pages\Bootstrap_Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f6895b7a8ae2364b2eaa605655586adfc980956"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _00_Bootstrap.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using _00_Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\_Imports.razor"
using _00_Bootstrap.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bootsrrapForm")]
    public partial class Bootstrap_Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Abdul\Desktop\Sharp\01 Bootstrab\00-Bootstrap\00-Bootstrap\Pages\Bootstrap_Form.razor"
 
    private EditContext EditContext;
    private GuestbookEntry Model = new GuestbookEntry();

    protected string OkayDisabled { get; set; } = "disabled";

    protected void OnInit()
    {
        EditContext = new EditContext(Model);
        EditContext.OnFieldChanged += EditContext_OnFieldChanged;


    }

    protected void OnAfterRender()
    {


        SetOkDisabledStatus();
    }

    private void EditContext_OnFieldChanged(object sender, FieldChangedEventArgs e)
    {
        SetOkDisabledStatus();
    }

    private void SetOkDisabledStatus()
    {
        if (EditContext.Validate())
        {
            OkayDisabled = null;
        }
        else
        {
            OkayDisabled = "disabled";
        }
    }

    public class GuestbookEntry
{

    public string Name { get; set; }
 

    public string Text { get; set; }
}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591