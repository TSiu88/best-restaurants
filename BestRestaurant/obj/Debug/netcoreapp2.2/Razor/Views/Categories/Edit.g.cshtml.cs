#pragma checksum "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb94f449813b6c9d16ce3a4b0ca5e1304fec0d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Edit), @"mvc.1.0.view", @"/Views/Categories/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Edit.cshtml", typeof(AspNetCore.Views_Categories_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb94f449813b6c9d16ce3a4b0ca5e1304fec0d8", @"/Views/Categories/Edit.cshtml")]
    public class Views_Categories_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectName.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 40, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this category: ");
            EndContext();
            BeginContext(104, 36, false);
#line 9 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(180, 41, false);
#line 13 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(228, 34, false);
#line 15 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(268, 35, false);
#line 16 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(305, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(348, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(352, 46, false);
#line 20 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Edit.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(398, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectName.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
