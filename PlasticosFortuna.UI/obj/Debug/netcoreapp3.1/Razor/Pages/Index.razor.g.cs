#pragma checksum "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b2657b4bb592f84eb6eff8bc955c3a84f47a55"
// <auto-generated/>
#pragma warning disable 1591
namespace PlasticosFortuna.UI.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Plasticos Fortuna</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "Bienvenido, ");
                __builder2.AddContent(6, 
#nullable restore
#line 7 "C:\Users\beltr\source\repos\PlasticosFortuna\PlasticosFortuna.UI\Pages\Index.razor"
                        context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<p>No has iniciado sesi&#243;n</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
