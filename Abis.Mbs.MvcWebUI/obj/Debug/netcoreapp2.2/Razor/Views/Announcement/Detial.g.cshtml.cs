#pragma checksum "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Detial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1f7d2ca2187487e6e6348c815b93f924b0fb26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcement_Detial), @"mvc.1.0.view", @"/Views/Announcement/Detial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Announcement/Detial.cshtml", typeof(AspNetCore.Views_Announcement_Detial))]
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
#line 1 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI;

#line default
#line hidden
#line 2 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI.Models;

#line default
#line hidden
#line 4 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1f7d2ca2187487e6e6348c815b93f924b0fb26", @"/Views/Announcement/Detial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ea9bc2fdf300129d673660ca2a80d7b5cd8e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_Detial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abis.Mbs.MvcWebUI.Models.AnnouncementViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Detial.cshtml"
  
    ViewData["Title"] = "Detial";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 31, true);
            WriteLiteral("\r\n<h1></h1>\r\n\r\n<div>\r\n    <h4> ");
            EndContext();
            BeginContext(173, 51, false);
#line 12 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Detial.cshtml"
    Write(Html.DisplayFor(model => model.Announcement.ATitle));

#line default
#line hidden
            EndContext();
            BeginContext(224, 41, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            EndContext();
            BeginContext(628, 44, true);
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(673, 56, false);
#line 25 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Detial.cshtml"
       Write(Html.DisplayFor(model => model.Announcement.ACreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(729, 61, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 57, false);
#line 28 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Detial.cshtml"
       Write(Html.DisplayFor(model => model.Announcement.ADescription));

#line default
#line hidden
            EndContext();
            BeginContext(848, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(990, 28, true);
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(1109, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1113, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1f7d2ca2187487e6e6348c815b93f924b0fb265566", async() => {
                BeginContext(1135, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1151, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abis.Mbs.MvcWebUI.Models.AnnouncementViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
