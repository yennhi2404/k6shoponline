#pragma checksum "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b57d26c5939a8576dcb9abd779d0473a4a794c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuLoai_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MenuLoai/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MenuLoai/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MenuLoai_Default))]
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
#line 1 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\_ViewImports.cshtml"
using MyShopK6;

#line default
#line hidden
#line 2 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\_ViewImports.cshtml"
using MyShopK6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b57d26c5939a8576dcb9abd779d0473a4a794c5", @"/Views/Shared/Components/MenuLoai/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e770d053092ef2b99ddd7a06e931c96cc669487a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuLoai_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Loai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
  
    var dsLoaiCha = Model.Where(p => p.MaLoaiCha == null);

#line default
#line hidden
            BeginContext(148, 35, true);
            WriteLiteral("\n<ul class=\"menu-items col-xs-12\">\n");
            EndContext();
#line 8 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
     foreach (var lo in dsLoaiCha)
    {
        var dsLoaiCon = Model.Where(p => p.MaLoaiCha == lo.MaLoai);

#line default
#line hidden
            BeginContext(292, 107, true);
            WriteLiteral("        <li class=\"menu-item depth-1 menucol-1-3 \">\n            <div class=\"title title_font\"> <a href=\"#\">");
            EndContext();
            BeginContext(400, 10, false);
#line 12 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
                                                  Write(lo.TenLoai);

#line default
#line hidden
            EndContext();
            BeginContext(410, 44, true);
            WriteLiteral("</a></div>\n            <ul class=\"submenu\">\n");
            EndContext();
#line 14 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
                 foreach (var loc in dsLoaiCon)
                {

#line default
#line hidden
            BeginContext(520, 87, true);
            WriteLiteral("                    <li class=\"menu-item\">\n                        <div class=\"title\"> ");
            EndContext();
            BeginContext(607, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b57d26c5939a8576dcb9abd779d0473a4a794c55783", async() => {
                BeginContext(682, 11, false);
#line 17 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
                                                                                                                 Write(loc.TenLoai);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
                                                                                             WriteLiteral(loc.MaLoai);

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
            BeginContext(697, 33, true);
            WriteLiteral("</div>\n                    </li>\n");
            EndContext();
#line 19 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(748, 32, true);
            WriteLiteral("            </ul>\n        </li>\n");
            EndContext();
#line 22 "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\Components\MenuLoai\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(786, 5, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Loai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
