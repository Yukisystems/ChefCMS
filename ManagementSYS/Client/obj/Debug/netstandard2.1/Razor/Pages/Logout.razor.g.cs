#pragma checksum "D:\Gamedev_local\WebProjects\ManagementSYS\Client\Pages\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a9afb12277c24ef0f35c12a53105563461ef3f8"
// <auto-generated/>
#pragma warning disable 1591
namespace ManagementSYS.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using ManagementSYS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using ManagementSYS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using ManagementSYS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using ManagementSYS.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using ManagementSYS.Shared.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Gamedev_local\WebProjects\ManagementSYS\Client\Pages\Logout.razor"
       

    protected override async Task OnInitializedAsync()
    {
        await AuthService.Logout();
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
