#pragma checksum "C:\Users\USER\source\repos\tbkk-AC\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0314b121f69fcbe9699533d7ae7cfb563c50580f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_Layout.cshtml", typeof(tbkk_AC.Pages.Shared.Pages_Shared__Layout))]
namespace tbkk_AC.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0314b121f69fcbe9699533d7ae7cfb563c50580f", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a013413f5bead4ef425658ec1420465d4244a27", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 671, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ed4068c34248cfb258889fa10e6501", async() => {
                BeginContext(43, 658, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <title>tbkk_AC</title>

    <!-- Custom fonts for this template-->
    <link href=""../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">

    <!-- Page level plugin CSS-->
    <link href=""../vendor/datatables/dataTables.bootstrap4.css"" rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""../css/sb-admin.css"" rel=""stylesheet"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(708, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(712, 6346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6498b93ea695438c954ba7fe85bb863c", async() => {
                BeginContext(732, 358, true);
                WriteLiteral(@"

    <nav class=""navbar navbar-expand navbar-dark bg-dark static-top"">

        <a class=""navbar-brand mr-1"" href=""index.html"">TBKK Company</a>

        <button class=""btn btn-link btn-sm text-white order-1 order-sm-0"" id=""sidebarToggle"" href=""#"">
            <i class=""fas fa-bars""></i>
        </button>

        <!-- Navbar Search -->
        ");
                EndContext();
                BeginContext(1090, 165, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "434ac1c5ab16467c94f31450f6de17e9", async() => {
                    BeginContext(1175, 73, true);
                    WriteLiteral("\r\n            <div class=\"input-group\">\r\n\r\n\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1255, 3312, true);
                WriteLiteral(@"

        <!-- Navbar -->
        <ul class=""navbar-nav ml-auto ml-md-0"">

            <li class=""nav-item dropdown no-arrow"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-user-circle fa-fw""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                    <p class=""dropdown-item"" href=""#"">
                        Name : Nattatida Srisa
                        \nStatus : admin
                    </p>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">Logout</a>
                </div>
            </li>
        </ul>

    </nav>

    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""sidebar navbar-nav"">
            <!--assetcontrols-->>
     ");
                WriteLiteral(@"       <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""pagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-fw fa-search""></i>
                    <span>Asset Controls</span>
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""pagesDropdown"">
                    <a class=""dropdown-item"" href=""../AssetControls/Index"">Overview</a>
                    <a class=""dropdown-item"" href=""myAsset.html"">My Asset</a>
                    <div class=""dropdown-divider""></div>
                    <h6 class=""dropdown-header"">Asset :</h6>
                    <a class=""dropdown-item"" href=""/Assets/Index"">Asset</a>
                    <a class=""dropdown-item"" href=""license.html"">License</a>
                    <a class=""dropdown-item"" href=""accessories.html"">Accessories</a>
                    <div class=""dropdown-divider""></div>
                    <h6 class=""");
                WriteLiteral(@"dropdown-header"">Managment :</h6>
                    <a class=""dropdown-item"" href=""../AssetControls/Managment"">mange</a>
                    <a class=""dropdown-item"" href=""#"">Employee</a>
                    <a class=""dropdown-item"" href=""#"">Network</a>
                    <a class=""dropdown-item"" href=""#"">Type,Category</a>
                    <a class=""dropdown-item"" href=""/Brands/Index"">Brand</a>
                    <a class=""dropdown-item"" href=""/Categorys/Index"">Category</a>
                    <a class=""dropdown-item"" href=""/Models/Index"">Model</a>
                    <a class=""dropdown-item"" href=""#"">Company</a>
                    <a class=""dropdown-item"" href=""/Departments/Index"">Department</a>
                    <a class=""dropdown-item"" href=""#"">Location</a>
                    <a class=""dropdown-item"" href=""/Suppliers/Index"">Supplier</a>

                </div>
            </li>
            <!--end assetcontrols-->>

            <li class=""nav-item"">
                <a class=""na");
                WriteLiteral("v-link\" href=\"tables.html\">\r\n                    <i class=\"fas fa-fw fa-comments\"></i>\r\n                    <span>Help Desk</span>\r\n                </a>\r\n            </li>\r\n\r\n        </ul>\r\n\r\n        <div id=\"content-wrapper\">\r\n            ");
                EndContext();
                BeginContext(4568, 12, false);
#line 109 "C:\Users\USER\source\repos\tbkk-AC\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4580, 2427, true);
                WriteLiteral(@"


            <!-- /.container-fluid -->
            <!-- Sticky Footer -->
            <footer class=""sticky-footer"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright © Your Website 2019</span>
                    </div>
                </div>
            </footer>

        </div>
        <!-- /.content-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <but");
                WriteLiteral(@"ton class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>


    <!-- Bootstrap core JavaScript-->
    <script src=""../vendor/jquery/jquery.min.js""></script>
    <script src=""../vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""../vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Page level plugin JavaScript-->
    <script src=""../vendor/chart.js/Chart.min.js""></script>
    <script src=""../vendor");
                WriteLiteral(@"/datatables/jquery.dataTables.js""></script>
    <script src=""../vendor/datatables/dataTables.bootstrap4.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""../js/sb-admin.min.js""></script>

    <!-- Demo scripts for this page-->
    <script src=""../js/demo/datatables-demo.js""></script>
    <script src=""../js/demo/chart-area-demo.js""></script>
    ");
                EndContext();
                BeginContext(7008, 41, false);
#line 170 "C:\Users\USER\source\repos\tbkk-AC\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(7049, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7058, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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