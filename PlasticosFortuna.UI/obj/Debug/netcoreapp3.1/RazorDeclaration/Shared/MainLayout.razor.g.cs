#pragma checksum "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d632eab7a46879a7220252669df9a055a31d91"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlasticosFortuna.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using PlasticosFortuna.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using PlasticosFortuna.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using PlasticosFortuna.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Shared\MainLayout.razor"
using PlasticosFortuna.UI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Shared\MainLayout.razor"
 
    private bool isServerSide = false;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            await BootstrapCss.SetBootstrapCss("4.3.1");
        }
        catch (Exception)
        {

            isServerSide = true;
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstrun)
    {
        if (isServerSide && firstrun)
        {
            await BootstrapCss.SetBootstrapCss("4.3.1");
        }
    }

    public void Logout()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBootstrapCss BootstrapCss { get; set; }
    }
}
#pragma warning restore 1591
