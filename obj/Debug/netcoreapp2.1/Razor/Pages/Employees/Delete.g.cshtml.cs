#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fe0199e95e93782d03a854c053ee51fb61b3d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Employees.Pages_Employees_Delete), @"mvc.1.0.razor-page", @"/Pages/Employees/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Delete.cshtml", typeof(tbkk_AC.Pages.Employees.Pages_Employees_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe0199e95e93782d03a854c053ee51fb61b3d5f", @"/Pages/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(95, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 54, false);
#line 16 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(363, 50, false);
#line 19 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 53, false);
#line 22 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(510, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(554, 49, false);
#line 25 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(603, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(647, 51, false);
#line 28 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(742, 47, false);
#line 31 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(789, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(833, 50, false);
#line 34 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(927, 46, false);
#line 37 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1017, 49, false);
#line 40 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1110, 45, false);
#line 43 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1199, 49, false);
#line 46 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1292, 45, false);
#line 49 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1381, 50, false);
#line 52 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1475, 46, false);
#line 55 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1565, 49, false);
#line 58 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1658, 45, false);
#line 61 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1747, 49, false);
#line 64 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1840, 45, false);
#line 67 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1929, 51, false);
#line 70 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2024, 47, false);
#line 73 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2115, 52, false);
#line 76 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Company));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2211, 54, false);
#line 79 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Company.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2309, 55, false);
#line 82 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2364, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2408, 66, false);
#line 85 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Department.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2518, 53, false);
#line 88 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2571, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2615, 62, false);
#line 91 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Location.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2721, 57, false);
#line 94 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeType));

#line default
#line hidden
            EndContext();
            BeginContext(2778, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2822, 68, false);
#line 97 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeType.EmployeeTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(2890, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2934, 53, false);
#line 100 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Position));

#line default
#line hidden
            EndContext();
            BeginContext(2987, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3031, 60, false);
#line 103 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Position.PositionID));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3129, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a60ca7a85d5447c99cef7a8aa4abf6a", async() => {
                BeginContext(3149, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3159, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0c7043ec3294a5aadd86e25f93f5fe5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 108 "C:\Users\USER\source\repos\tbkk-AC\Pages\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Employee.EmployeeID);

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
                BeginContext(3212, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3296, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9406c37a01d04307b37e5dea3c5a544b", async() => {
                    BeginContext(3318, 12, true);
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
                BeginContext(3334, 6, true);
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
            BeginContext(3347, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Employees.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Employees.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
