#pragma checksum "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeeb99297825675005c96b863814ad5e516c075a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Details.cshtml", typeof(AspNetCore.Views_Items_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeeb99297825675005c96b863814ad5e516c075a", @"/Views/Items/Details.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectName.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 34, true);
            WriteLiteral("\n<h2>Item Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(94, 47, false);
#line 9 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(144, 43, false);
#line 9 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(187, 8, true);
            WriteLiteral("<h3>\n<p>");
            EndContext();
            BeginContext(196, 63, false);
#line 10 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
Write(Html.ActionLink("Edit Item", "Edit", new { id = Model.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(259, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(268, 67, false);
#line 11 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
Write(Html.ActionLink("Delete Item", "Delete", new { id = Model.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(335, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(344, 40, false);
#line 12 "/Users/Guest/Desktop/best-restaurants/Project/Views/Items/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectName.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591