#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee4abab0077717ba8cce1e2a566b8dcddc0d60b4"
// <auto-generated/>
#pragma warning disable 1591
namespace Furniture_Store.WEB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Furniture_Store.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\_Imports.razor"
using Furniture_Store.WEB.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter/{id}")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "h1");
            __builder.AddContent(11, "Here\'s int parameter : ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Counter.razor"
                            Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Counter.razor"
       
    private int currentCount = 0;
    private int _id;
    [Parameter]
    public string Id
    {
        get
        {
            return _id.ToString();
        }
        set
        {
            try
            {
                _id = Int32.Parse(value);
            }
            catch
            {
                _id = 0;
            }
        }
    }

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
