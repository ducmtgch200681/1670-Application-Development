#pragma checksum "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cbe2e1fc0e832944e4173a872827b204dffeb4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentInfo), @"mvc.1.0.view", @"/Views/Student/StudentInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbe2e1fc0e832944e4173a872827b204dffeb4e", @"/Views/Student/StudentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a187b4cf8224a534c8b34be46b74349ebb8dfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_StudentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Learn3.Models.Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Student ID: ");
#nullable restore
#line 3 "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Student Name: ");
#nullable restore
#line 4 "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Student Age: ");
#nullable restore
#line 5 "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml"
            Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Student Grade: ");
#nullable restore
#line 6 "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml"
              Write(Model.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Student Image:</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 201, "\"", 219, 1);
#nullable restore
#line 8 "G:\Git\1670-Application-Development\Learn3\Views\Student\StudentInfo.cshtml"
WriteAttributeValue("", 207, Model.Image, 207, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Learn3.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
