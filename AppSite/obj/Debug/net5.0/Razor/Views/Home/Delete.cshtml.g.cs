#pragma checksum "M:\obai\AspNet Core\Managers\AppSite\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7859492a1c8cdb76ef83ae5e164b5851c0a3f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
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
#line 1 "M:\obai\AspNet Core\Managers\AppSite\Views\_ViewImports.cshtml"
using AppSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\obai\AspNet Core\Managers\AppSite\Views\_ViewImports.cshtml"
using AppSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\obai\AspNet Core\Managers\AppSite\Views\_ViewImports.cshtml"
using AppModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7859492a1c8cdb76ef83ae5e164b5851c0a3f9d", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943c6993ac9128a8d7a3d9e37a27bf114f61f8ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h6>successfully deleted</h6>\r\n<table class=\"table table-responsive-lg table-bordered\">\r\n\r\n    <tr>\r\n        <td>name</td>\r\n        <td>Password</td>\r\n        <td>Email</td>\r\n        <td>Depart Id</td>\r\n        <td></td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "M:\obai\AspNet Core\Managers\AppSite\Views\Home\Delete.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "M:\obai\AspNet Core\Managers\AppSite\Views\Home\Delete.cshtml"
       Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "M:\obai\AspNet Core\Managers\AppSite\Views\Home\Delete.cshtml"
       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "M:\obai\AspNet Core\Managers\AppSite\Views\Home\Delete.cshtml"
       Write(Model.DepartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
