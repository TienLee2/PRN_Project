#pragma checksum "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5fa0f58f1420fa91fa55c0cd71d833e00661555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Index), @"mvc.1.0.view", @"/Views/Bills/Index.cshtml")]
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
#line 1 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\_ViewImports.cshtml"
using PRN_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\_ViewImports.cshtml"
using PRN_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fa0f58f1420fa91fa55c0cd71d833e00661555", @"/Views/Bills/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c92816accf3bfab306f1948e75bfb0e83e0f90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bills_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRN_Project.Models.Bill>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""table-responsive"" style=""width:80%; margin: 0 auto; margin-bottom: 24px"">
    <h1 class=""text-center"">Customer Bills</h1>
    <table class=""table"" id=""table"" >
        <thead >
            <tr class=""text-center"">
                <th>
                    ");
#nullable restore
#line 15 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ID Account\r\n                </th>\r\n                <th></th>\r\n\r\n               \r\n            </tr>\r\n        </thead>\r\n        <tbody >\r\n");
#nullable restore
#line 29 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
             foreach (var item in Model)
            {
                if (@item.IdAccount == @Context.Session.GetInt32("id"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-center\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 35 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IdAccountNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5fa0f58f1420fa91fa55c0cd71d833e006615556693", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
                                                      WriteLiteral(item.BillId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "D:\FA22\PRN211\Project\3010\PRN_Project_3010\PRN_Project\PRN_Project\Views\Bills\Index.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRN_Project.Models.Bill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
