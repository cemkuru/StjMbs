#pragma checksum "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Shared\Components\UserSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43518e09a3986362e87df56569036ebcd09e2036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_UserSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43518e09a3986362e87df56569036ebcd09e2036", @"/Views/Shared/Components/UserSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ea9bc2fdf300129d673660ca2a80d7b5cd8e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abis.Mbs.MvcWebUI.Models.UserDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 30, true);
            WriteLiteral("\r\n<ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 4 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Shared\Components\UserSummary\Default.cshtml"
     if (!String.IsNullOrEmpty(Model.UserName))
    {

#line default
#line hidden
            BeginContext(140, 37, true);
            WriteLiteral("        <li>\r\n            <a>Welcome ");
            EndContext();
            BeginContext(178, 14, false);
#line 7 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Shared\Components\UserSummary\Default.cshtml"
                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(192, 47, true);
            WriteLiteral("</a>\r\n        </li>\r\n        <li>\r\n            ");
            EndContext();
            BeginContext(239, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43518e09a3986362e87df56569036ebcd09e20364836", async() => {
                BeginContext(287, 7, true);
                WriteLiteral("Log Off");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(298, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 12 "D:\StajProjesi\Abis.Mbs.MvcWebUI\Views\Shared\Components\UserSummary\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(322, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abis.Mbs.MvcWebUI.Models.UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
