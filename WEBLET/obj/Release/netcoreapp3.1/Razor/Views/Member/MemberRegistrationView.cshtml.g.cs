#pragma checksum "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c2452d4e2e0f165122a9e9ac538a45c8f4c398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberRegistrationView), @"mvc.1.0.view", @"/Views/Member/MemberRegistrationView.cshtml")]
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
#line 1 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\_ViewImports.cshtml"
using WEBLET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
using WEBLET.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
using WEBLET.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
using WEBLET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3c2452d4e2e0f165122a9e9ac538a45c8f4c398", @"/Views/Member/MemberRegistrationView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7597e1dcd4ac7e220a2bd0b691f39d85016eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_MemberRegistrationView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "S/O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "F/O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "D/O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Cform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/API/Alerts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/API/ApiCalls.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
  
    ViewData["Title"] = "MemberRegistrationView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
  
    ViewData["Title"] = "CompeleteRegistration";

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
  
    ApplicationUser user = await UserManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c3988222", async() => {
                WriteLiteral(@"
    <style>
        .header_color {
            background-color: #BF9D40;
            color: white;
            font-weight: 900;
        }

        .badge-blue {
            background-color: steelblue;
        }

        .child {
            background-color: #f0d27f
        }
    </style>
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">

    <script>
        function CNICChnagefunction(input, evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if ((input.value.length == 5 || input.value.length == 13) && charCode !== 8) {
                input.value = input.value + '-';
            }
        }
        function isnumber(evt, input) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57) || input.value.length > 14) {
                return false;
    ");
                WriteLiteral(@"        }
            return true;
        }

        function isnumer2(evt, input) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57) || input.value.length > 11) {
                return false;
            }
            return true;
        }
        function phonefunc(input, evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            console.log(input.value);
            if ((input.value.length == 4) && charCode !== 8) {
                input.value = input.value + '-';
            }
        }
    </script>

