#pragma checksum "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be81f73d2f457a47a8fc1d68b04f03f9829b11d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Checkout), @"mvc.1.0.view", @"/Views/Orders/Checkout.cshtml")]
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
#line 1 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\_ViewImports.cshtml"
using ASM_App_Dev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\_ViewImports.cshtml"
using ASM_App_Dev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
using ASM_App_Dev.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be81f73d2f457a47a8fc1d68b04f03f9829b11d", @"/Views/Orders/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed19aee8c1ab091b81fbf8214f10281f1b850cf9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckOut>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
  
    ViewData["Title"] = "Purchase";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Check Out</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Name Book
            </th>
            <th>
                Quantity
            </th>
            <th>
                Price
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
         foreach (var item in Model.orderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book.NameBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<div class=""col-md-5"" style=""float: right"">

    <div class=""rounded d-flex flex-column p-2"" style=""background-color: #f8f9fa; "">
        <div class=""p-2 me-3"">
            <h4>Order Recap</h4>
        </div>
        <div class=""p-2 d-flex"">
            <div class=""col-8"">Name: </div>
            <div class=""ms-auto"">");
#nullable restore
#line 51 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n        </div>\r\n        <div class=\"p-2 d-flex\">\r\n            <div class=\"col-8\">Address: </div>\r\n            <div class=\"ms-auto\">");
#nullable restore
#line 56 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
                            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>
        <div class=""p-2 d-flex"">
            <div class=""col-8"">Number Phone</div>
            <div class=""ms-auto"">0912256419</div>
        </div>

        <div class=""border-top px-2 mx-2""></div>
        <div class=""p-2 d-flex pt-3"">
            <div class=""col-8""><b>Total Order</b></div>
            <div class=""ms-auto""><b class=""text-success"">");
#nullable restore
#line 66 "C:\Users\minht\Desktop\appdev\ASM_App_Dev\ASM_App_Dev\Views\Orders\Checkout.cshtml"
                                                    Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</b></div>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be81f73d2f457a47a8fc1d68b04f03f9829b11d8048", async() => {
                WriteLiteral("Purchase");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckOut> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
