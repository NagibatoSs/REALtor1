#pragma checksum "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d76fb6fbbafe434a3183fcda491354e8be677819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_House_ListHouses), @"mvc.1.0.view", @"/Areas/Admin/Views/House/ListHouses.cshtml")]
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
#line 1 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d76fb6fbbafe434a3183fcda491354e8be677819", @"/Areas/Admin/Views/House/ListHouses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0990affcd7cc8670d8c9ead3881924587fa084", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_House_ListHouses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
  
    foreach (var house in Model.getAllHouses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h3>");
#nullable restore
#line 5 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
           Write(house.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h1>admin</h1>\r\n            <p>");
#nullable restore
#line 7 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
          Write(house.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" рублей </p>\r\n            <p> Площадь:");
#nullable restore
#line 8 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
                   Write(house.Square);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Район:");
#nullable restore
#line 8 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
                                       Write(house.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Адресс:");
#nullable restore
#line 8 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
                                                          Write(house.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 9 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
          Write(house.Despription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 314, "\"", 330, 1);
#nullable restore
#line 10 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
WriteAttributeValue("", 320, house.Img, 320, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 331, "\"", 348, 1);
#nullable restore
#line 10 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
WriteAttributeValue("", 337, house.Name, 337, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\ккккк\OneDrive\Рабочий стол\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHouses.cshtml"
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
