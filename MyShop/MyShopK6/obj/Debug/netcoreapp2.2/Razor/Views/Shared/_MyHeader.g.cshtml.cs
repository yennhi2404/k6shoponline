#pragma checksum "C:\Users\DRAGON\Downloads\eShop-master\eShop-master\eShop-master\MyShop\MyShopK6\Views\Shared\_MyHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bd481eaa90a11403ad292f2e8d52aaf704119a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MyHeader), @"mvc.1.0.view", @"/Views/Shared/_MyHeader.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MyHeader.cshtml", typeof(AspNetCore.Views_Shared__MyHeader))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd481eaa90a11403ad292f2e8d52aaf704119a0", @"/Views/Shared/_MyHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e770d053092ef2b99ddd7a06e931c96cc669487a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MyHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ShopMart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("ShopMart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/products/product-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("html Template"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("65"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2503, true);
            WriteLiteral(@"
<div class=""header-container"">
    <div class=""header-top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-4 col-md-4 col-xs-12"">
                    <!-- Default Welcome Message -->
                    <div class=""welcome-msg hidden-xs hidden-sm"">Welcome MyStore! </div>
                    <span id=""dongHo"" class=""text-danger""></span>
                </div>

                <!-- top links -->
                <div class=""headerlinkmenu col-md-8 col-sm-8 col-xs-12"">
                    <span class=""phone  hidden-xs hidden-sm""> <i class=""fa-mobile""></i>Call Us: (+84) 028393 22735</span>
                    <ul class=""links"">
                        <li class=""hidden-xs""><a title=""Help Center"" href=""#""><span>Help Center</span></a></li>
                        <li><a title=""Store Locator"" href=""#""><span>Store Locator</span></a></li>
                        <li><a title=""Checkout"" href=""checkout.html""><span>Checkout</span></a></li>
                        <li>
   ");
            WriteLiteral(@"                         <div class=""dropdown"">
                                <a class=""current-open"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" href=""#""><span>My Account</span> <i class=""fa fa-angle-down""></i></a>
                                <ul class=""dropdown-menu"" role=""menu"">
                                    <li><a href=""account_page.html"">Account</a></li>
                                    <li><a href=""wishlist.html"">Wishlist</a></li>
                                    <li><a href=""orders_list.html"">Order Tracking</a></li>
                                    <li><a href=""/Home/About"">About us</a></li>
                                    <li class=""divider""></li>
                                    <li><a href=""/KhachHang/Login"">Log In</a></li>
                                    <li><a href=""/KhachHang/Register"">Register</a></li>
                                </ul>
                            </div>
                        </li>
                        <li><a title=""l");
            WriteLiteral(@"ogin"" href=""/KhachHang/Login""><span>Login</span></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- header inner -->
    <div class=""header-inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-3 col-xs-12 jtv-logo-block"">

                    <!-- Header Logo -->
                    <div class=""logo""><a title=""e-commerce"" href=""index.html"">");
            EndContext();
            BeginContext(2572, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bd481eaa90a11403ad292f2e8d52aaf704119a08493", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2633, 261, true);
            WriteLiteral(@"</a> </div>
                </div>
                <div class=""col-xs-12 col-sm-5 col-md-6 jtv-top-search"">

                    <!-- Search -->

                    <div class=""top-search"">
                        <div id=""search"">
                            ");
            EndContext();
            BeginContext(2894, 1469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a010098", async() => {
                BeginContext(2900, 205, true);
                WriteLiteral("\n                                <div class=\"input-group\">\n                                    <select class=\"cate-dropdown hidden-xs hidden-sm\" name=\"category_id\">\n                                        ");
                EndContext();
                BeginContext(3105, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a010694", async() => {
                    BeginContext(3113, 14, true);
                    WriteLiteral("All Categories");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3136, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3177, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a011998", async() => {
                    BeginContext(3185, 5, true);
                    WriteLiteral("women");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3199, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3240, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a013292", async() => {
                    BeginContext(3248, 24, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Chair ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3281, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3322, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a014606", async() => {
                    BeginContext(3330, 28, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Decoration");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3367, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3408, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a015924", async() => {
                    BeginContext(3416, 22, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Lamp");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3447, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3488, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a017236", async() => {
                    BeginContext(3496, 27, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Handbags ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3532, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3573, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a018553", async() => {
                    BeginContext(3581, 24, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Sofas ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3614, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3655, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a019867", async() => {
                    BeginContext(3663, 28, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Essential ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3700, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3741, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a021185", async() => {
                    BeginContext(3749, 3, true);
                    WriteLiteral("Men");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3761, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3802, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a022477", async() => {
                    BeginContext(3810, 11, true);
                    WriteLiteral("Electronics");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3830, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3871, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a023778", async() => {
                    BeginContext(3879, 26, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Mobiles ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3914, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(3955, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd481eaa90a11403ad292f2e8d52aaf704119a025094", async() => {
                    BeginContext(3963, 36, true);
                    WriteLiteral("&nbsp;&nbsp;&nbsp;Music &amp; Audio ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4008, 348, true);
                WriteLiteral(@"
                                    </select>
                                    <input type=""text"" class=""form-control"" placeholder=""Bạn tìm gì..."" name=""search"">
                                    <button class=""btn-search"" type=""button""><i class=""fa fa-search""></i></button>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4363, 1416, true);
            WriteLiteral(@"
                        </div>
                    </div>

                    <!-- End Search -->

                </div>
                <div class=""col-xs-12 col-sm-4 col-md-3 top-cart"">
                    <div class=""link-wishlist""> <a href=""#""> <i class=""icon-heart icons""></i><span> Wishlist</span></a> </div>
                    <!-- top cart -->
                    <div class=""top-cart-contain"">
                        <div class=""mini-cart"">
                            <div data-toggle=""dropdown"" data-hover=""dropdown"" class=""basket dropdown-toggle"">
                                <a href=""/Cart"">
                                    <div class=""cart-icon""><i class=""icon-basket-loaded icons""></i><span class=""cart-total"">3</span></div>
                                    <div class=""shoppingcart-inner hidden-xs""><span class=""cart-title"">Giỏ hàng</span> </div>
                                </a>
                            </div>
                            <div>
                                <div cl");
            WriteLiteral(@"ass=""top-cart-content"">
                                    <div class=""block-subtitle hidden"">Recently added items</div>
                                    <ul id=""cart-sidebar"" class=""mini-products-list"">
                                        <li class=""item odd"">
                                            <a href=""shopping_cart.html"" title=""Product title here"" class=""product-image"">");
            EndContext();
            BeginContext(5779, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bd481eaa90a11403ad292f2e8d52aaf704119a029301", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5853, 750, true);
            WriteLiteral(@"</a>
                                            <div class=""product-details"">
                                                <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""pe-7s-trash""></i></a>
                                                <p class=""product-name""><a href=""shopping_cart.html"">Lorem ipsum dolor sit amet Consectetur</a> </p>
                                                <strong>1</strong> x <span class=""price"">$20.00</span>
                                            </div>
                                        </li>
                                        <li class=""item even"">
                                            <a href=""shopping_cart.html"" title=""Product title here"" class=""product-image"">");
            EndContext();
            BeginContext(6603, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bd481eaa90a11403ad292f2e8d52aaf704119a031412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6677, 755, true);
            WriteLiteral(@"</a>
                                            <div class=""product-details"">
                                                <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""pe-7s-trash""></i></a>
                                                <p class=""product-name""><a href=""shopping_cart.html"">Consectetur utes anet adipisicing elit</a> </p>
                                                <strong>1</strong> x <span class=""price"">$230.00</span>
                                            </div>
                                        </li>
                                        <li class=""item last odd"">
                                            <a href=""shopping_cart.html"" title=""Product title here"" class=""product-image"">");
            EndContext();
            BeginContext(7432, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bd481eaa90a11403ad292f2e8d52aaf704119a033528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7506, 1394, true);
            WriteLiteral(@"</a>
                                            <div class=""product-details"">
                                                <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""pe-7s-trash""></i></a>
                                                <p class=""product-name""><a href=""shopping_cart.html"">Sed do eiusmod tempor incidist</a> </p>
                                                <strong>2</strong> x <span class=""price"">$420.00</span>
                                            </div>
                                        </li>
                                    </ul>
                                    <div class=""top-subtotal"">Subtotal: <span class=""price"">$520.00</span></div>
                                    <div class=""actions"">
                                        <button class=""btn-checkout"" type=""button"" onClick=""location.href='checkout.html'""><i class=""fa fa-check""></i><span>Checkout</span></button>
                                        <button class=""view-cart"" type=""");
            WriteLiteral(@"button"" onClick=""location.href='shopping_cart.html'""><i class=""fa fa-shopping-cart""></i><span>View Cart</span></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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