#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Items.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263da8766cdee1752c47745bc3a02eda216f5bfd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Furniture_Store.WEB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Items.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Items.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Items.razor"
using Furniture_Store.Business.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items")]
    public partial class Items : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furniture_Store1\Furniture_Store.WEB\Pages\Items.razor"
      

    private ItemDTO[] items;
    ItemDTO obj = new ItemDTO();
    string ids = "0";
    bool showAddrow = false;

    bool loadFailed;

    protected override async Task OnInitializedAsync()
    {
        ids = "0";
        items = await Http.GetJsonAsync<ItemDTO[]>("/api/Item/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
