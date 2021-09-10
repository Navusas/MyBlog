// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 13 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\Index.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\Index.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Dev\10percent\Books\WebDevelopmentWIthBlazor\MyBlogv2\MyBlog\MyBlog.ServerSide\Pages\Index.razor"
       
	public int TotalBlogPosts { get; set; }
	private async ValueTask<ItemsProviderResult<BlogPost>> LoadPosts(ItemsProviderRequest request)
	{
		if (TotalBlogPosts == 0)
		{
			TotalBlogPosts = await api.GetBlogPostCountAsync();
		}
		var numBlogPosts = Math.Min(request.Count, TotalBlogPosts - request.StartIndex);
		var employees = await api.GetBlogPostsAsync(numBlogPosts, request.StartIndex);
		return new ItemsProviderResult<BlogPost>(employees, TotalBlogPosts);
	}

	protected async Task AddSomePosts()
	{
		for(int i = TotalBlogPosts; i <= TotalBlogPosts+10; i++)
		{
			await api.SaveBlogPostAsync(new BlogPost()
			{
				PublishDate = DateTime.Now,
				Title = $"Blog post {i}",
				Text = "Text"
			});
		}
		TotalBlogPosts += 10;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMyBlogApi api { get; set; }
    }
}
#pragma warning restore 1591
