#pragma checksum "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af8b760106cd8b377ac2aa63f49fe42482707b0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorChat.WebUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
#line 1 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/_Imports.razor"
using BlazorChat.WebUI.Shared;

#line default
#line hidden
#line 3 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatroom")]
    public partial class Chatroom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazor SignalR Chat</h1>\n<hr>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "scrollbox");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<div class=\"row\">&nbsp;</div>\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.AddMarkupContent(11, "<div class=\"col-2\">User</div>\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-4");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "placeholder", "Your name ..");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 13 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                                                                         _username

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.AddMarkupContent(22, "\n            ");
            __builder.AddMarkupContent(23, "<div class=\"col-2\">Message</div>\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-4");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "placeholder", "Your message ..");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                                                                            _message

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _message = __value, _message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.AddMarkupContent(32, "<div class=\"row\">&nbsp;</div>\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-6");
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                                    () => SendAsync(_username,_message)

#line default
#line hidden
            ));
            __builder.AddContent(41, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        ");
            __builder.AddMarkupContent(45, "<div class=\"row\">&nbsp;</div>\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddMarkupContent(48, "\n            ");
            __builder.OpenElement(49, "ul");
            __builder.AddMarkupContent(50, "\n");
#line 28 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                 foreach (var item in _messages)
                {

#line default
#line hidden
            __builder.AddContent(51, "                    ");
            __builder.OpenElement(52, "li");
            __builder.AddMarkupContent(53, "\n                        ");
            __builder.OpenElement(54, "label");
            __builder.AddContent(55, 
#line 31 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                                item.ToString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n");
#line 33 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
                }

#line default
#line hidden
            __builder.AddContent(58, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 40 "/Users/SamMBP/CLIProjects/BlazorChat/BlazorChat/WebUI/Pages/Chatroom.razor"
       
    private string _username;
    private string _message;
    private List<string> _messages = new List<string>();

    private HubConnection _hubConnection;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _messages.Clear();

            var ip = "localhost";
            _hubConnection = new HubConnectionBuilder().WithUrl($"http://{ip}:5001/chatHub").Build();

            _hubConnection.On<string, string>("ReceiveMessage", MessageReceived);

            await _hubConnection.StartAsync();
        }
        catch (Exception e)
        {
            // Some error handling.
        }
    }


    private void MessageReceived(string username, string message)
    {
        _messages.Add(username + " said " + message);

        StateHasChanged();
    }

    private async Task SendAsync(string username, string message)
    {

        await _hubConnection.SendAsync("SendMessage", username, message);

        _username = string.Empty;
        _message = string.Empty;

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
