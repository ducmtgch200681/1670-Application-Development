#pragma checksum "G:\Git\1670-Application-Development\Learn3\Views\Home\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87215e128efaa7b93a2be972cce8e0d4b95b13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Razor), @"mvc.1.0.view", @"/Views/Home/Razor.cshtml")]
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
#line 1 "G:\Git\1670-Application-Development\Learn3\Views\_ViewImports.cshtml"
using Learn3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\1670-Application-Development\Learn3\Views\_ViewImports.cshtml"
using Learn3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87215e128efaa7b93a2be972cce8e0d4b95b13a", @"/Views/Home/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a187b4cf8224a534c8b34be46b74349ebb8dfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Razor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\Git\1670-Application-Development\Learn3\Views\Home\Razor.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!--\r\n    comment with traditional html\r\n-->\r\n\r\n");
#nullable restore
#line 13 "G:\Git\1670-Application-Development\Learn3\Views\Home\Razor.cshtml"
  
    //comment with C# in only 1 line
    /*
         comment multiple lines
    */
    var fpt = "FPT cooperator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Email: maitheduc2002@gmail.com</h2>\r\n<h3>print value using: ");
#nullable restore
#line 22 "G:\Git\1670-Application-Development\Learn3\Views\Home\Razor.cshtml"
                  Write(fpt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>print a using: </h3> ");
            WriteLiteral("@fpt\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
