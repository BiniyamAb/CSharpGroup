#pragma checksum "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5455bd6967f0a82894cd8fe8b0900654e96cabf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpGroup.Pages.Pages_Provider_list), @"mvc.1.0.razor-page", @"/Pages/Provider_list.cshtml")]
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
#line 1 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5455bd6967f0a82894cd8fe8b0900654e96cabf", @"/Pages/Provider_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Provider_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Single_provider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("job-listing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
  
    ViewData["Title"] = "Provider list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 159, "\"", 196, 1);
#nullable restore
#line 8 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
WriteAttributeValue("", 166, Url.Content("~/css/blue.css"), 166, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 226, "\"", 265, 1);
#nullable restore
#line 9 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
WriteAttributeValue("", 233, Url.Content("~/css/style2.css"), 233, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-xl-3 col-lg-4"">
            <div class=""sidebar-container"">

                <!-- Location -->
                <div class=""sidebar-widget"">
                    <h3>Location</h3>
                    <div class=""input-with-icon"">
                        <div id=""autocomplete-container"">
                            <input id=""autocomplete-input"" type=""text"" placeholder=""Location"">
                        </div>
                        <i class=""icon-material-outline-location-on""></i>
                    </div>
                </div>

                <!-- Keywords -->
                <div class=""sidebar-widget"">
                    <h3>Keywords</h3>
                    <div class=""keywords-container"">
                        <div class=""keyword-input-container"">
                            <input type=""text"" class=""keyword-input"" placeholder=""e.g. job title"" />
                            <button class=""keyword-input-but");
            WriteLiteral(@"ton ripple-effect""><i class=""icon-material-outline-add""></i></button>
                        </div>
                        <div class=""keywords-list""><!-- keywords go here --></div>
                        <div class=""clearfix""></div>
                    </div>
                </div>

                <!-- Category -->
                <div class=""sidebar-widget"">
                    <h3>Category</h3>
                    <select class=""selectpicker default"" multiple data-selected-text-format=""count"" data-size=""7"" title=""All Categories"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf6660", async() => {
                WriteLiteral("Admin Support");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf7649", async() => {
                WriteLiteral("Customer Service");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf8641", async() => {
                WriteLiteral("Data Analytics");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf9631", async() => {
                WriteLiteral("Design & Creative");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf10624", async() => {
                WriteLiteral("Legal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf11606", async() => {
                WriteLiteral("Software Developing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf12602", async() => {
                WriteLiteral("IT & Networking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf13594", async() => {
                WriteLiteral("Writing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf14578", async() => {
                WriteLiteral("Translation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf15566", async() => {
                WriteLiteral("Sales & Marketing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>

                <!-- Job Types -->
                <div class=""sidebar-widget"">
                    <h3>Job Type</h3>

                    <div class=""switches-list"">
                        <div class=""switch-container"">
                            <label class=""switch""><input type=""checkbox""><span class=""switch-button""></span> Freelance</label>
                        </div>

                        <div class=""switch-container"">
                            <label class=""switch""><input type=""checkbox""><span class=""switch-button""></span> Full Time</label>
                        </div>

                        <div class=""switch-container"">
                            <label class=""switch""><input type=""checkbox""><span class=""switch-button""></span> Part Time</label>
                        </div>

                        <div class=""switch-container"">
                            <label class=""switch""><input type=""checkbox""><span clas");
            WriteLiteral(@"s=""switch-button""></span> Internship</label>
                        </div>
                        <div class=""switch-container"">
                            <label class=""switch""><input type=""checkbox""><span class=""switch-button""></span> Temporary</label>
                        </div>
                    </div>

                </div>

                <!-- Salary -->
                <div class=""sidebar-widget"">
                    <h3>Salary</h3>
                    <div class=""margin-top-55""></div>

                    <!-- Range Slider -->
                    <input class=""range-slider"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 4061, "\"", 4069, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-slider-currency=""$"" data-slider-min=""1500"" data-slider-max=""15000"" data-slider-step=""100"" data-slider-value=""[1500,15000]"" />
                </div>

                <!-- Tags -->
                <div class=""sidebar-widget"">
                    <h3>Tags</h3>

                    <div class=""tags-container"">
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag1"" />
                            <label for=""tag1"">front-end dev</label>
                        </div>
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag2"" />
                            <label for=""tag2"">angular</label>
                        </div>
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag3"" />
                            <label for=""tag3"">react</label>
                        </div>
                        <div class=""tag"">
                            <input type=""chec");
            WriteLiteral(@"kbox"" id=""tag4"" />
                            <label for=""tag4"">vue js</label>
                        </div>
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag5"" />
                            <label for=""tag5"">web apps</label>
                        </div>
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag6"" />
                            <label for=""tag6"">design</label>
                        </div>
                        <div class=""tag"">
                            <input type=""checkbox"" id=""tag7"" />
                            <label for=""tag7"">wordpress</label>
                        </div>
                    </div>
                    <div class=""clearfix""></div>
                </div>

            </div>
        </div>
        <div class=""col-xl-9 col-lg-8 content-left-offset"">

            <h3 class=""page-title"">Search Results</h3>

            <div class=""notify-box mar");
            WriteLiteral(@"gin-top-15"">
                <div class=""switch-container"">
                    <label class=""switch""><input type=""checkbox""><span class=""switch-button""></span><span class=""switch-text"">Turn on email alerts for this search</span></label>
                </div>

                <div class=""sort-by"">
                    <span>Sort by:</span>
                    <select class=""selectpicker hide-tick"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf21047", async() => {
                WriteLiteral("Relevance");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf22033", async() => {
                WriteLiteral("Newest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf23016", async() => {
                WriteLiteral("Oldest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf23999", async() => {
                WriteLiteral("Random");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"listings-container grid-layout margin-top-35\">\r\n");
#nullable restore
#line 154 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                 foreach (var item in Model.providersList)
                {
                    var imageLink = "." + item.Image;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5455bd6967f0a82894cd8fe8b0900654e96cabf25477", async() => {
                WriteLiteral("\r\n\r\n                        \r\n                        <div class=\"job-listing-details\">\r\n                            \r\n                            <div class=\"job-listing-company-logo\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 7346, "\"", 7362, 1);
#nullable restore
#line 164 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
WriteAttributeValue("", 7352, imageLink, 7352, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7363, "\"", 7369, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n\r\n                            \r\n                            <div class=\"job-listing-description\">\r\n                                <h4 class=\"job-listing-company\">");
#nullable restore
#line 169 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 169 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                                           Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  <span class=""verified-badge"" title=""Verified Employer"" data-tippy-placement=""top""></span></h4>
                            </div>
                        </div>

                       
                        <div class=""job-listing-footer"">
                            <span class=""bookmark-icon""></span>
                            <ul>
                                <li><i class=""icon-material-outline-location-on""></i> ");
#nullable restore
#line 177 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                                                 Write(item.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li><i class=\"fa fas-star\"></i> ");
#nullable restore
#line 178 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                           Write(item.AverageRating);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n                                <li><i class=\"icon-material-outline-account-balance-wallet\"></i> $ ");
#nullable restore
#line 179 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                                                              Write(item.PerHourWage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li><i class=\"icon-material-outline-access-time\"></i> ");
#nullable restore
#line 180 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                                                 Write(item.JobsDone);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Jobs Done</li>\r\n                            </ul>\r\n                        </div>\r\n                    ");
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
#line 158 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 184 "C:\Users\user\Desktop\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Job Listing -->\r\n");
            WriteLiteral(@"            </div>

            <!-- Pagination -->
            <div class=""clearfix""></div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <!-- Pagination -->
                    <div class=""pagination-container margin-top-30 margin-bottom-60"">
                        <nav class=""pagination"">
                            <ul>
                                <li class=""pagination-arrow""><a href=""#""><i class=""icon-material-outline-keyboard-arrow-left""></i></a></li>
                                <li><a href=""#"">1</a></li>
                                <li><a href=""#"" class=""current-page"">2</a></li>
                                <li><a href=""#"">3</a></li>
                                <li><a href=""#"">4</a></li>
                                <li class=""pagination-arrow""><a href=""#""><i class=""icon-material-outline-keyboard-arrow-right""></i></a></li>
                            </ul>
                        </nav>
                    </div>
    ");
            WriteLiteral(@"            </div>
            </div>
            <!-- Pagination / End -->

        </div>
    </div>

</div>

<script src=""js/jquery-3.3.1.min.js""></script>
<script src=""js/jquery-migrate-3.0.0.min.js""></script>
<script src=""js/mmenu.min.js""></script>
<script src=""js/tippy.all.min.js""></script>
<script src=""js/simplebar.min.js""></script>
<script src=""js/bootstrap-slider.min.js""></script>
<script src=""js/bootstrap-select.min.js""></script>
<script src=""js/snackbar.js""></script>
<script src=""js/clipboard.min.js""></script>
<script src=""js/counterup.min.js""></script>
<script src=""js/magnific-popup.min.js""></script>
<script src=""js/slick.min.js""></script>
<script src=""js/custom.js""></script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.Provider_listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.Provider_listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.Provider_listModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.Provider_listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
