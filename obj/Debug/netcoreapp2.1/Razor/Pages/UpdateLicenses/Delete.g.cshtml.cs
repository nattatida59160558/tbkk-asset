#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc14bcd9fec401b350f446b23b03a925647937d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UpdateLicenses.Pages_UpdateLicenses_Delete), @"mvc.1.0.razor-page", @"/Pages/UpdateLicenses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UpdateLicenses/Delete.cshtml", typeof(tbkk_AC.Pages.UpdateLicenses.Pages_UpdateLicenses_Delete), null)]
namespace tbkk_AC.Pages.UpdateLicenses
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc14bcd9fec401b350f446b23b03a925647937d", @"/Pages/UpdateLicenses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpdateLicenses_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(100, 175, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Update_License</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(276, 55, false);
#line 16 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(375, 51, false);
#line 19 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(470, 62, false);
#line 22 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(576, 58, false);
#line 25 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(678, 64, false);
#line 28 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 60, false);
#line 31 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(846, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(890, 63, false);
#line 34 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(997, 59, false);
#line 37 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1100, 60, false);
#line 40 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1204, 56, false);
#line 43 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1304, 61, false);
#line 46 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1365, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1409, 57, false);
#line 49 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1510, 59, false);
#line 52 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1613, 55, false);
#line 55 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1712, 62, false);
#line 58 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1818, 58, false);
#line 61 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1920, 55, false);
#line 64 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2019, 51, false);
#line 67 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2114, 57, false);
#line 70 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2215, 53, false);
#line 73 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2312, 64, false);
#line 76 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2420, 60, false);
#line 79 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2524, 70, false);
#line 82 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2594, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2638, 66, false);
#line 85 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2748, 74, false);
#line 88 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2866, 70, false);
#line 91 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2980, 68, false);
#line 94 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3048, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3092, 64, false);
#line 97 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3156, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3200, 68, false);
#line 100 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3312, 64, false);
#line 103 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3376, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3414, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45194c4854f480eb61d0dee9feced23", async() => {
                BeginContext(3434, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3444, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81653dd3f4364bf48e41bbfa2b9e011e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 108 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Update_License.UpdateLicenseID);

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
                BeginContext(3508, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3592, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "350407c4708042a69afdb5ff48e2fc20", async() => {
                    BeginContext(3614, 12, true);
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
                BeginContext(3630, 6, true);
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
            BeginContext(3643, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UpdateLicenses.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenses.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenses.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UpdateLicenses.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
