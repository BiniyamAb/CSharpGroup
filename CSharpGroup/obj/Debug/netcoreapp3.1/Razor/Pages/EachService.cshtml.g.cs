#pragma checksum "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\EachService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3f3334fb00f2077a4bc1f1ba7e17deb6ffff16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpGroup.Pages.Pages_EachService), @"mvc.1.0.razor-page", @"/Pages/EachService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3f3334fb00f2077a4bc1f1ba7e17deb6ffff16", @"/Pages/EachService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EachService : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\EachService.cshtml"
  
    ViewData["Title"] = "Service";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc3f3334fb00f2077a4bc1f1ba7e17deb6ffff163517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\EachService.cshtml"
                     WriteLiteral(Url.Content("~/css/eachService.css"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("href", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\hp\source\repos\CSharpGroup\CSharpGroup\Pages\EachService.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid cont"" id=""cont"">
    <div class=""row row"">
        <div class=""col-md-12 col text-center"">
            <div class=""middle  mx-auto"">
                <h2>Find help now</h2>
                <p>Choose the right person for you and get your task done efficently!</p>
                <div class=""container chooseBtn"">
                    <a href=""chooseAProvider.html?id=1621502754783"" class=""btn btn-outline-secondary help"">Find help now</a>
                </div>
            </div>
        </div>

    </div>

</div>

<div class=""container cont2"">
    <h3 class=""title"" id=""eachServiceTitle""></h3>


    <div class=""row row2"">
        <h1>How it works</h1>
        <div class=""container-fluid rowabout"">
            <div class=""row text-center"">
                <div class=""col-lg-4 "">
                    <!-- <svg class=""bd-placeholder-img rounded-circle"" width=""140"" height=""140"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""");
            WriteLiteral(" role=\"img\" aria-label=\"Placeholder: 140x140\"><title>Placeholder</title><rect width=\"100%\" height=\"100%\" fill=\"#777\"/><text x=\"50%\" y=\"50%\" fill=\"#777\" dy=\".3em\">140x140</text></svg> -->\r\n                    <img class=\"how-it-works__step-img\"");
            BeginWriteAttribute("alt", " alt=\"", 1483, "\"", 1489, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_2x.png"" data-srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_3x.png 3x"" src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_2x.png"" srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_1_3x.png 3x"">
                    <h4>1. Pick Your Task</h4>
                    <p>Describe the task you want done,where you want it ");
            WriteLiteral(@"done and the convenient time for you.</p>
                    <!-- <p><a class=""btn btn-secondary"" href=""#"" role=""button"">View details &raquo;</a></p> -->
                </div><!-- /.col-lg-4 -->
                <div class=""col-lg-4 "">
                    <!-- <svg class=""bd-placeholder-img rounded-circle"" width=""140"" height=""140"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: 140x140""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#777""/><text x=""50%"" y=""50%"" fill=""#777"" dy="".3em"">140x140</text></svg> -->
                    <img class=""how-it-works__step-img""");
            BeginWriteAttribute("alt", " alt=\"", 3184, "\"", 3190, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_2x.png"" data-srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_3x.png 3x"" src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_2x.png"" srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_2_3x.png 3x"">
                    <h4>2. Choose Your Provider</h4>
                    <p>Browse through our list excellent provider a");
            WriteLiteral(@"nd make your choice by skills,reviews and price.</p>
                    <!-- <p><a class=""btn btn-secondary"" href=""#"" role=""button"">View details &raquo;</a></p> -->
                </div><!-- /.col-lg-4 -->
                <div class=""col-lg-4 colfacts"">
                    <!-- <svg class=""bd-placeholder-img rounded-circle"" width=""140"" height=""140"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: 140x140""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#777""/><text x=""50%"" y=""50%"" fill=""#777"" dy="".3em"">140x140</text></svg> -->
                    <img class=""how-it-works__step-img""");
            BeginWriteAttribute("alt", " alt=\"", 4904, "\"", 4910, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_2x.png"" data-srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_3x.png 3x"" src=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_2x.png"" srcset=""https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_1.png 1x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_2x.png 2x, https://res.cloudinary.com/taskrabbit-com/image/upload/f_auto/q_auto/v1573737162/marketing/step_3_3x.png 3x"">
                    <h4>3. Get It Done</h4>
                    <p>Your provider will show up and get the job done. Pay ");
            WriteLiteral(@"securely and leave a review.</p>
                    <!-- <p><a class=""btn btn-secondary"" href=""#"" role=""button"">View details &raquo;</a></p> -->
                </div>
            </div>

        </div>

    </div>


    <div class=""top-content"">
        <div class=""container-fluid "">
            <h2>Check out Some Providers</h2>
            <div id=""carousel-example"" class=""carousel slide contprof"" data-ride=""carousel"">
                <div class=""carousel-inner row w-100 mx-auto"" role=""listbox"" id=""eachProvs"">



                </div>
                <a class=""carousel-control-prev"" href=""#carousel-example"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carousel-example"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""");
            WriteLiteral(@"true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid cont5"">
    <div class=""row row5"">
        <div class=""col-md-7"">
            <img src=""https://ideas.ted.com/wp-content/uploads/sites/3/2019/12/featured_ask_help_istock-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7316, "\"", 7322, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""imgholder"">

        </div>


        <div class=""col-md-5 col5"">
            <h2>Ready to hire a Provider?</h2>
            <div class=""container chooseBtn1"">
                <a href=""chooseAProvider.html?id=1621502754783"" class=""btn btn-outline-secondary help"">Find help now</a>
            </div>
        </div>

    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.EachServiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.EachServiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.EachServiceModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.EachServiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
