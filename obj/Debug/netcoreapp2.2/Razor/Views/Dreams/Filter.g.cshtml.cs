#pragma checksum "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d462f3394f2ba9ecdd37a30980dd7bc722857375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dreams_Filter), @"mvc.1.0.view", @"/Views/Dreams/Filter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dreams/Filter.cshtml", typeof(AspNetCore.Views_Dreams_Filter))]
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
#line 4 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
using DreamClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d462f3394f2ba9ecdd37a30980dd7bc722857375", @"/Views/Dreams/Filter.cshtml")]
    public class Views_Dreams_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(53, 45, true);
            WriteLiteral("<h1>Dreams that match your query:</h1>\n\n<ol>\n");
            EndContext();
#line 8 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
 foreach(Dream dream in Model)
{

#line default
#line hidden
            BeginContext(131, 21, true);
            WriteLiteral("  <ul>\n    <li>Date: ");
            EndContext();
            BeginContext(153, 10, false);
#line 11 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
         Write(dream.Date);

#line default
#line hidden
            EndContext();
            BeginContext(163, 20, true);
            WriteLiteral("</li>\n    <li>User: ");
            EndContext();
            BeginContext(184, 14, false);
#line 12 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
         Write(dream.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(198, 21, true);
            WriteLiteral("</li>\n    <li>Title: ");
            EndContext();
            BeginContext(220, 11, false);
#line 13 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
          Write(dream.Title);

#line default
#line hidden
            EndContext();
            BeginContext(231, 20, true);
            WriteLiteral("</li>\n    <li>Body: ");
            EndContext();
            BeginContext(252, 10, false);
#line 14 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
         Write(dream.Body);

#line default
#line hidden
            EndContext();
            BeginContext(262, 22, true);
            WriteLiteral("</li>\n  </ul>\n  <br/>\n");
            EndContext();
#line 17 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Dreams/Filter.cshtml"
}

#line default
#line hidden
            BeginContext(286, 5, true);
            WriteLiteral("</ol>");
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
