#pragma checksum "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200b7b02828fe7e79bc11707b154e45a28cc8b03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Events), @"mvc.1.0.view", @"/Views/Home/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Events.cshtml", typeof(AspNetCore.Views_Home_Events))]
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
#line 1 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\_ViewImports.cshtml"
using TerminsPrøven;

#line default
#line hidden
#line 2 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\_ViewImports.cshtml"
using TerminsPrøven.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200b7b02828fe7e79bc11707b154e45a28cc8b03", @"/Views/Home/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6f21739fd5675679d9ae5171810113958e9b5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search_container_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search_container_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 901, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ced48ada800402ba8e4bee79365ed30", async() => {
                BeginContext(41, 888, true);
                WriteLiteral(@"
    <title>Events</title>
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""description"" content=""Conference project"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" href=""/styles/bootstrap4/bootstrap.min.css"">
    <link href=""/plugins/font-awesome-4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/plugins/OwlCarousel2-2.2.1/owl.carousel.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/plugins/OwlCarousel2-2.2.1/owl.theme.default.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/plugins/OwlCarousel2-2.2.1/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/styles/events.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/styles/events_responsive.css"">
");
                EndContext();
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
            EndContext();
            BeginContext(936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(938, 20534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bb21aa3e9142c7ab5c6585ce58af21", async() => {
                BeginContext(944, 3537, true);
                WriteLiteral(@"

    <div class=""super_container"">

        <!-- Home -->

        <div class=""home"">
            <div class=""parallax_background parallax-window"" data-parallax=""scroll"" data-image-src=""/images/events.jpg"" data-speed=""0.8""></div>

            <!-- Header -->

            <header class=""header"" id=""header"">
                <div>
                    <div class=""header_top"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""header_top_content d-flex flex-row align-items-center justify-content-start"">
                                        <div>
                                            <a href=""#"">
                                                <div class=""logo_container d-flex flex-row align-items-start justify-content-start"">
                                                    <div class=""logo_image""><div><img src=""/images/logo.png"" alt=""""></div");
                WriteLiteral(@"></div>
                                                    <div class=""logo_content"">
                                                        <div id=""logo_text"" class=""logo_text logo_text_not_ie"">The Conference</div>
                                                        <div class=""logo_sub"">August 25, 2018 - Miami Marina Bay</div>
                                                    </div>
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""header_social ml-auto"">
                                            <ul>
                                                <li><a href=""#""><i class=""fa fa-pinterest"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-twitter"" ari");
                WriteLiteral(@"a-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-dribbble"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-behance"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""hamburger ml-auto""><i class=""fa fa-bars"" aria-hidden=""true""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""header_nav"" id=""header_nav_pin"">
                        <div class=""header_nav_inner"">
                            <div class=""header_nav_container"">
                                <");
                WriteLiteral(@"div class=""container"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <div class=""header_nav_content d-flex flex-row align-items-center justify-content-start"">
                                                <nav class=""main_nav"">
                                                    <ul>
                                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 4481, "", 4515, 1);
#line 71 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml"
WriteAttributeValue("", 4487, Url.Action("Index", "Home"), 4487, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4515, 169, true);
                WriteLiteral(">Home</a></li>\r\n                                                        <li><a href=\"#\">About Us</a></li>\r\n                                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 4684, "", 4721, 1);
#line 73 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml"
WriteAttributeValue("", 4690, Url.Action("Speakers", "Home"), 4690, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4721, 97, true);
                WriteLiteral(">Speakers</a></li>\r\n                                                        <li class=\"active\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 4818, "", 4853, 1);
#line 74 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml"
WriteAttributeValue("", 4824, Url.Action("Events", "Home"), 4824, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4853, 80, true);
                WriteLiteral(">Events</a></li>\r\n                                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 4933, "", 4966, 1);
#line 75 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml"
WriteAttributeValue("", 4939, Url.Action("News", "Home"), 4939, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4966, 78, true);
                WriteLiteral(">News</a></li>\r\n                                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 5044, "", 5080, 1);
#line 76 "C:\Users\TyrenDK\Source\Repos\ChristofferSAnkersen\TerminsTest\TerminsPrøven\Views\Home\Events.cshtml"
WriteAttributeValue("", 5050, Url.Action("Contact", "Home"), 5050, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5080, 1162, true);
                WriteLiteral(@">Contact</a></li>
                                                    </ul>
                                                </nav>
                                                <div class=""header_extra ml-auto"">
                                                    <div class=""header_search""><i class=""fa fa-search"" aria-hidden=""true""></i></div>
                                                    <div class=""button header_button""><a href=""#"">Buy Tickets Now!</a></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""search_container"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col"">
                                       ");
                WriteLiteral("     <div class=\"search_content d-flex flex-row align-items-center justify-content-end\">\r\n                                                ");
                EndContext();
                BeginContext(6242, 426, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d845d7b15244da29ef415a40d3781be", async() => {
                    BeginContext(6316, 345, true);
                    WriteLiteral(@"
                                                    <input type=""text"" class=""search_container_input"" placeholder=""Search"" required=""required"">
                                                    <button class=""search_container_button""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6668, 14797, true);
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>

            <div class=""home_content_container"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""home_content d-flex flex-row align-items-end justify-content-start"">
                                <div class=""current_page"">Events</div>
                                <div class=""breadcrumbs ml-auto"">
                                    <ul>
                                        <li><a href=""index.html"">Home</a></li>
                                        <li>Events</li>
                                    </ul>
                                </div>
         ");
                WriteLiteral(@"                   </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Events -->

        <div class=""events"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">

                        <!-- Event -->
                        <div class=""event"">
                            <div class=""row row-lg-eq-height"">
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_image_container"">
                                        <div class=""background_image"" style=""background-image:url(/images/event_9.jpg)""></div>
                                        <div class=""date_container"">
                                            <a href=""#"">
                                                <span class=""date_content d-flex flex-column align-items-center justify-content-center"">
                       ");
                WriteLiteral(@"                             <div class=""date_day"">15</div>
                                                    <div class=""date_month"">May</div>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_content"">
                                        <div class=""event_title"">Marketing Sollutions in 2018</div>
                                        <div class=""event_location"">Miami Auditorium</div>
                                        <div class=""event_text"">
                                            <p>Donec quis metus ac arcu luctus accumsan. Nunc in justo tincidunt, sodales nunc id, finibus nibh. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce nec ");
                WriteLiteral(@"ante vitae lacus aliquet vulputate. Donec scelerisque accu msan molestie. Vestibulum ante ipsum primis in faucibus orci luctus.</p>
                                        </div>
                                        <div class=""event_speakers"">
                                            <!-- Event Speaker -->
                                            <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_1.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Michael Smith</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                  ");
                WriteLiteral(@"                          <!-- Event Speaker -->
                                            <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_2.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Jessica Williams</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""event_buttons"">
                                            <div class=""button event_button event_button_1""><a href=""#"">Buy Tickets Now!</a></div>
                                   ");
                WriteLiteral(@"         <div class=""button_2 event_button event_button_2""><a href=""#"">Read more</a></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Event -->
                        <div class=""event"">
                            <div class=""row row-lg-eq-height"">
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_image_container"">
                                        <div class=""background_image"" style=""background-image:url(/images/event_10.jpg)""></div>
                                        <div class=""date_container"">
                                            <a href=""#"">
                                                <span class=""date_content d-flex flex-column align-items-center justify-content-center"">
                                               ");
                WriteLiteral(@"     <div class=""date_day"">15</div>
                                                    <div class=""date_month"">May</div>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_content"">
                                        <div class=""event_title"">Blockchain technology</div>
                                        <div class=""event_location"">Miami Auditorium</div>
                                        <div class=""event_text"">
                                            <p>Donec quis metus ac arcu luctus accumsan. Nunc in justo tincidunt, sodales nunc id, finibus nibh. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce nec ante vitae lacus aliquet vulput");
                WriteLiteral(@"ate. Donec scelerisque accu msan molestie. Vestibulum ante ipsum primis in faucibus orci luctus.</p>
                                        </div>
                                        <div class=""event_speakers"">
                                            <!-- Event Speaker -->
                                            <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_1.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Michael Smith</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                                            <!-- ");
                WriteLiteral(@"Event Speaker -->
                                            <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_2.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Jessica Williams</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""event_buttons"">
                                            <div class=""button event_button event_button_1""><a href=""#"">Buy Tickets Now!</a></div>
                                            <div class=""button_2 e");
                WriteLiteral(@"vent_button event_button_2""><a href=""#"">Read more</a></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Event -->
                        <div class=""event"">
                            <div class=""row row-lg-eq-height"">
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_image_container"">
                                        <div class=""background_image"" style=""background-image:url(/images/event_11.jpg)""></div>
                                        <div class=""date_container"">
                                            <a href=""#"">
                                                <span class=""date_content d-flex flex-column align-items-center justify-content-center"">
                                                    <div class=""date_day"">15</");
                WriteLiteral(@"div>
                                                    <div class=""date_month"">May</div>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6 event_col"">
                                    <div class=""event_content"">
                                        <div class=""event_title"">Internet of things</div>
                                        <div class=""event_location"">Miami Auditorium</div>
                                        <div class=""event_text"">
                                            <p>Donec quis metus ac arcu luctus accumsan. Nunc in justo tincidunt, sodales nunc id, finibus nibh. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce nec ante vitae lacus aliquet vulputate. Donec scelerisque accu msan m");
                WriteLiteral(@"olestie. Vestibulum ante ipsum primis in faucibus orci luctus.</p>
                                        </div>
                                        <div class=""event_speakers"">
                                            <!-- Event Speaker -->
                                            <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_1.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Michael Smith</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                                            <!-- Event Speaker -->
               ");
                WriteLiteral(@"                             <div class=""event_speaker d-flex flex-row align-items-center justify-content-start"">
                                                <div><div class=""event_speaker_image""><img src=""/images/event_speaker_2.jpg"" alt=""""></div></div>
                                                <div class=""event_speaker_content"">
                                                    <div class=""event_speaker_name"">Jessica Williams</div>
                                                    <div class=""event_speaker_title"">Marketing Specialist</div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""event_buttons"">
                                            <div class=""button event_button event_button_1""><a href=""#"">Buy Tickets Now!</a></div>
                                            <div class=""button_2 event_button event_button_2""><a hre");
                WriteLiteral(@"f=""#"">Read more</a></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""row"">
                    <div class=""col"">
                        <div class=""pagination"">
                            <ul>
                                <li class=""active""><a href=""#"">01.</a></li>
                                <li><a href=""#"">02.</a></li>
                                <li><a href=""#"">03.</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Call to action -->

        <div class=""cta"">
            <div class=""parallax_background parallax-window"" data-parallax=""scroll"" data-image-src=""/images/cta_1.jpg"" data-speed=""0.8""></div>
            <div clas");
                WriteLiteral(@"s=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <div class=""cta_content text-center"">
                            <div class=""cta_title"">Get your tickets now!</div>
                            <div class=""button cta_button""><a href=""#"">Find out more</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(21472, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
