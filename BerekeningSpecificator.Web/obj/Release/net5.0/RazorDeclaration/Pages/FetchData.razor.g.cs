// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BerekeningSpecificator.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using BerekeningSpecificator.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\_Imports.razor"
using BerekeningSpecificator.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\Pages\FetchData.razor"
using BerekeningSpecificator.Web.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\repos\BerekeningSpecificator\BerekeningSpecificator.Web\Pages\FetchData.razor"
       
    private RapportVariabelen[] variabelen;

    protected override async Task OnInitializedAsync()
    {
        variabelen = await Http.GetFromJsonAsync<RapportVariabelen[]>("data/rapport.json");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
