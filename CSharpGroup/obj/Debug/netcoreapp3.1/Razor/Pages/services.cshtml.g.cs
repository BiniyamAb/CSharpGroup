#pragma checksum "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8a8c9a3df487d3910194261832dc3f2cb80e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpGroup.Pages.Pages_services), @"mvc.1.0.razor-page", @"/Pages/services.cshtml")]
namespace CSharpGroup.Pages
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
#line 1 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8a8c9a3df487d3910194261832dc3f2cb80e0c", @"/Pages/services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_services : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/EachService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
  
    ViewData["Title"] = "services";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<div class=""container-fluid"" id=""con"">
    <div class=""row"" id=""row"">
        <div class=""col-md-12 col text-center"">-->

            <!--Search bar-->
            <!--<div class=""container h-100"">
                <div class=""d-flex justify-content-center h-100"">
                    <div class=""search"" id=""row"">
                        <div class=""col-md-10"">
                            <input class=""search_input form-control"" list=""datalistOptions"" type=""text"" name="""" placeholder="" Search Services here..."" id=""searchBar"">
                        </div>
                        <div class=""col-md-2"">
                            <button class=""btn btn-light"" id=""searchBtn""><i class=""fas fa-search""></i></button>
                        </div>
                    </div>
                    <div id=""categoryDropDown""></div>
                </div>
            </div>-->
            <!--search bar end-->

        <!--</div>
    </div>
</div>-->


<div class=""container-fluid"" id=""con"">
");
            WriteLiteral(@"    <div class=""row"" id=""row-row"">
        <div class=""col-md-12 col text-center"">

            <!--Search bar-->
            <div class=""container h-100"">
                <div class=""d-flex justify-content-center h-100"">
                    <div class=""row"" id=""row-search"">
                        <div class=""col-md-10"">
                            <input class=""search_input form-control"" list=""datalistOptions"" type=""text""");
            BeginWriteAttribute("name", " name=\"", 1550, "\"", 1557, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder="" Search Services here..."" id=""searchBar"">
                        </div>
                        <div class=""col-md-2"">
                            <button class=""btn btn-light"" id=""searchBtn""><i class=""fas fa-search""></i></button>
                        </div>
                    </div>
                    <div id=""categoryDropDown""></div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container d-flex px-5 mx-5 py-3row"">
    <h1 class=""align-self-center text-center col-md-12 mt-4"">Services We Have Got</h1>
</div>

<div class=""container my-3 d-flex align-items-center"">
    <div class=""container row mx-2"">
");
#nullable restore
#line 60 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
         foreach (var item in Model.categoryList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-md-4 p-3\" style=\"width: 20rem; border:none;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2409, "\"", 2426, 1);
#nullable restore
#line 63 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
WriteAttributeValue("", 2415, item.Image, 2415, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 15rem\">\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd8a8c9a3df487d3910194261832dc3f2cb80e0c6603", async() => {
                WriteLiteral("<p class=\"card-text text-center services-a-tag\">");
#nullable restore
#line 65 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
                                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
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
#nullable restore
#line 65 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 68 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.ServicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.ServicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.ServicesModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.ServicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
