#pragma checksum "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65891d718bb20f15f12b63399ebde17feb2fcd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Create.cshtml", typeof(AspNetCore.Views_Categories_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65891d718bb20f15f12b63399ebde17feb2fcd3", @"/Views/Categories/Create.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectName.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 29, true);
            WriteLiteral("\n<h4>Add a new category</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(125, 34, false);
#line 10 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(165, 36, false);
#line 11 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(202, 53, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new category\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
}

#line default
#line hidden
            BeginContext(257, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(261, 47, false);
#line 14 "/Users/Guest/Desktop/best-restaurants/Project/Views/Categories/Create.cshtml"
Write(Html.ActionLink("Show all categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(308, 4, true);
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