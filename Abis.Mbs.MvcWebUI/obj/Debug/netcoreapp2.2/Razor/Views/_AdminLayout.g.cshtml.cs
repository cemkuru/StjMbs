#pragma checksum "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c9d7641918d9368b515c055adfb4a419b04c5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__AdminLayout), @"mvc.1.0.view", @"/Views/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_AdminLayout.cshtml", typeof(AspNetCore.Views__AdminLayout))]
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
#line 1 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI;

#line default
#line hidden
#line 2 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_ViewImports.cshtml"
using Abis.Mbs.MvcWebUI.Models;

#line default
#line hidden
#line 1 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c9d7641918d9368b515c055adfb4a419b04c5e", @"/Views/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49c025ac10c31b13e794665d09e67fc92ea6ce3", @"/Views/_ViewImports.cshtml")]
    public class Views__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(61, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c9d7641918d9368b515c055adfb4a419b04c5e4223", async() => {
                BeginContext(67, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(140, 13, false);
#line 7 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(153, 427, true);
                WriteLiteral(@"</title>
    <link href=""/node_modules/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />
    <script src=""/node_modules/jquery/dist/jquery.min.js""></script>
    <script src=""/node_modules/bootstrap/dist/js/bootstrap.js""></script>
    <script src=""/node_modules/jquery-validation/dist/jquery.validate.js""></script>
    <script src=""/node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(587, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(589, 2042, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c9d7641918d9368b515c055adfb4a419b04c5e6252", async() => {
                BeginContext(595, 1050, true);
                WriteLiteral(@"
    <div class=""col-md-12"">
        <nav class=""navbar navbar-default"">
            <div class=""container-fluid"">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" aria-expanded=""false"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""#"">Mbs Admin Panel</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-1"">
                    <ul class=""nav navbar-nav"">
                 ");
                WriteLiteral("       <li class=\"active\">");
                EndContext();
                BeginContext(1645, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c9d7641918d9368b515c055adfb4a419b04c5e7758", async() => {
                    BeginContext(1692, 53, true);
                    WriteLiteral("Products Store <span class=\"sr-only\">(current)</span>");
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
                BeginContext(1749, 353, true);
                WriteLiteral(@"</li>
                    </ul>
                    <ul class=""nav navbar-nav navbar-right"">
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">User <span class=""caret""></span></a>
                            ");
                EndContext();
                BeginContext(2103, 42, false);
#line 37 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
                       Write(await Component.InvokeAsync("UserSummary"));

#line default
#line hidden
                EndContext();
                BeginContext(2145, 261, true);
                WriteLiteral(@"
                        </li>
                    </ul>
                </div><!-- /.navbar-collapse -->
            </div><!-- /.container-fluid -->
        </nav>
    </div>
    <div class=""mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"">
");
                EndContext();
#line 45 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
                BeginContext(2460, 55, true);
                WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">");
                EndContext();
                BeginContext(2516, 19, false);
#line 47 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
                                                  Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(2535, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 48 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
        }

#line default
#line hidden
                BeginContext(2554, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2563, 12, false);
#line 49 "C:\Users\Cem\Desktop\Abc\Abis.Mbs.MvcWebUI\Views\_AdminLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2575, 49, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-12\"></div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2631, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
