#pragma checksum "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b422af9043edd57c7f69a01b5311073a4b2b6c1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\DeleteEmployee.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{empID:int}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\pc\Desktop\hadi interview\ASPCore.BlazorCrud-master\BlazorCrud\BlazorCrud\Client\Pages\DeleteEmployee.razor"
       
    [Parameter]
    public int empID { get; set; }

    Contact emp = new Contact();

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetJsonAsync<Contact>("/api/Employee/Details/" + empID);
    }

    protected async Task Delete()
    {
        await Http.DeleteAsync("api/Employee/Delete/" + Convert.ToInt32(empID));
        urlNavigationManager.NavigateTo("/fetchemployee");
    }

    void Cancel()
    {
        urlNavigationManager.NavigateTo("/fetchemployee");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager urlNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
