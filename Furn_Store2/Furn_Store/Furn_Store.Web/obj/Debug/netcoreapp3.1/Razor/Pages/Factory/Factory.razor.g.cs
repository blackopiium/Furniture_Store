#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e1ca81e2ba9075ae86cd439987884694f61dd5"
// <auto-generated/>
#pragma warning disable 1591
namespace Furn_Store.Web.Pages.Factory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Furn_Store.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Furn_Store.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
    public partial class Factory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "item-on-page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "item-img");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "factories/" + (
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
                            Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
             if (String.IsNullOrWhiteSpace(ImageSource))
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "                <img src=\"/factory_image/unknown.jpg\"> ");
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
                                                       }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
                           ImageSource

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "items");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "h3");
            __builder.AddContent(20, 
#nullable restore
#line 15 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
             Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(24, @"<style>
    * {
        box-sizing: border-box;
    }

    .item-on-page {
        width: 45%;
        padding: 0px 0px 15px 25px;
        border: 1px solid #eee;
        background: white;
        overflow: hidden;
        transition: .3s linear;
        float: left;
        margin: 30px;
    }

        .item-on-page:hover {
            transform: scale(1.1);
        }

    .item-img {
        transition: 1s ease-in-out;
    }

        .item-img img {
            display: block;
            width: 100%;
        }

    .items {
        margin-top: 15px;
    }

        .items h3 {
            font-weight: 700;
            color: #39404B;
            margin: 0;
            text-transform: uppercase;
            font-size: 20px;
            line-height: 2;
        }

    .price {
        color: #000000;
        display: block;
        margin-bottom: 10px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factory.razor"
       
    [Parameter]
    public string Id { get; set; }
    [Parameter]
    public string ImageSource { get; set; }
    [Parameter]
    public string Name { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
