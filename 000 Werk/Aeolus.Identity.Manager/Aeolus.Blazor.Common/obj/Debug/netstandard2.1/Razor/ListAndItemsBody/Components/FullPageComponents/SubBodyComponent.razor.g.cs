#pragma checksum "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba8ab97d6539c0389c630a48070148acaea8d9e"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Components.FullPageComponents
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
#line 1 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
using Aeolus.Blazor.Common.ListAndItemsBody.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class SubBodyComponent : Microsoft.AspNetCore.Components.ComponentBase, IUpdateComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "body-component-header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
     bodyModel.Titel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 8 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
 foreach (dynamic property in GetProperties())
{
    dynamic value = GetValueOfProperty(property);

    if (value != null && MagTonen(property))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "body-component-sub-body");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "style", "font-size:1.2em");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
                                            GetDescription(property)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " :");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "label");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
                    value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 18 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\albaw\Desktop\Aeolus.Identity.Manager\Aeolus.Blazor.Common\ListAndItemsBody\Components\FullPageComponents\SubBodyComponent.razor"
          
        [Parameter]
        public IAppService Service { get; set; }
        [Parameter]
        public int Key { get; set; }

        BodyModel menuServivce;


        BodyModel bodyModel;

        [Parameter]
        public EventCallback<RenderFragment> CallbackToolbarBodyComponent { get; set; }

        protected override void OnInitialized()
        {
            bodyModel = UpdateComponent(Key);
        }



        protected override void OnParametersSet()
        {
            bodyModel = UpdateComponent(Key);
        }

        public BodyModel UpdateComponent(int key)
        {
            return this.Service.GetItemAppModel(key);
        }

        /// <summary>
        /// Haalt de description van een property.
        /// </summary>
        /// <param name="propertie">De properties van een object.</param>
        /// <returns>De description als tekst.</returns>
        private string GetDescription(dynamic property)
        {
            AttributeCollection attributes = TypeDescriptor.GetProperties(this.bodyModel.GetType())[$"{property.Name}"].Attributes;
            DescriptionAttribute myAttribute = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];
            return myAttribute.Description != string.Empty ? myAttribute.Description : property.Name;
        }
        private dynamic GetProperties()
        {
            dynamic huidigeProperties = bodyModel.GetType().GetProperties().ToList();
            dynamic[] Properties = new dynamic[huidigeProperties.Count];

            foreach (dynamic property in huidigeProperties)
            {
                AttributeCollection attributes = TypeDescriptor.GetProperties(this.bodyModel.GetType())[$"{property.Name}"].Attributes;
                ModelAttributen eigenAttribute = (ModelAttributen)attributes[typeof(ModelAttributen)];
                if (eigenAttribute != null)
                {
                    Properties[eigenAttribute.Order] = property;
                }

            }
            return Properties;
        }


        private dynamic GetValueOfProperty(dynamic property)
        {
            if (property != null)
            {
                return bodyModel.GetType().GetProperty(property.Name).GetValue(bodyModel, null);
            }
            return null;

        }

        private bool MagTonen(dynamic property)
        {
            AttributeCollection attributes = TypeDescriptor.GetProperties(this.bodyModel.GetType())[$"{property.Name}"].Attributes;
            ModelAttributen eigenAttribute = (ModelAttributen)attributes[typeof(ModelAttributen)];

            if (eigenAttribute != null)
            {
                if (eigenAttribute.MagTonen)
                {
                    return true;
                }
                return false;
            }
            return true;

        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591