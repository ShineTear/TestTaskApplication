#pragma checksum "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f309b77953fb18e4b697bc4015b432bff0a304f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_AbscenceList_Default), @"mvc.1.0.view", @"/Views/Home/Components/AbscenceList/Default.cshtml")]
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
#line 1 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\_ViewImports.cshtml"
using TestApplicationForCentralBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\_ViewImports.cshtml"
using TestApplicationForCentralBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f309b77953fb18e4b697bc4015b432bff0a304f", @"/Views/Home/Components/AbscenceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a8c6ad1cc8a6546311b64f6c0cb48fc0dfcc8ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_AbscenceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AbsenceReportModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\" id=\"AbsenceReportTable\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 5 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 8 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeePosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAbsence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeAbsence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeePosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateAbsence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimeAbsence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Marishka\source\repos\TestApplicationForCentralBank\Views\Home\Components\AbscenceList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AbsenceReportModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591