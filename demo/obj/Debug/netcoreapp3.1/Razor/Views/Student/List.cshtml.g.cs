#pragma checksum "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f67e282f4a3a942a4460c6e6cbe96800b802ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_List), @"mvc.1.0.view", @"/Views/Student/List.cshtml")]
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
#line 1 "G:\Git\1670-Application-Development\demo\Views\_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\1670-Application-Development\demo\Views\_ViewImports.cshtml"
using demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f67e282f4a3a942a4460c6e6cbe96800b802ce", @"/Views/Student/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"594e9c5f3c8630c561dc3619a70a1608f19024e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
 foreach (var s in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ol>\n        <li>Name: ");
#nullable restore
#line 6 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
             Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Student Id: ");
#nullable restore
#line 7 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
                   Write(s.SId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>DOB: ");
#nullable restore
#line 8 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
            Write(s.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 9 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
          
            var birthyear = s.Birthday.Year;
            var currentyear = DateTime.Now.Year;
            var age = currentyear - birthyear;

        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Birth year: ");
#nullable restore
#line 15 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
                   Write(birthyear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>Age: ");
#nullable restore
#line 16 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
            Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\n        <li>Image: \n            <img");
            BeginWriteAttribute("src", " src=\"", 447, "\"", 461, 1);
#nullable restore
#line 19 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
WriteAttributeValue("", 453, s.Image, 453, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\">\n        </li>\n");
#nullable restore
#line 21 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
          
            var gender = "";
            if (s.Gender == 'M')
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            Gender: ");
#nullable restore
#line 33 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
               Write(gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n");
#nullable restore
#line 35 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
          
            var note = "";
        if (s.IsGraduated == true)
        {
            note = "Student has graduated !";
        } else {
            note = "Student has not graduated yet !";
         }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            Note: ");
#nullable restore
#line 45 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
             Write(note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n    </ol>\n");
#nullable restore
#line 48 "G:\Git\1670-Application-Development\demo\Views\Student\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
