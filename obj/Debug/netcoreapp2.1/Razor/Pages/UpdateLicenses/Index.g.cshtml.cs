#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb8cd066fb90e4c279c6c001bdf95ecc90ce646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UpdateLicenses.Pages_UpdateLicenses_Index), @"mvc.1.0.razor-page", @"/Pages/UpdateLicenses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UpdateLicenses/Index.cshtml", typeof(tbkk_AC.Pages.UpdateLicenses.Pages_UpdateLicenses_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb8cd066fb90e4c279c6c001bdf95ecc90ce646", @"/Pages/UpdateLicenses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpdateLicenses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce94ca1bc455436f8e6f3ca85bf7fc0a", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 58, false);
#line 17 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Date));

#line default
#line hidden
            EndContext();
            BeginContext(313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(369, 65, false);
#line 20 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 67, false);
#line 23 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 66, false);
#line 26 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 63, false);
#line 29 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(854, 64, false);
#line 32 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(918, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(974, 62, false);
#line 35 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1092, 65, false);
#line 38 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1213, 58, false);
#line 41 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Note));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1327, 60, false);
#line 44 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1443, 67, false);
#line 47 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1566, 73, false);
#line 50 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1695, 77, false);
#line 53 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1828, 71, false);
#line 56 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1955, 71, false);
#line 59 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Update_License[0].License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
 foreach (var item in Model.Update_License) {

#line default
#line hidden
            BeginContext(2159, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2208, 39, false);
#line 68 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2303, 46, false);
#line 71 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2405, 48, false);
#line 74 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(2453, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2509, 47, false);
#line 77 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2612, 44, false);
#line 80 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2712, 45, false);
#line 83 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2813, 43, false);
#line 86 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2856, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2912, 46, false);
#line 89 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(2958, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3014, 39, false);
#line 92 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3053, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3109, 41, false);
#line 95 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3150, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3206, 48, false);
#line 98 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3310, 54, false);
#line 101 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3364, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3420, 58, false);
#line 104 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3478, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3534, 52, false);
#line 107 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3586, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3642, 52, false);
#line 110 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3694, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3749, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92b72dae9384d6aab85a304d4e4d5a9", async() => {
                BeginContext(3807, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
                                       WriteLiteral(item.UpdateLicenseID);

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
            BeginContext(3815, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3835, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78287316c6f1439896f02906ccdd583b", async() => {
                BeginContext(3896, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
                                          WriteLiteral(item.UpdateLicenseID);

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
            BeginContext(3907, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3927, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24288c41e0db45139e2a312438b56270", async() => {
                BeginContext(3987, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 115 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
                                         WriteLiteral(item.UpdateLicenseID);

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
            BeginContext(3997, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 118 "C:\Users\USER\source\repos\tbkk-AC\Pages\UpdateLicenses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4036, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UpdateLicenses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenses.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UpdateLicenses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
