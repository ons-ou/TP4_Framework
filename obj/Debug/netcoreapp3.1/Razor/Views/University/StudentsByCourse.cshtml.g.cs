#pragma checksum "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6bd3c765a772cb0a7c280e62cefbc0a52746b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_University_StudentsByCourse), @"mvc.1.0.view", @"/Views/University/StudentsByCourse.cshtml")]
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
#line 1 "D:\gl3\framework\TP\TP4\TP4\Views\_ViewImports.cshtml"
using TP4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gl3\framework\TP\TP4\TP4\Views\_ViewImports.cshtml"
using TP4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6bd3c765a772cb0a7c280e62cefbc0a52746b82", @"/Views/University/StudentsByCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b173d7836b18eb9b4054565acfcbff20e65bc1", @"/Views/_ViewImports.cshtml")]
    public class Views_University_StudentsByCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Students Enrolled in ");
#nullable restore
#line 4 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
                    Write(ViewData["course"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">Phone Number</th>
            <th scope=""col"">University</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 20 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
               Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
               Write(p.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
               Write(p.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
               Write(p.phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
               Write(p.university);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\gl3\framework\TP\TP4\TP4\Views\University\StudentsByCourse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591