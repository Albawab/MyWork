#pragma checksum "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Shared\OmschrijvingNavigatorComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ea8c1dc8a4354e36979d384ce81b2bdf9a946b"
// <auto-generated/>
#pragma warning disable 1591
namespace Impott.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Impott;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\_Imports.razor"
using Impott.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Shared\OmschrijvingNavigatorComponent.razor"
using Impott.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Shared\OmschrijvingNavigatorComponent.razor"
using Impott.Data;

#line default
#line hidden
#nullable disable
    public partial class OmschrijvingNavigatorComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hallo</h1>\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 5 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Shared\OmschrijvingNavigatorComponent.razor"
 OmschrijvingI.Titel

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\albaw\Desktop\ICT\SharpW\00 Blazor\11 IHandle Snde to Component\Impott\Shared\OmschrijvingNavigatorComponent.razor"
       

    [Parameter]
    public OmschrijvingItem OmschrijvingI { get; set; }

    protected override void OnParametersSet()
    {
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
