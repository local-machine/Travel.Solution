#pragma checksum "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e4a32019c0b004d74d000527169b04820107b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Delete), @"mvc.1.0.view", @"/Views/Reviews/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Delete.cshtml", typeof(AspNetCore.Views_Reviews_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e4a32019c0b004d74d000527169b04820107b4", @"/Views/Reviews/Delete.cshtml")]
    public class Views_Reviews_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Travel.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 56, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this review?</h2>\n\n");
            EndContext();
            BeginContext(115, 47, false);
#line 9 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(162, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(165, 43, false);
#line 9 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
                                             Write(Html.DisplayFor(Model => Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(208, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(210, 42, false);
#line 10 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(252, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(255, 38, false);
#line 10 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
                                        Write(Html.DisplayFor(Model => Model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(293, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(322, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"delete\"/>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(366, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(368, 43, false);
#line 16 "/Users/Guest/Desktop/Travel.Solution/Travel/Views/Reviews/Delete.cshtml"
Write(Html.ActionLink("Back to Reviews", "Index"));

#line default
#line hidden
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
