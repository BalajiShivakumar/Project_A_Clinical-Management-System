#pragma checksum "C:\Users\Balaji\Desktop\PROJECT_A\ClinicManagement\ClinicManagement\Views\Home\Review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a247d8f2bf6a39fc962fd96743822b9aaf4af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Review), @"mvc.1.0.view", @"/Views/Home/Review.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Balaji\Desktop\PROJECT_A\ClinicManagement\ClinicManagement\Views\_ViewImports.cshtml"
using ClinicManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Balaji\Desktop\PROJECT_A\ClinicManagement\ClinicManagement\Views\_ViewImports.cshtml"
using ClinicManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a247d8f2bf6a39fc962fd96743822b9aaf4af7", @"/Views/Home/Review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b2c6c1808a4525931aa99d11800b593e658ba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Review : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Review.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addnotesmodalTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Balaji\Desktop\PROJECT_A\ClinicManagement\ClinicManagement\Views\Home\Review.cshtml"
  
    ViewData["Title"] = "Review";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a247d8f2bf6a39fc962fd96743822b9aaf4af75356", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3a247d8f2bf6a39fc962fd96743822b9aaf4af75618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>\r\n<button float=\"left\" type=\"button\" class=\"btn btn-light\"><a href=\"https://localhost:44394/SignIns/Success\">Main Menu</a></button>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a247d8f2bf6a39fc962fd96743822b9aaf4af77661", async() => {
                WriteLiteral("\r\n    <div>\r\n        <div class=\"tab-content bg-transparent\">\r\n            <div id=\"note-full-container\" class=\"note-has-grid row\">\r\n                <div class=\"col-md-4 single-note-item all-category\"");
                BeginWriteAttribute("style", " style=\"", 476, "\"", 484, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Book a Ticket for Movie"">Nagesh Vishwanatham<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">11 May 2021</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Well managed experienced Doctors at service for patients. Neat and Clean. Good Housekeeping. Pleasing and helpful Reception. God bless all the Patients who come here.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
    ");
                WriteLiteral("                        <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-important\"");
                BeginWriteAttribute("style", " style=\"", 2741, "\"", 2749, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Go for lunch"">Mohammad Hussain<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">01 April 2021</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Excellent facility. Spacious and comfortable for elders. I‘ve been bringing my parents here for annual checkups for more than a decade.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
                            <span class=""mr-1"">");
                WriteLiteral("<i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-social\"");
                BeginWriteAttribute("style", " style=\"", 6174, "\"", 6182, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Meeting with Mr.Jojo"">Sathyanarayanan<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">19 January 2021</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Best care.. economic charges when compared to other corporate hospitals... Latest equipment... Very well experienced doctors ... No biase.... Very friendly environment... Feel like home..
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""");
                WriteLiteral("></i></span>\r\n                            <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-business\"");
                BeginWriteAttribute("style", " style=\"", 9670, "\"", 9678, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Give Review for design"">Thomas Shelby <i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">02 December 2020</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Good.. Even uneducated or senior citizens also need not worry.. Nice assistance has been providing by their health check up team.. Nice hospitalization.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
                   ");
                WriteLiteral("         <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-social\"");
                BeginWriteAttribute("style", " style=\"", 13131, "\"", 13139, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Nightout with friends"">Grace<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">23 September 2020</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Our special thanks to all concerned doctors, nursing staff and the cleaning team. The hospital was really clean. Nurses were friendly cooperative and doctors took good care on me
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
  ");
                WriteLiteral("                          <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-important\"");
                BeginWriteAttribute("style", " style=\"", 16612, "\"", 16620, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Launch new template"">Sanjeev<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">21 January 2015</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                I would recommend Apollo Hospitals for anyone looking for health care for their family. Simply wondering why I did not choose this hospital earlier
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
                            <span c");
                WriteLiteral("lass=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-social\"");
                BeginWriteAttribute("style", " style=\"", 20057, "\"", 20065, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Change a Design"">Preetham Reddy<i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">25 August 2020</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                It was good being in the hospital. The service they have provided has been excellent. Surroundings and atmosphere around the hospital was good.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
                            <span cla");
                WriteLiteral("ss=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-business\"");
                BeginWriteAttribute("style", " style=\"", 23502, "\"", 23510, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Give review for foods"">Rio <i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">18 December 2020</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                Opthalmology dr sreekumar sir and his staff doing excellent job. Special thanks to my doctor who was very good and listened to all my problems. Nurses are good.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-note""></i></span>
                      ");
                WriteLiteral("      <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 single-note-item all-category note-important\"");
                BeginWriteAttribute("style", " style=\"", 26963, "\"", 26971, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""card card-body"">
                        <span class=""side-stick""></span>
                        <h5 class=""note-title text-truncate w-75 mb-0"" data-noteheading=""Give salary to employee"">Arthur <i class=""point fa fa-circle ml-1 font-10""></i></h5>
                        <p class=""note-date font-12 text-muted"">15 Fabruary 2020</p>
                        <div class=""note-content"">
                            <p class=""note-inner-content text-muted"" data-notecontent=""Blandit tempus porttitor aasfs. Integer posuere erat a ante venenatis."">
                                The service which provided by the stone clinic is really excellent. Doctors are very friendly with the patients Hope the hospital maintains the same in future also. I wish them all the very best.
                            </p>
                        </div>
                        <div class=""d-flex align-items-center"">
                            <span class=""mr-1""><i class=""fa fa-star favourite-n");
                WriteLiteral("ote\"></i></span>\r\n                            <span class=\"mr-1\"><i class=\"fa fa-trash remove-note\"></i></span>\r\n                            <div class=\"ml-auto\">\r\n");
                WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Modal Add notes -->
        <div class=""modal fade"" id=""addnotesmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addnotesmodalTitle"" style=""display: none;"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content border-0"">
                    <div class=""modal-header bg-info text-white"">
                        <h5 class=""modal-title text-white"">Add Notes</h5>
                        <button type=""button"" class=""close text-white"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""notes-box"">
                            <div class=""notes-content"">
       ");
                WriteLiteral("                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a247d8f2bf6a39fc962fd96743822b9aaf4af723587", async() => {
                    WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-md-12 mb-3"">
                                            <div class=""note-title"">
                                                <label>Note Title</label>
                                                <input type=""text"" id=""note-has-title"" class=""form-control"" minlength=""25"" placeholder=""Title"" />
                                            </div>
                                        </div>

                                        <div class=""col-md-12"">
                                            <div class=""note-description"">
                                                <label>Note Description</label>
                                                <textarea id=""note-has-description"" class=""form-control"" minlength=""60"" placeholder=""Description"" rows=""3""></textarea>
                                            </div>
                                        </div>
             ");
                    WriteLiteral("                       </div>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button id=""btn-n-save"" class=""float-left btn btn-success"" style=""display: none;"">Save</button>
                        <button class=""btn btn-danger"" data-dismiss=""modal"">Discard</button>
                        <button id=""btn-n-add"" class=""btn btn-info"" disabled=""disabled"">Add</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
