#pragma checksum "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d93fb20a25133a16c53aea441350a592731e73a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeCreate), @"mvc.1.0.view", @"/Views/Home/EmployeeCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d93fb20a25133a16c53aea441350a592731e73a", @"/Views/Home/EmployeeCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleDBContext.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>添加员工</h1>\r\n");
#nullable restore
#line 8 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 11 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
   Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <input type=\"submit\" value=\"保存\"/>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\.netCore\ClearProject\SimpleKonwWebDevelope\Views\Home\EmployeeCreate.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleDBContext.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
