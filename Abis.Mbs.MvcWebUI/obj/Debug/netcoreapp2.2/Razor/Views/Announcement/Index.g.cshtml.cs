#pragma checksum "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f506d1a1f1ff826e15c27763458635712fd56b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcement_Index), @"mvc.1.0.view", @"/Views/Announcement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Announcement/Index.cshtml", typeof(AspNetCore.Views_Announcement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f506d1a1f1ff826e15c27763458635712fd56b0e", @"/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ea9bc2fdf300129d673660ca2a80d7b5cd8e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abis.Mbs.MvcWebUI.Models.AnnouncementListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(106, 137, true);
            WriteLiteral("\r\n<div>\r\n    <table class=\"table table-responsive\">\r\n        <tr>\r\n            <td>Date</td>\r\n            <td>Title</td>\r\n        </tr>\r\n");
            EndContext();
#line 12 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"
         foreach (var announcement in Model.Announcements)
        {

#line default
#line hidden
            BeginContext(314, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(353, 54, false);
#line 15 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"
               Write(Html.DisplayFor(modelItem => announcement.ACreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(407, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(434, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f506d1a1f1ff826e15c27763458635712fd56b0e4665", async() => {
                BeginContext(502, 19, false);
#line 16 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"
                                                                                  Write(announcement.ATitle);

#line default
#line hidden
                EndContext();
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
#line 16 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"
                                             WriteLiteral(announcement.AnnouncementId);

#line default
#line hidden
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
            EndContext();
            BeginContext(525, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
            BeginContext(614, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(966, 23, true);
            WriteLiteral("\r\n\r\n            </tr>\r\n");
            EndContext();
#line 25 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Announcement\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1002, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abis.Mbs.MvcWebUI.Models.AnnouncementListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
