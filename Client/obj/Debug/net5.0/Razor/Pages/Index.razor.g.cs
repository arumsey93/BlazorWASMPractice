#pragma checksum "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe8439e144d44b1e47ca9bcd7ab12931f35eaf2"
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
#nullable restore
#line 2 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorWebAssemblySignalRApp.Client.Pages.Index.TypeInference.CreateMudTextField_0(__builder3, 5, 6, "User", 7, "Input Username", 8, 
#nullable restore
#line 8 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                                                                                Variant.Text

#line default
#line hidden
#nullable disable
                    , 9, 
#nullable restore
#line 8 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                   userInput

#line default
#line hidden
#nullable disable
                    , 10, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInput = __value, userInput)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(12);
                __builder2.AddAttribute(13, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.BlazorWebAssemblySignalRApp.Client.Pages.Index.TypeInference.CreateMudTextField_1(__builder3, 15, 16, "Message", 17, "Input Message", 18, 
#nullable restore
#line 11 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                                                                                     Variant.Text

#line default
#line hidden
#nullable disable
                    , 19, 
#nullable restore
#line 11 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                   messageInput

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => messageInput = __value, messageInput)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(22);
                __builder2.AddAttribute(23, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                 3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(25);
                    __builder3.AddAttribute(26, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 14 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                                                           Send

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(29, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                                                                                             !IsConnected

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Send");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n<br>\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(33);
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(35);
                __builder2.AddAttribute(36, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudList>(38);
                    __builder3.AddAttribute(39, "Clickable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                            false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "id", "messagesList");
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 24 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
             foreach (var message in messages)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudListItem>(42);
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(44, 
#nullable restore
#line 26 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
                              message

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 27 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/alexrumsey/workspace/BlazorWebAssemblySignalRApp/Client/Pages/Index.razor"
        private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
          .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
        .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task Send() =>
      await hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
      hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.BlazorWebAssemblySignalRApp.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "HelperText", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "HelperText", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
