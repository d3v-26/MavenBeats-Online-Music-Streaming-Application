#pragma checksum "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb46f4ace0d95a09fd76781c31ef1bfe1f3e3b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Songs_VisitorPage), @"mvc.1.0.view", @"/Views/Songs/VisitorPage.cshtml")]
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
#line 1 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\_ViewImports.cshtml"
using DemoMusicMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\_ViewImports.cshtml"
using DemoMusicMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb46f4ace0d95a09fd76781c31ef1bfe1f3e3b35", @"/Views/Songs/VisitorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90642c46c10df1c21b860efcd14bfbf28463ff68", @"/Views/_ViewImports.cshtml")]
    public class Views_Songs_VisitorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoMusicMVC.Models.Song>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
  
    ViewData["Title"] = "Songs";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row row-cols-1 row-cols-md-3\">\r\n");
#nullable restore
#line 7 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col mb-4\">\r\n");
            WriteLiteral("            <div class=\"card h-100\" style=\"max-width: 20rem;\">\r\n                <div class=\"view overlay\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 858, "\"", 914, 2);
            WriteAttributeValue("", 864, "https://localhost:44392/app-images/", 864, 35, true);
#nullable restore
#line 23 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
WriteAttributeValue("", 899, item.photoPath, 899, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                         alt=""Card image cap"">
                    <a href=""#!"">
                        <div class=""mask rgba-white-slight""></div>
                    </a>
                </div>
                <div class=""card-body"">
                    <h4 class=""card-title"">");
#nullable restore
#line 30 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
                                      Write(item.songName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb46f4ace0d95a09fd76781c31ef1bfe1f3e3b355634", async() => {
                WriteLiteral("Play");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
                                                                      WriteLiteral(item.songId);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 35 "D:\VS lab project\DemoMusicMVC (2)\DemoMusicMVC\DemoMusicMVC\Views\Songs\VisitorPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoMusicMVC.Models.Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591
