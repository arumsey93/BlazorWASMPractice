#pragma checksum "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e807dfb05cc950166f201832da445f3360a062ef"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblySignalRApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using BlazorWebAssemblySignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using BlazorWebAssemblySignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 3 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
               Typo.h1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Counter");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudText>(5);
            __builder.AddAttribute(6, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
               Typo.body2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Current count: ");
                __builder2.AddContent(9, 
#nullable restore
#line 5 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
                                           _currentCount

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(11);
            __builder.AddAttribute(12, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
                                             IncrementCount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
                                                                    Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(16);
                __builder2.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
                                                                                                  Typo.button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "Click me");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Counter.razor"
       
    private int _currentCount = 0;

    private void IncrementCount()
    {
        _currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
