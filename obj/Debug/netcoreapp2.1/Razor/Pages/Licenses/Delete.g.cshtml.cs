#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29961e1d5aa538fcfd8d75863d59aa2e913aefb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Delete), @"mvc.1.0.razor-page", @"/Pages/Licenses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Licenses/Delete.cshtml", typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Delete), null)]
namespace tbkk_AC.Pages.Licenses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\USER\source\repos\tbkk-AC\Pages\_ViewImports.cshtml"
using tbkk_AC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29961e1d5aa538fcfd8d75863d59aa2e913aefb8", @"/Pages/Licenses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Licenses_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(94, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>License</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(263, 55, false);
#line 16 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(362, 51, false);
#line 19 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 57, false);
#line 22 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(558, 53, false);
#line 25 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(655, 56, false);
#line 28 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(755, 52, false);
#line 31 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(851, 53, false);
#line 34 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(948, 49, false);
#line 37 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1041, 54, false);
#line 40 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1139, 50, false);
#line 43 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1233, 52, false);
#line 46 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1329, 48, false);
#line 49 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1421, 55, false);
#line 52 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1520, 51, false);
#line 55 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1615, 48, false);
#line 58 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1707, 44, false);
#line 61 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1795, 50, false);
#line 64 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1889, 46, false);
#line 67 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1979, 57, false);
#line 70 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2080, 53, false);
#line 73 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2177, 63, false);
#line 76 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2284, 59, false);
#line 79 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2387, 67, false);
#line 82 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2498, 63, false);
#line 85 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2605, 61, false);
#line 88 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2666, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2710, 57, false);
#line 91 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2767, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2805, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298415d7deba4edb9e223b064c0f38c3", async() => {
                BeginContext(2825, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2835, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca5fd46e33c64fdfa227744aba66bda6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 96 "C:\Users\USER\source\repos\tbkk-AC\Pages\Licenses\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.License.LicenseID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2886, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2970, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557c5a5a031f49738aae5bba0877b079", async() => {
                    BeginContext(2992, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3008, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3021, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Licenses.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Licenses.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
