#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3987422fbb4b59dd088fd6b504af95f64cbdde90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Assets.Pages_Assets_Delete), @"mvc.1.0.razor-page", @"/Pages/Assets/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Assets/Delete.cshtml", typeof(tbkk_AC.Pages.Assets.Pages_Assets_Delete), null)]
namespace tbkk_AC.Pages.Assets
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3987422fbb4b59dd088fd6b504af95f64cbdde90", @"/Pages/Assets/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Assets_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(92, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Asset</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(259, 51, false);
#line 16 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(354, 47, false);
#line 19 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(401, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(445, 54, false);
#line 22 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(499, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(543, 50, false);
#line 25 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(637, 49, false);
#line 28 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(730, 45, false);
#line 31 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(775, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(819, 53, false);
#line 34 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(872, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(916, 49, false);
#line 37 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1009, 54, false);
#line 40 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1107, 50, false);
#line 43 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1201, 52, false);
#line 46 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1297, 48, false);
#line 49 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1389, 50, false);
#line 52 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1483, 46, false);
#line 55 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1573, 47, false);
#line 58 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1664, 43, false);
#line 61 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1751, 50, false);
#line 64 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1845, 46, false);
#line 67 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1935, 46, false);
#line 70 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2025, 42, false);
#line 73 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2111, 46, false);
#line 76 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2201, 42, false);
#line 79 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2287, 48, false);
#line 82 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2379, 44, false);
#line 85 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2467, 47, false);
#line 88 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2558, 43, false);
#line 91 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2645, 59, false);
#line 94 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2748, 55, false);
#line 97 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2803, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2847, 61, false);
#line 100 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2952, 57, false);
#line 103 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3053, 65, false);
#line 106 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3118, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3162, 61, false);
#line 109 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3267, 50, false);
#line 112 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(3317, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3361, 54, false);
#line 115 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Supplier.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3459, 61, false);
#line 118 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Employee_EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(3520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3564, 57, false);
#line 121 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Employee_EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(3621, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3659, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49fc9373c55e467f9c9039449abe1176", async() => {
                BeginContext(3679, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3689, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25fb2e307bfc43ab9053dd947b6403d5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 126 "C:\Users\USER\source\repos\tbkk-AC\Pages\Assets\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Asset.AssetID);

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
                BeginContext(3736, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3820, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a062fda07e9a4b3ab4bdbc847aa31709", async() => {
                    BeginContext(3842, 12, true);
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
                BeginContext(3858, 6, true);
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
            BeginContext(3871, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Assets.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Assets.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
