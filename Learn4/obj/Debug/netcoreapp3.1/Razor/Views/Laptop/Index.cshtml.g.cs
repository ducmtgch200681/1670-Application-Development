#pragma checksum "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bcee86801e795fd6bd303474a10a6ba8e369d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptop_Index), @"mvc.1.0.view", @"/Views/Laptop/Index.cshtml")]
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
#line 1 "G:\Git\1670-Application-Development\Learn4\Views\_ViewImports.cshtml"
using Learn4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\1670-Application-Development\Learn4\Views\_ViewImports.cshtml"
using Learn4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcee86801e795fd6bd303474a10a6ba8e369d61", @"/Views/Laptop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f878a7b660af96c4ff0af99ef9ec0c2d2045a9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Laptop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Laptop>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container col-md-8 text-center"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Laptop Name</th>
                <th>Quantity</th>
                <th>Image</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 14 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
             for (var i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
                   Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
                   Write(Model[i].Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src = \"", 585, "\"", 608, 1);
#nullable restore
#line 20 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
WriteAttributeValue("", 593, Model[i].Image, 593, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=100% height=100% /></td>\r\n                    <td>");
#nullable restore
#line 21 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
                   Write(Model[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "G:\Git\1670-Application-Development\Learn4\Views\Laptop\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Laptop>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
