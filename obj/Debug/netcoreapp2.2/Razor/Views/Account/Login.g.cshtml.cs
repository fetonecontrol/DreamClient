#pragma checksum "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "649e86f3a46092b60cac247fcc2b0c7b3a25cd0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
using DreamClient.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649e86f3a46092b60cac247fcc2b0c7b3a25cd0f", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(81, 42, true);
            WriteLiteral("\n<h1>Log in with your account</h1>\n<hr />\n");
            EndContext();
#line 11 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(154, 27, false);
#line 13 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(181, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(189, 29, false);
#line 14 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(218, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(227, 30, false);
#line 16 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(257, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(265, 33, false);
#line 17 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(298, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(304, 64, true);
            WriteLiteral("  <input type=\"submit\" value=\"Login\" class=\"btn btn-default\" />\n");
            EndContext();
#line 20 "/Users/frederickernest/Desktop/Epicodus/DreamJournal/DreamClient.Solution/DreamClient/Views/Account/Login.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
