#pragma checksum "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0405a53b262ccd19cca0542514daaf4fbbb75c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0405a53b262ccd19cca0542514daaf4fbbb75c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Home/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 104, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"card\">\n        <h1>Welcome to the Travel Yelp!</h1>\n        <p>");
            EndContext();
            BeginContext(134, 54, false);
#line 8 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Home/Index.cshtml"
      Write(Html.ActionLink("See all reviews", "Index", "Reviews"));

#line default
#line hidden
            EndContext();
            BeginContext(188, 16, true);
            WriteLiteral("</p>\n        <p>");
            EndContext();
            BeginContext(205, 52, false);
#line 9 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Home/Index.cshtml"
      Write(Html.ActionLink("See all places", "Index", "Places"));

#line default
#line hidden
            EndContext();
            BeginContext(257, 22, true);
            WriteLiteral("</p>\n    </div>\n</div>");
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
