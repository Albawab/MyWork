#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Component\LijstComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3cec884438b0c5df392f8c7f169ab08ed3b32aa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Page_Component_Views.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Page_Component_Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\_Imports.razor"
using Page_Component_Views.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Component\LijstComponent.razor"
using Page_Component_Views.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Component\LijstComponent.razor"
using Page_Component_Views.Controllers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentComponent")]
    public partial class LijstComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\Page-Component-Views\Page-Component-Views\Component\LijstComponent.razor"
       
    List<Student> Students;
    StudentControllerComponent StudentController = new StudentControllerComponent();

    protected override void OnInitialized()
    {
        Students = StudentController.GetStudents();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591