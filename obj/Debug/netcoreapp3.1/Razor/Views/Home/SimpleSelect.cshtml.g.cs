#pragma checksum "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032f4a5cdf285be797bc29d672b9aaf9a09dd37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SimpleSelect), @"mvc.1.0.view", @"/Views/Home/SimpleSelect.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032f4a5cdf285be797bc29d672b9aaf9a09dd37e", @"/Views/Home/SimpleSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SimpleSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleKonwWebDevelope.Models.TestMode<int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
  
    ViewBag.Title = "简单排序算法";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <table>\r\n        <tr>\r\n");
#nullable restore
#line 8 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
             foreach (var valData in Model.BeforeValModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 11 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
               Write(valData);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 13 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 16 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
             foreach (var valData in Model.ValModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 19 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
               Write(valData);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 21 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\SimpleSelect.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleKonwWebDevelope.Models.TestMode<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
