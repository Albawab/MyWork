#pragma checksum "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "447e00f19fbd75ced7a5eb7ea864128753b7c969"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages.Registreren
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
#line 2 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registreren")]
    public partial class Registreren : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"text-align:center\">\r\n    <h3 class=\"h3\">Een nieuw account maken</h3>\r\n    <h6 class=\"h6\">Je kunt dit heel snel en eenvoudig doen.</h6>\r\n</div><br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                  persoon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                           SaveData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container-fluid");
                __builder2.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
         foreach (var cardGroup in cardElementsGroup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row m-4");
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 14 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                 foreach (var card in cardGroup)
                {
                    switch (card.Soort)
                    {
                        case SoortCardElementen.Label:

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                            ");
                __builder2.OpenComponent<HenE_BlazorComponent.Pages.Registreren.LebelCardRegistreren>(14);
                __builder2.AddAttribute(15, "CardLabelElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardLabelElement>(
#nullable restore
#line 19 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                                                   (CardLabelElement)card

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 20 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                            break;
                        case SoortCardElementen.Text:

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                            ");
                __builder2.OpenComponent<HenE_BlazorComponent.Pages.Registreren.TextCardRegistreren>(18);
                __builder2.AddAttribute(19, "CardTextElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardTextElement>(
#nullable restore
#line 22 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                                                 (CardTextElement)card

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Persoon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.Persoon>(
#nullable restore
#line 22 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                                                                                persoon

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n");
#nullable restore
#line 23 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                            break;
                        case SoortCardElementen.Button:

#line default
#line hidden
#nullable disable
                __builder2.AddContent(22, "                            ");
                __builder2.OpenComponent<HenE_BlazorComponent.Pages.Registreren.ButtonCardElenenten>(23);
                __builder2.AddAttribute(24, "CardButtonElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardButtonElement>(
#nullable restore
#line 25 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                                                   (CardButtonElement)card

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n");
#nullable restore
#line 26 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                            break;
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 30 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Placeholder", "First Name");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
                                                     MyProperty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MyProperty = __value, MyProperty))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => MyProperty));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenElement(36, "h1");
                __builder2.AddContent(37, 
#nullable restore
#line 33 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
         MyProperty

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Abdul\Desktop\Werk\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Registreren\Registreren.razor"
       
    dynamic cardElementsGroup;
    Persoon persoon;
    List<Persoon> persoons = new List<Persoon>();
    public string MyProperty { get; set; }= "ee";

    List<CardElement> cardElements = new List<CardElement>
{
        new CardLabelElement
        {
            Row=1,
            Rows =1,
            Column=2,
            Columns =1,
            Type = CardLabelSoorten.Nadruk,
            Soort = SoortCardElementen.Label,
            HorizontalAlign = HorizontalAlign.Right,
            VerticalAlign = VerticalAlign.Center,
            Title = "VoorNaam",
        },
        new CardTextElement
        {
            Row = 1,
            Rows=1,
            Column = 0,
            Columns= 3,
            Type= TextBoxTypes.Text,
            Placeholder= "VoorNaam",
            MaxLength = 20,
            Soort = SoortCardElementen.Text,
        },
         new CardLabelElement
        {
            Row=1,
            Rows =1,
            Column=0,
            Columns =1,
            Type = CardLabelSoorten.Nadruk,
            HorizontalAlign = HorizontalAlign.Right,
            VerticalAlign = VerticalAlign.Center,
            Title = "AchterNaam",
        },
         new CardTextElement
        {
            Row = 1,
            Rows=1,
            Column = 0,
            Columns= 3,
            Type= TextBoxTypes.Text,
            Placeholder= "AchterNaam",
            MaxLength = 20,
            Soort = SoortCardElementen.Text,
        },
         new CardTextElement
         {
             Row = 2,
             Rows =1,
             Column = 3,
             Columns = 7,
             Soort = SoortCardElementen.Text,
             Type = TextBoxTypes.Email,
             Placeholder= "Email",
             MaxLength = 30,
         },
         new CardTextElement
         {
             Row = 3,
             Rows =1,
             Column = 3,
             Columns = 7,
             Soort = SoortCardElementen.Text,
             Type = TextBoxTypes.Password,
             Placeholder= "Wachtwoord",
         },
         new CardButtonElement
         {
             Row=4,
             Rows =1,
             Column=3,
             Columns=1,
             Soort = SoortCardElementen.Button,
             ButtonAnimationEffect = ButtonAnimationEffect.SlideRight,
             ButtonSpinPosition = ButtonSpinPosition.Right,
         }

    };
    protected override void OnInitialized()
    {
                persoon = new Persoon();
        cardElementsGroup = cardElements.GroupBy(G => G.Row);
    }

    private void SaveData()
    {

        persoons.Add(persoon);
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
