#pragma checksum "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Matches), @"mvc.1.0.view", @"/Views/Home/Matches.cshtml")]
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
#line 1 "C:\Users\abdo\source\repos\OnMatch\Views\_ViewImports.cshtml"
using OnMatch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdo\source\repos\OnMatch\Views\_ViewImports.cshtml"
using OnMatch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f", @"/Views/Home/Matches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5106f819f2f8d9519c5d4752e1550ce937e27ee5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Matches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnMatch.Models.Match>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Matches", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/download.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block ui-w-40 rounded-circle ml-auto mr-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Live", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMatch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
  
    ViewData["Title"] = "Matches";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var now = DateTime.Now.AddHours(1.5).AddMinutes(15);
    DateTime date = DateTime.Parse(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row \">\r\n\r\n    <!-- Area Chart -->\r\n    <div class=\" col-xl-10 col-lg-10 ml-auto mr-auto \">\r\n\r\n\r\n        <div class=\"row mb-3\">\r\n            <div class=\"card bg-light shadow mr-auto\" style=\"width:5%;text-align:center;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f8441", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n                    غدا\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                                                                             WriteLiteral(date.AddDays(1).ToString("MM-dd-yyyy"));

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
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"card bg-light shadow ml-auto\" style=\"width:7%;text-align:center;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f11241", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n                    امس\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                                                                             WriteLiteral(date.AddDays(-1).ToString("MM-dd-yyyy"));

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card shadow mb-4 bg-light "">

                    <!-- Card Header - Dropdown -->
                    <!-- Card Body -->
                    <div class=""card-body"">


                        <div class=""row"">
                            <div class=""w-25"" style=""text-align:center;"">

");
#nullable restore
#line 58 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                 if (item.club1.Img == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f15012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                }
                                else
                                {

                                    var Userbase64 = Convert.ToBase64String(item.club1.Img);
                                    var UserimgSrc = String.Format("data:image/png;base64,{0}", Userbase64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 2197, "\"", 2214, 1);
#nullable restore
#line 67 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
WriteAttributeValue("", 2203, UserimgSrc, 2203, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-auto rounded-circle ml-auto mr-auto\" style=\"height:3rem\"");
            BeginWriteAttribute("alt", " alt=\"", 2289, "\"", 2295, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 68 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4>\r\n                                    ");
#nullable restore
#line 70 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                               Write(item.club1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </h4>

                            </div>
                            <div class=""w-50"">
                                <div style=""text-align:center;"">
                                    <span class=""mr-auto ml-auto"">
                                        ");
#nullable restore
#line 77 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                   Write(item.league.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                    <div class=\"row\">\r\n");
#nullable restore
#line 80 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                         if (item.date >= DateTime.Now)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"w-50\" style=\"font-weight:bold\">-</span>\r\n                                            <span class=\"w-50\" style=\"font-weight:bold\">-</span>\r\n");
#nullable restore
#line 84 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                        }

                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"w-50\">");
#nullable restore
#line 88 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                          Write(item.result1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <span class=\"w-50\">");
#nullable restore
#line 89 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                          Write(item.result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 90 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div>\r\n");
#nullable restore
#line 93 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                         if (item.date == DateTime.Now || item.date < now)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"w-50\">! مباشر</span>\r\n");
#nullable restore
#line 96 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"

                                        }
                                        else if (item.date < DateTime.Now)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"w-50\">! انتهت</span>\r\n");
#nullable restore
#line 101 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>لم تبدأ بعد</span>\r\n");
#nullable restore
#line 105 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <span class=\"mr-auto ml-auto\">\r\n                                        ");
#nullable restore
#line 108 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                   Write(item.date.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 108 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                   Write(item.date.Minute.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"w-25\" style=\"text-align:center;\">\r\n\r\n");
#nullable restore
#line 114 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                 if (item.club2.Img == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f22816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 117 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                }
                                else
                                {

                                    var Userbase64 = Convert.ToBase64String(item.club2.Img);
                                    var UserimgSrc = String.Format("data:image/png;base64,{0}", Userbase64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 5272, "\"", 5289, 1);
#nullable restore
#line 123 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
WriteAttributeValue("", 5278, UserimgSrc, 5278, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-auto rounded-circle ml-auto mr-auto\" style=\"height:3rem\"");
            BeginWriteAttribute("alt", " alt=\"", 5364, "\"", 5370, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 124 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4>\r\n                                    ");
#nullable restore
#line 126 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                               Write(item.club2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h4>\r\n\r\n                            </div>\r\n\r\n\r\n\r\n                        </div>\r\n\r\n                        <div class=\"border-radius-lg change-photo h-100\" style=\"display:flex;\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f25892", async() => {
                WriteLiteral("<span class=\"label-photo link\">Live</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
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
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n");
#nullable restore
#line 141 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""nav-item dropdown no-arrow"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                                   data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <span class=""mr-2 d-none d-lg-inline text-gray-600 small""><i class=""fas fa-ellipsis-h ""></i></span>

                                </a>

                                <div class=""  dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                     aria-labelledby=""userDropdown"">

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e365c00c1c7e2d13ad28a8443f0f76f0d0ab444f29293", async() => {
                WriteLiteral("\r\n\r\n                                        <i class=\"fas fa-edit fa-sm fa-fw mr-2 \"></i>\r\n                                        <span>Edit</span>\r\n\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
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
            WriteLiteral("\r\n                                    <a class=\"dropdown-item js-delete \" href=\"javascript:;\" data-id=\"");
#nullable restore
#line 159 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                        <i class=""fas fa-solid fa-trash fa-sm fa-fw mr-2 ""></i>
                                        <span>Delete</span>
                                    </a>

                                </div>


                                <!-- Dropdown - User Information -->
                            </div>
");
#nullable restore
#line 169 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 173 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\abdo\source\repos\OnMatch\Views\Home\Matches.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n    <!-- Pie Chart -->\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $("".js-delete"").on(""click"", function () {
        var btn = $(this);
        alert(""dcddc"");
       
        $.ajax({
            url: ""/api/Match/?id="" + btn.data(""id""),
            method: ""DELETE"",
            success: function () {
                let text = document.getElementsByClassName(""card"");
                btn.parentsUntil(text).fadeOut();
            },
            error: function () {
                alert(""error happend"");
            }
        });
        
    });
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnMatch.Models.Match>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
