#pragma checksum "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06753ad065915f0fbac0809dbc52cd9b81f2612e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Houses_ListHouses), @"mvc.1.0.view", @"/Views/Houses/ListHouses.cshtml")]
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
#line 1 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\_ViewImports.cshtml"
using REALtor1._2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06753ad065915f0fbac0809dbc52cd9b81f2612e", @"/Views/Houses/ListHouses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f6bcb7cb6d4c70948ba87816da55c26d52e03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Houses_ListHouses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<button href=\"/Houses/Parametrs\" class=\"open-popup\">Параметры</button>\r\n");
#nullable restore
#line 5 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
    foreach (var house in Model.getAllHouses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"list\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 162, "\"", 178, 1);
#nullable restore
#line 8 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
WriteAttributeValue("", 168, house.Img, 168, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 179, "\"", 196, 1);
#nullable restore
#line 8 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
WriteAttributeValue("", 185, house.Name, 185, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h3>");
#nullable restore
#line 9 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
   Write(house.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
  Write(house.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" рублей </p>\r\n    <p> Площадь:");
#nullable restore
#line 11 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
           Write(house.Square);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p> Район:");
#nullable restore
#line 12 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
         Write(house.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Адрес:");
#nullable restore
#line 12 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
                           Write(house.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
  Write(house.Despription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n");
#nullable restore
#line 16 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Views\Houses\ListHouses.cshtml"
    }

#line default
#line hidden
#nullable disable
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
