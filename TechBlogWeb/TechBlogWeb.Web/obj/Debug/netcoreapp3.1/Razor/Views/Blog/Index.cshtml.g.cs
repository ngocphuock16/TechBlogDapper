#pragma checksum "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a063420825980426f3dd035625aff635f449a80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\_ViewImports.cshtml"
using TechBlogWeb.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\_ViewImports.cshtml"
using TechBlogWeb.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a063420825980426f3dd035625aff635f449a80", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad818218c44ed99457f5ca8db3d94cc131ff0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechBlogWeb.Domain.Response.Blog.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/techblogJS/blogIndex.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!--================Hero Banner Area Start =================-->
<section class=""hero-banner d-flex align-items-center"">
    <div class=""container text-center"">
        <h2>Blog</h2>
        <nav aria-label=""breadcrumb"" class=""banner-breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a063420825980426f3dd035625aff635f449a805325", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Blog</li>
            </ol>
        </nav>
    </div>
</section>
<!--================Hero Banner Area End =================-->

    <section class=""blog_area area-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 mb-5 mb-lg-0"">
");
#nullable restore
#line 20 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                     foreach (var blog in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"blog_left_sidebar\">\r\n                            <article class=\"blog_item\">\r\n                                <div class=\"blog_item_img\">\r\n                                    <img class=\"card-img rounded-0\"");
            BeginWriteAttribute("src", " src=\"", 1138, "\"", 1158, 1);
#nullable restore
#line 25 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1144, blog.ImageUrl, 1144, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1159, "\"", 1165, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a href=\"#\" class=\"blog_item_date\">\r\n                                        <h3>");
#nullable restore
#line 27 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                                       Write(blog.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"blog_details\">\r\n                                    <a class=\"d-inline-block\" href=\"#\" ");
            WriteLiteral(">\r\n                                        <h2>");
#nullable restore
#line 32 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                                       Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    </a>\r\n                                    <p>");
#nullable restore
#line 34 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                                  Write(blog.ShortContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <ul class=\"blog-info-link\">\r\n                                        <li><a href=\"#\"><i class=\"far fa-user\"></i>");
#nullable restore
#line 36 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                                                                              Write(blog.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    </ul>\r\n                                </div>\r\n                            </article>\r\n                        </div>\r\n");
#nullable restore
#line 41 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"blog_right_sidebar\">\r\n                        <aside class=\"single_sidebar_widget search_widget\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a063420825980426f3dd035625aff635f449a8010518", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" class=""form-control"" placeholder=""Search Keyword"">
                                        <div class=""input-group-append"">
                                            <button class=""btn"" type=""button""><i class=""ti-search""></i></button>
                                        </div>
                                    </div>
                                </div>
                                <button class=""button rounded-0 primary-bg text-white w-100"" type=""submit"">Search</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </aside>
                        <aside class=""single_sidebar_widget post_category_widget"">
                            <h4 class=""widget_title"">Category</h4>
                            <ul class=""list cat-list"">
                                <li>
                                    <p id=""category"" style=""color:black""></p>
                                </li>
                            </ul>
                        </aside>
");
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a063420825980426f3dd035625aff635f449a8013286", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 113 "C:\TechBlogDapper_MinhHoang_NgocPhuoc\TechBlogWeb\TechBlogWeb.Web\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechBlogWeb.Domain.Response.Blog.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
