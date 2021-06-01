#pragma checksum "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85873c43df75b921ce8e97a8c62175db3991bc4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpGroup.Pages.Pages_Jobs), @"mvc.1.0.razor-page", @"/Pages/Jobs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85873c43df75b921ce8e97a8c62175db3991bc4a", @"/Pages/Jobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdebe8be2781f3edc894a4c20e623092dfd2c5a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Jobs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "decline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<br>

<div class=""container"">
    <ul class=""nav nav-pills nav-pills nav-justified mb-3"" id=""pills-tab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link active"" id=""pills-jobs-tab"" data-toggle=""pill"" href=""#pills-jobs"" role=""tab"" aria-controls=""pills-jobs"" aria-selected=""false"">Jobs</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""pills-history-tab"" data-toggle=""pill"" href=""#pills-history"" role=""tab"" aria-controls=""pills-history"" aria-selected=""true"">History</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""pills-tabContent"">
        <div class=""tab-pane fade show active"" id=""pills-jobs"" role=""tabpanel"" aria-labelledby=""pills-jobs-tab"">
            <div class=""container"">

");
#nullable restore
#line 22 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                 if (Model._orderList.Count != 0 || Model.acceptedOrder !=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Seeker Name</th>
                                <th scope=""col"">Address</th>
                                <th scope=""col"">Status</th>
                                <th scope=""col"">Details</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 34 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                             if (Model.acceptedOrder == null)
                            {
                                foreach (var item in Model._orderList)
                                {
                                    var user = Model._mycontext.Users.Where(u => u.Id == item.SeekerId).SingleOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 40 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 41 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                       Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85873c43df75b921ce8e97a8c62175db3991bc4a7880", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85873c43df75b921ce8e97a8c62175db3991bc4a8186", async() => {
                    WriteLiteral("Accept");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85873c43df75b921ce8e97a8c62175db3991bc4a10639", async() => {
                    WriteLiteral("Decline");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>Not available</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                }
                            }
                            else
                            {
                                var ordersAwaiting = Model._orderList.Count();
                                var userUndertaking = Model._mycontext.Users.Where(u => u.Id == Model.acceptedOrder.SeekerId).FirstOrDefault();
                                var phoneNo = userUndertaking.PhoneNo;
                                var uniqueCode = Model.acceptedOrder.UniqueCode.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 59 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                               Write(userUndertaking.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                                          Write(userUndertaking.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                   Write(userUndertaking.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>Undertaking...</td>\r\n                                    <td>\r\n                                        <p>Phone Number: ");
#nullable restore
#line 63 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                    Write(phoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Unique code: ");
#nullable restore
#line 64 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                   Write(uniqueCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                if (ordersAwaiting > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"3\" class=\"text-center\">\r\n                                            You have ");
#nullable restore
#line 71 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                Write(ordersAwaiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(" other requests waiting. Finish the task at hand to accept another one\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                }
                                else if (ordersAwaiting > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"3\" class=\"text-center\">\r\n                                            You have ");
#nullable restore
#line 79 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                Write(ordersAwaiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(" other request waiting. Finish the task at hand to accept another one\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 87 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"


                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"text-center\">You Have No Job Requests Currently!</h3>\r\n");
#nullable restore
#line 93 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"tab-pane fade\" id=\"pills-history\" role=\"tabpanel\" aria-labelledby=\"pills-history-tab\">\r\n\r\n            <div class=\"container\">\r\n\r\n");
#nullable restore
#line 108 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                 if (Model.jobsHistory.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Provider Name</th>
                                <th scope=""col"">Address</th>
                                <th scope=""col"">Details</th>

                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 121 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                             foreach (var item in Model.jobsHistory)
                            {
                                var user = Model._mycontext.Users.Where(u => u.Id == item.SeekerId).SingleOrDefault();
                                var review = Model._mycontext.Reviews.Where(r => r.OrderId == item.Id).SingleOrDefault();
                                var userName = user.FirstName + user.LastName;
                                var dateInfo = item.OrderCreatedDate + " - " + item.OrderCompletedDate;



#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 130 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 130 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 131 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                   Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <p>From: ");
#nullable restore
#line 133 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                            Write(dateInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Phone No: ");
#nullable restore
#line 134 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                Write(user.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Total Hours: ");
#nullable restore
#line 135 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                   Write(String.Format("{0:0.00}", item.SavedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Total Price: $");
#nullable restore
#line 136 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                                    Write(String.Format("{0:0.00}", (item.SavedTime * (double)Model.loggedProviderPHW)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Rating:");
#nullable restore
#line 137 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                             Write(review.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa-fas-star\"></i></p>\r\n                                        <p>Review: ");
#nullable restore
#line 138 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                                              Write(review.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 141 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 145 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"







                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"text-center\">You Have No History!</h3>\r\n");
#nullable restore
#line 156 "C:\Users\hp\Source\Repos\CSharpGroup\CSharpGroup\Pages\Jobs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpGroup.Pages.JobsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.JobsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpGroup.Pages.JobsModel>)PageContext?.ViewData;
        public CSharpGroup.Pages.JobsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
