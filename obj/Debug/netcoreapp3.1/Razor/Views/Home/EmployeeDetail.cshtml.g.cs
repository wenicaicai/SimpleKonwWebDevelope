#pragma checksum "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b95d6482d1c3dc62cf2e693556a56fd78524002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeDetail), @"mvc.1.0.view", @"/Views/Home/EmployeeDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b95d6482d1c3dc62cf2e693556a56fd78524002", @"/Views/Home/EmployeeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeDetail.cshtml"
  
    ViewBag.Title = "Home 控制器下的 Employee.Detail 方法";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>欢迎!</h1>\r\n<div>这个消息来自 Home 控制器下的 Detail 的视图文件 Detail.cshtml</div>\r\n<p><a href=\"/\">返回首页</a></p>\r\n<table>\r\n    <tr>\r\n        <td>员工编号:</td>\r\n        <td>");
#nullable restore
#line 10 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeDetail.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>员工姓名:</td>\r\n        <td>");
#nullable restore
#line 14 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeDetail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n<p><a href=\"/\">返回首页</a></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
