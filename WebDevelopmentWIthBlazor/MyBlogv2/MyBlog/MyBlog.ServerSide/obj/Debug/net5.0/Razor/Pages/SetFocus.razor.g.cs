#pragma checksum "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\SetFocus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29aa5beff042b59024cffc265b76c2df5553f438"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlog.ServerSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using MyBlog.ServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using MyBlog.ServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Setfocus")]
    public partial class SetFocus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddElementReferenceCapture(1, (__value) => {
#nullable restore
#line 3 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\SetFocus.razor"
             textInput = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\SetFocus.razor"
                  () => textInput.FocusAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Set focus");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\SetFocus.razor"
       
	ElementReference textInput;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591