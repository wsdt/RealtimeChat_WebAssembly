#pragma checksum "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277192bef11a2dd941bac1087eaf1bde8fef9e3e"
// <auto-generated/>
#pragma warning disable 1591
namespace WSDTChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\keri\Desktop\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>WSDT Chat</h1>\r\n\r\nWelcome to my first Blazor app using .NET and SignalR.\r\n\r\n");
            __builder.OpenComponent<WSDTChat.Pages.Chat>(1);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
