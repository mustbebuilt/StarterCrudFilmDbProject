#pragma checksum "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae0ee3e2d67b5a1366fe5286523f91e19fdbdec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManageCart), @"mvc.1.0.view", @"/Views/Home/ManageCart.cshtml")]
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
#line 1 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/_ViewImports.cshtml"
using MyFilmMVCV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/_ViewImports.cshtml"
using MyFilmMVCV1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0ee3e2d67b5a1366fe5286523f91e19fdbdec9", @"/Views/Home/ManageCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6783fa0fdf0f223c7a9574b89b3209b87f8a15c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManageCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
  
    ViewData["Title"] = "Manage Cart";
    ViewData["PageHeading"] = "Manage Cart";
    decimal cartTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <section class=\"wrap\">\r\n\r\n        <h3 class=\"fullWidth\">Shopping Cart</h3>\r\n\r\n\r\n\r\n");
#nullable restore
#line 14 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
         if (Model.Count == 0)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p>Shopping Cart Empty.</p>\r\n            </div>\r\n");
#nullable restore
#line 20 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 24 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
         if (ViewBag.msg != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"msg\">");
#nullable restore
#line 26 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                  Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""fullCart"">
            <tr>
                <th>ID</th>
                <th>Film</th>
                <th>Quantity</th>
                <th>Price</th>
                <th>Cost</th>
                <th></th>
            </tr>


");
#nullable restore
#line 39 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
             foreach (var item in Model)
            {

                cartTotal += item.OrderQuantity * item.FilmPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 44 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                   Write(item.FilmID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                   Write(item.FilmTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                   Write(item.OrderQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>&pound;");
#nullable restore
#line 47 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                           Write(item.FilmPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>&pound;");
#nullable restore
#line 48 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                           Write((item.OrderQuantity * item.FilmPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae0ee3e2d67b5a1366fe5286523f91e19fdbdec97453", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"FilmID\" id=\"FilmID\"");
                BeginWriteAttribute("value", " value=\"", 1370, "\"", 1390, 1);
#nullable restore
#line 51 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
WriteAttributeValue("", 1378, item.FilmID, 1378, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" value=\"Delete\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>&pound;");
#nullable restore
#line 62 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"
                      Write(cartTotal.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 68 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/ManageCart.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </section>\r\n");
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
