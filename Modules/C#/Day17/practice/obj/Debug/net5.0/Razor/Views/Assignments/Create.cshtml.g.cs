#pragma checksum "F:\day4\Modules\C#\Day17\practice\Views\Assignments\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5dafb3613cea2124a065fa51c666347248b146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignments_Create), @"mvc.1.0.view", @"/Views/Assignments/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5dafb3613cea2124a065fa51c666347248b146", @"/Views/Assignments/Create.cshtml")]
    public class Views_Assignments_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment.Models.Assignment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\day4\Modules\C#\Day17\practice\Views\Assignments\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Assignment</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ActionCode"" class=""control-label""></label>
                <input asp-for=""ActionCode"" class=""form-control"" />
                <span asp-validation-for=""ActionCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Lastdate"" class=""control-label""></label>
                <input asp-for=""Lastdate"" class=""form-control"" />
                <span asp-validation-for=""Lastdate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AssignmentName"" class=""control-label""></label>
                <input asp-for=""AssignmentName"" class=""form-control"" />
                <span asp-validation-for=""AssignmentNa");
            WriteLiteral(@"me"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AssignementId"" class=""control-label""></label>
                <input asp-for=""AssignementId"" class=""form-control"" />
                <span asp-validation-for=""AssignementId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AssignmentSatus"" class=""control-label""></label>
                <input asp-for=""AssignmentSatus"" class=""form-control"" />
                <span asp-validation-for=""AssignmentSatus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmpId"" class=""control-label""></label>
                <select asp-for=""EmpId"" class =""form-control"" asp-items=""ViewBag.EmpId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        <");
            WriteLiteral("/form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "F:\day4\Modules\C#\Day17\practice\Views\Assignments\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment.Models.Assignment> Html { get; private set; }
    }
}
#pragma warning restore 1591
