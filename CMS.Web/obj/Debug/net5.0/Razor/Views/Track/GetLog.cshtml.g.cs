#pragma checksum "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8601f55ca96b68051346855170a6e3ef20729c0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Track_GetLog), @"mvc.1.0.view", @"/Views/Track/GetLog.cshtml")]
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
#line 1 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\_ViewImports.cshtml"
using CMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\_ViewImports.cshtml"
using CMS.Core.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\_ViewImports.cshtml"
using CMS.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\_ViewImports.cshtml"
using CMS.Core.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\_ViewImports.cshtml"
using CMS.Core.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8601f55ca96b68051346855170a6e3ef20729c0d", @"/Views/Track/GetLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc9b05f2cc233a091f977ac8fb06f2fd7919f54", @"/Views/_ViewImports.cshtml")]
    public class Views_Track_GetLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContentChangeLogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
  
    Layout = null;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>الوقت</th>\r\n        <th>من</th>\r\n        <th>الى</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 16 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
           Write(x.ChangeAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
           Write(x.Old);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 18 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
           Write(x.New);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ahmedbalousha\source\repos\CMS\CMS.Web\Views\Track\GetLog.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContentChangeLogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591