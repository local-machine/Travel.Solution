#pragma checksum "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248dd4f49eb06d5da671b2d9c2316c91c905e5e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Edit), @"mvc.1.0.view", @"/Views/Reviews/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Edit.cshtml", typeof(AspNetCore.Views_Reviews_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248dd4f49eb06d5da671b2d9c2316c91c905e5e7", @"/Views/Reviews/Edit.cshtml")]
    public class Views_Reviews_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Travel.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 38, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this review: ");
            EndContext();
            BeginContext(97, 43, false);
#line 9 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(140, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
 using (Html.BeginForm())
{


    

#line default
#line hidden
            BeginContext(182, 39, false);
#line 15 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.HiddenFor(model => model.ReviewId));

#line default
#line hidden
            EndContext();
            BeginContext(228, 35, false);
#line 17 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.LabelFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(269, 28, false);
#line 18 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.DropDownList("PlaceId"));

#line default
#line hidden
            EndContext();
            BeginContext(299, 42, true);
            WriteLiteral("    <h4>Review Description</h4>\n    <hr/>\n");
            EndContext();
            BeginContext(346, 41, false);
#line 22 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(393, 42, false);
#line 23 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(436, 50, true);
            WriteLiteral("    <br/>\n    <h4>Rate from 1 - 5 </h4>\n    <hr/>\n");
            EndContext();
            BeginContext(491, 36, false);
#line 27 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.LabelFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(533, 37, false);
#line 28 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.EditorFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(578, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 33 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(621, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(626, 43, false);
#line 35 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Edit.cshtml"
Write(Html.ActionLink("Back to Reviews", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Travel.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
