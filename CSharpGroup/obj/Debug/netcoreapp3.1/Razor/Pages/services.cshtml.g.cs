#pragma checksum "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133160d5bcf770a0ac760a0b37fcb32032913af1"
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
#line 1 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133160d5bcf770a0ac760a0b37fcb32032913af1", @"/Pages/services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_services : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
  
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

<div class=""container-fluid"">
");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.servicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.servicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.servicesModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.servicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591