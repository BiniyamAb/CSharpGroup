#pragma checksum "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b07e53a4cae5fff50add23c00ea04110df9b43f"
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
#line 1 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\_ViewImports.cshtml"
using CSharpGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b07e53a4cae5fff50add23c00ea04110df9b43f", @"/Pages/Provider_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Provider_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
  
    ViewData["Title"] = "Provider list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 148, "\"", 185, 1);
#nullable restore
#line 8 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
WriteAttributeValue("", 155, Url.Content("~/css/blue.css"), 155, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 215, "\"", 254, 1);
#nullable restore
#line 9 "C:\Users\BINA\source\repos\CSharpGroup\CSharpGroup\Pages\Provider_list.cshtml"
WriteAttributeValue("", 222, Url.Content("~/css/style2.css"), 222, 32, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f5779", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f6768", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f7760", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f8750", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f9743", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f10724", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f11720", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f12712", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f13696", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f14684", async() => {
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
            BeginWriteAttribute("value", " value=\"", 4050, "\"", 4058, 0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f20165", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f21151", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f22134", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b07e53a4cae5fff50add23c00ea04110df9b43f23117", async() => {
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
            WriteLiteral(@"
                    </select>
                </div>
            </div>

            <div class=""listings-container grid-layout margin-top-35"">

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-01.png""");
            BeginWriteAttribute("alt", " alt=\"", 7249, "\"", 7255, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Hexagon <span class=""verified-badge"" title=""Verified Employer"" data-tippy-placement=""top""></span></h4>
                            <h3 class=""job-listing-title"">Bilingual Event Support Specialist</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon");
            WriteLiteral(@"-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
                    </div>
                </a>

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-05.png""");
            BeginWriteAttribute("alt", " alt=\"", 8798, "\"", 8804, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Laxo</h4>
                            <h3 class=""job-listing-title"">Competition Law Officer</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
                    ");
            WriteLiteral(@"</div>
                </a>

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-02.png""");
            BeginWriteAttribute("alt", " alt=\"", 10243, "\"", 10249, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Coffee</h4>
                            <h3 class=""job-listing-title"">Barista and Cashier</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
                    </");
            WriteLiteral(@"div>
                </a>


                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-03.png""");
            BeginWriteAttribute("alt", " alt=\"", 11688, "\"", 11694, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">King <span class=""verified-badge"" title=""Verified Employer"" data-tippy-placement=""top""></span></h4>
                            <h3 class=""job-listing-title"">Restaurant General Manager</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-o");
            WriteLiteral(@"utline-access-time""></i> 2 days ago</li>
                        </ul>
                    </div>
                </a>


                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-05.png""");
            BeginWriteAttribute("alt", " alt=\"", 13228, "\"", 13234, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Skyist</h4>
                            <h3 class=""job-listing-title"">International Marketing Coordinator</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
      ");
            WriteLiteral(@"              </div>
                </a>

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-05.png""");
            BeginWriteAttribute("alt", " alt=\"", 14687, "\"", 14693, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Podous</h4>
                            <h3 class=""job-listing-title"">Construction Labourers</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
                   ");
            WriteLiteral(@" </div>
                </a>

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-04.png""");
            BeginWriteAttribute("alt", " alt=\"", 16133, "\"", 16139, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Mates</h4>
                            <h3 class=""job-listing-title"">Administrative Assistant</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
                  ");
            WriteLiteral(@"  </div>
                </a>

                <!-- Job Listing -->
                <a href=""single-job-page.html"" class=""job-listing"">

                    <!-- Job Listing Details -->
                    <div class=""job-listing-details"">
                        <!-- Logo -->
                        <div class=""job-listing-company-logo"">
                            <img src=""images/company-logo-06.png""");
            BeginWriteAttribute("alt", " alt=\"", 17580, "\"", 17586, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                        <!-- Details -->
                        <div class=""job-listing-description"">
                            <h4 class=""job-listing-company"">Trideo</h4>
                            <h3 class=""job-listing-title"">Human Resources Consultant</h3>
                        </div>
                    </div>

                    <!-- Job Listing Footer -->
                    <div class=""job-listing-footer"">
                        <span class=""bookmark-icon""></span>
                        <ul>
                            <li><i class=""icon-material-outline-location-on""></i> San Francisco</li>
                            <li><i class=""icon-material-outline-business-center""></i> Full Time</li>
                            <li><i class=""icon-material-outline-account-balance-wallet""></i> $35000-$38000</li>
                            <li><i class=""icon-material-outline-access-time""></i> 2 days ago</li>
                        </ul>
               ");
            WriteLiteral(@"     </div>
                </a>

            </div>

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
                        </n");
            WriteLiteral(@"av>
                    </div>
                </div>
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