");
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
            WriteLiteral(@"
<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row card card-outline-warning "">
            <div class=""card-header card-title header_color text-white"">Member Registration<button class=""float-right child"" id=""basic-addon2"" data-target=""#modal-default"" data-toggle=""modal"" onclick=""LoadMembers(this)""><i class=""fa fa-search""></i></button></div>
            ");
#nullable restore
#line 77 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
       Write(Html.Partial("LoadingModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
              
                string[] array = { "Member ID", "Member Name", "Member CNIC", "Member City", "Member Country" };
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 81 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
       Write(Html.Partial("SearchModalLarge", new ModalViewMoal { Name = "Member", tableId = "Purchases", Columns = array, ModelSize = "60%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-12 grid-margin stretch-card"">

                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-4 grid-margin stretch-card"">
                            <div class=""card card-outline-warning"">
                                <div class=""card-header child card-title "">User Information</div>
                                <div class=""card-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39812817", async() => {
                WriteLiteral("\r\n                                        <div class=\"form-group\">\r\n                                            <label><b>Name</b></label>\r\n                                            <input type=\"text\" class=\"form-control  heighttext\" id=\"MEMBER_NAME\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3661, "\"", 3675, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""form-group"">
                                            <label><b>Mobile Number</b></label><br />
                                            <input type=""text"" class=""form-control  heighttext"" id=""M_NUMBER""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3989, "\"", 4003, 0);
                EndWriteAttribute();
                WriteLiteral(@" onkeydown=""phonefunc(this, event)"" onkeypress=""return isnumer2(event,this)"">
                                        </div>
                                        <div class=""form-group"">
                                            <label><b>Email</b></label><br />
                                            <input type=""text"" class=""form-control  heighttext"" id=""EMAIL""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4382, "\"", 4396, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""form-group"">
                                            <label><b>Password</b></label><br />
                                            <input type=""password"" class=""form-control  heighttext"" id=""PASSWORD""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4709, "\"", 4723, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        </div>\r\n                                        <div");
                BeginWriteAttribute("class", " class=\"", 4819, "\"", 4827, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <input style=\"width:100px !important\" type=\"file\"");
                BeginWriteAttribute("class", " class=\"", 4924, "\"", 4932, 0);
                EndWriteAttribute();
                WriteLiteral(" accept=\"image/jpeg,image/gif,image/png\" id=\"MEMBERPIC\">\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                        <div class=""col-md-8 grid-margin stretch-card"">
                            <div class=""card card-outline-warning"">
                                <div class=""card-header child card-title "">Personal Information</div>
                                <div class=""card-body"">

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39817289", async() => {
                WriteLiteral(@"
                                        <div class=""row "">
                                            <div class=""col-sm-5"">
                                                <div class=""form-group "">
                                                    <label><b>Title</b></label>
                                                    <select class=""form-control  heighttext"" id=""MEMBER_TITLE"">
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39818010", async() => {
                    WriteLiteral("Select Title");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39819296", async() => {
                    WriteLiteral("S/O");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39820573", async() => {
                    WriteLiteral("F/O");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39821850", async() => {
                    WriteLiteral("D/O");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
                                            <div class=""col-sm-5"">
                                                <div class=""form-group"">
                                                    <label><b>Father/Spouse Name</b></label>
                                                    <input type=""text"" class=""form-control heighttext"" id=""MEMBER_FATHER_NAME"" placeholder=""Father Name"">
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-sm-5"">
                                                <div class=""form-group"">
                                                    <label><b>Date of Birth</b></label>
              ");
                WriteLiteral(@"                                      <input type=""date"" class=""form-control  heighttext"" id=""MEMBER_DOB"" placeholder=""Date of Birth"">
                                                </div>
                                            </div>
                                            <div class=""col-sm-5"">
                                                <div class=""form-group"">
                                                    <label><b>CNIC</b></label>
                                                    <input type=""text"" class=""form-control heighttext"" id=""MEMBER_CNIC"" onkeydown=""CNICChnagefunction(this, event)"" onkeypress=""return isnumber(event,this)"">
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label><b>Address</b></label>
                                            <input t");
                WriteLiteral(@"ype=""email"" class=""form-control heighttext"" id=""MEMBER_ADDRESS"" placeholder=""Complete Address Line"">
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-sm-5"">
                                                <div class=""form-group"">
                                                    <label><b>Country</b></label>
                                                    ");
#nullable restore
#line 162 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
                                               Write(Html.Partial("CountriesCode"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                                                </div>
                                            </div>
                                            <div class=""col-sm-5"">
                                                <div class=""form-group"">
                                                    <label><b>City</b></label>
                                                    <input class=""form-control heighttext"" id=""MEMBER_CITY"" placeholder=""City"">
                                                </div>
                                            </div>
                                        </div>
                                        <button class=""child btn "" onclick=""SaveVendor(this)""  id=""sb"" type=""button"">Submit</button>

                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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

                    </div>
                </div>

            </div>
        </div>
    </div>
    <!-- content-wrapper ends -->
    <!-- partial:../../partials/_footer.html -->
    ");
#nullable restore
#line 189 "F:\H_Solution\WEBLET-06-05-21\WEBLET\Views\Member\MemberRegistrationView.cshtml"
Write(Html.Partial("footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- partial -->\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39828562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@10\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39829911", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c2452d4e2e0f165122a9e9ac538a45c8f4c39830951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>



    function LoadMembers(btn) {
        LoadDataBeforeModal('GET', 'LoadMembers', 'example1', 'ptable', 'modal-default', btn, 'loadingModal')

    }




    function RefereshForm() {
        document.getElementById('AForm').reset();
        document.getElementById('BForm').reset();
    }
    function SaveVendor(btn) {
        var MEMBER_NAME = document.getElementById(""MEMBER_NAME"").value;
        var M_NUMBER = document.getElementById(""M_NUMBER"").value;
        var EMAIL = document.getElementById(""EMAIL"").value;
        var PASSWORD = document.getElementById(""PASSWORD"").value;
        var MEMBER_TITLE = document.getElementById(""MEMBER_TITLE"").value;
        var MEMBER_FATHER_NAME = document.getElementById(""MEMBER_FATHER_NAME"").value;
        var MEMBER_DOB = document.getElementById(""MEMBER_DOB"").value;
        var MEMBER_CNIC = document.getElementById(""MEMBER_CNIC"").value;
        var MEMBER_ADDRESS = document.getElementById(""MEMBER_ADDRESS"").value;
        var MEMBER_C");
            WriteLiteral(@"OUNTRY = document.getElementById(""MEMBER_COUNTRY"").value;
        var MEMBER_CITY = document.getElementById(""MEMBER_CITY"").value;
        if (MEMBER_NAME == '') {
            Alert('error', 'Enter Member Name');
            document.getElementById('MEMBER_NAME').focus();
        }
        else if (M_NUMBER == '') {
            Alert('error', 'Enter Phone Number');
            document.getElementById('M_NUMBER').focus();
        } else if (PASSWORD == '') {
            Alert('error', 'Enter Password');
            document.getElementById('PASSWORD').focus();
        }
        else if (EMAIL == '') {
            Alert('error', 'Enter Email');
            document.getElementById('EMAIL').focus();
        }
        else if (MEMBER_FATHER_NAME == '') {
            Alert('error', 'Enter Father Name');
            document.getElementById('MEMBER_FATHER_NAME').focus();
        } else if (MEMBER_DOB == '') {
            Alert('error', 'Enter Member Date of Birth');
            document.getElement");
            WriteLiteral(@"ById('MEMBER_DOB').focus();
        } else if (MEMBER_CNIC == '') {
            Alert('error', 'Enter Member CNIC');
            document.getElementById('MEMBER_CNIC').focus();
        }
        else if (MEMBER_ADDRESS == '') {
            Alert('error', 'Enter Address');
            document.getElementById('MEMBER_ADDRESS').focus();
        } else if (MEMBER_COUNTRY == '') {
            Alert('error', 'Enter Country');
            document.getElementById('MEMBER_COUNTRY').focus();
        } else if (MEMBER_CITY == '') {
            Alert('error', 'Enter City');
            document.getElementById('MEMBER_CITY').focus();
        }
        console.log(ValidateEmail(EMAIL));
        if (ValidateEmail(EMAIL)) {
            $('#EMAIL').text('');
            $(""#EMAIL"").css(""border"", ""1px solid #e8ecf1"");
        }
        else {
            Alert('error', 'Please Enter Valid Email')
            $(""#EMAIL"").css(""border"", ""1px solid red"");

            return;
        }    {
            da");
            WriteLiteral(@"ta = {
                ""MEMBER_NAME"": MEMBER_NAME,
                ""M_NUMBER"": M_NUMBER,
                ""EMAIL"": EMAIL,
                ""PASSWORD"": PASSWORD,
                ""MEMBER_TITLE"": MEMBER_TITLE,
                ""MEMBER_FATHER_NAME"": MEMBER_FATHER_NAME,
                ""MEMBER_DOB"": MEMBER_DOB,
                ""MEMBER_CNIC"": MEMBER_CNIC,
                ""MEMBER_ADDRESS"": MEMBER_ADDRESS,
                ""MEMBER_COUNTRY"": MEMBER_COUNTRY,
                ""MEMBER_CITY"": MEMBER_CITY,
            }
        
           
            var file_data = $(""#MEMBERPIC"").prop(""files"")[0];
            var form_data = new FormData();
            form_data.append(""data"", JSON.stringify(data));
            form_data.append(""file"", file_data);

        
            var apicall = ['POST', 'CreateMember', btn, form_data, ""Saved Successfully"", 'Cform', true];
            ConfirmationAlert(""Do you want to Save the record? "", ""Yes"", ""No"", AjaxButtonCallForImage   , apicall);
        }



        fu");
            WriteLiteral("nction ValidateEmail(inputText) {\r\n            var regex = /^([a-zA-Z0-9_\\.\\-\\+])+\\");
            WriteLiteral("@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,4})+$/;\r\n            if (!regex.test(inputText)) {\r\n                return false;\r\n            }\r\n            else {\r\n                return true;\r\n            }\r\n        }\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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