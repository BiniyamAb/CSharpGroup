#pragma checksum "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3843d63e65c44b8db53471927d816d2197d28ab3"
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
#line 1 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3843d63e65c44b8db53471927d816d2197d28ab3", @"/Pages/services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_services : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
  
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
#nullable restore
#line 56 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
     foreach (var item in Model.categoryList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 2154, "\"", 2171, 1);
#nullable restore
#line 59 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
WriteAttributeValue("", 2160, item.Image, 2160, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
#nullable restore
#line 61 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\services.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.ServicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.ServicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.ServicesModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.ServicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
