#pragma checksum "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f45930827b68a1d5583877890bb0942f6daa580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bills_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Bills/Details.cshtml")]
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
#line 1 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\_ViewImports.cshtml"
using PRN_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\_ViewImports.cshtml"
using PRN_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f45930827b68a1d5583877890bb0942f6daa580", @"/Areas/Admin/Views/Bills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c92816accf3bfab306f1948e75bfb0e83e0f90", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Bills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRN_Project.Models.Bill>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
  
    ViewData["Title"] = "Detail Bill #" + Model.BillId;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<Detail> details = ViewBag.ChiTiet;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<table id=\"table\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID Product</th>\r\n\r\n            <th>Price</th>\r\n            <th>Amount</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
         if (details != null && details.Count() > 0)
        {
            int i = 1;
            foreach (var item in details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 30 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
                   Write(item.IdProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 32 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "D:\Study\PRN211\Project\PRN_Project\3010\3010\PRN_Project_3010\PRN_Project\PRN_Project\Areas\Admin\Views\Bills\Details.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRN_Project.Models.Bill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
