#pragma checksum "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada9a5711f1ad112bd27e4dc96585fd98551b53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsContents_Delete), @"mvc.1.0.view", @"/Views/NewsContents/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada9a5711f1ad112bd27e4dc96585fd98551b53f", @"/Views/NewsContents/Delete.cshtml")]
    public class Views_NewsContents_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zee_News_WebApi.Models.NewsContent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>NewsContent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagesLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImagesLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VideosLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VideosLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.News));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "F:\day4\Modules\project\Tirth-Patel\Zee_NewsWebApi\Zee_News_WebApi\Zee_News_WebApi\Views\NewsContents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.News.NewsCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""ContentId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zee_News_WebApi.Models.NewsContent> Html { get; private set; }
    }
}
#pragma warning restore 1591
