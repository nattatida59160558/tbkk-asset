#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7095f5c30412ff61b99189abcfb170d299a3a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Details.cshtml", typeof(tbkk_AC.Pages.Employees.Pages_Employees_Details), null)]
namespace tbkk_AC.Pages.Employees
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7095f5c30412ff61b99189abcfb170d299a3a8e", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 54, false);
#line 15 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 50, false);
#line 18 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 53, false);
#line 21 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 49, false);
#line 24 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 51, false);
#line 27 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(653, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(697, 47, false);
#line 30 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(744, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(788, 50, false);
#line 33 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(838, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(882, 46, false);
#line 36 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(972, 49, false);
#line 39 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1065, 45, false);
#line 42 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1154, 49, false);
#line 45 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1247, 45, false);
#line 48 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1336, 50, false);
#line 51 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1430, 46, false);
#line 54 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1520, 49, false);
#line 57 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1613, 45, false);
#line 60 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1702, 49, false);
#line 63 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1795, 45, false);
#line 66 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1884, 51, false);
#line 69 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1979, 47, false);
#line 72 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2070, 52, false);
#line 75 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Company));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2166, 54, false);
#line 78 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Company.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2264, 55, false);
#line 81 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2363, 66, false);
#line 84 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Department.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2473, 53, false);
#line 87 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2570, 62, false);
#line 90 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Location.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2676, 57, false);
#line 93 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeType));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2777, 68, false);
#line 96 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeType.EmployeeTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2889, 53, false);
#line 99 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Position));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2986, 60, false);
#line 102 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Position.PositionID));

#line default
#line hidden
            EndContext();
            BeginContext(3046, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3093, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74dace4cbf7d40f2a136ea264bbaa609", async() => {
                BeginContext(3156, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Details.cshtml"
                           WriteLiteral(Model.Employee.EmployeeID);

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
            BeginContext(3164, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3172, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f317b18022d4feebbcf621625219003", async() => {
                BeginContext(3194, 12, true);
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
            BeginContext(3210, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
