#pragma checksum "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310fe1915457102b6d1cf3efc5b91a378b3c11a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_House_ListHousesFiltr), @"mvc.1.0.view", @"/Areas/Admin/Views/House/ListHousesFiltr.cshtml")]
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
#line 1 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\_ViewImports.cshtml"
using REALtor1._2.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310fe1915457102b6d1cf3efc5b91a378b3c11a9", @"/Areas/Admin/Views/House/ListHousesFiltr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0990affcd7cc8670d8c9ead3881924587fa084", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_House_ListHousesFiltr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"open-popup\">\r\n        <a href=\"?Admin/House/Parametrs\" id=\"open-popup\">Параметры</a>\r\n    </div>\r\n");
#nullable restore
#line 5 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
    foreach (var house in Model.getAllHouses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"list\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 232, 1);
#nullable restore
#line 8 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
WriteAttributeValue("", 222, house.Img, 222, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 233, "\"", 250, 1);
#nullable restore
#line 8 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
WriteAttributeValue("", 239, house.Name, 239, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h3>");
#nullable restore
#line 9 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
           Write(house.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
          Write(house.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" рублей </p>\r\n            <p> Площадь:");
#nullable restore
#line 11 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                   Write(house.Square);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>Количество комнат: ");
#nullable restore
#line 12 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                             Write(house.CountOfRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 13 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
          Write(house.StatusOfHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p> Район:");
#nullable restore
#line 14 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                 Write(house.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p> Адрес:");
#nullable restore
#line 15 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                 Write(house.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p> Условия жизни: </p>\r\n            <p>");
#nullable restore
#line 17 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                   if (house.coldWater == true)

#line default
#line hidden
#nullable disable
            WriteLiteral(" Холодная вода </p>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                   if (house.hotWater == true)

#line default
#line hidden
#nullable disable
            WriteLiteral(" Горячая вода </p>\r\n            <p>");
#nullable restore
#line 19 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                   if (house.electricity == true)

#line default
#line hidden
#nullable disable
            WriteLiteral(" Электричество </p>\r\n            <p>");
#nullable restore
#line 20 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
                   if (house.gas == true)

#line default
#line hidden
#nullable disable
            WriteLiteral(" Газ </p>\r\n            <p>");
#nullable restore
#line 21 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
          Write(house.Despription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\zhura\OneDrive\Рабочий стол\гит ласт\REALtor1\REALtor1.2\Areas\Admin\Views\House\ListHousesFiltr.cshtml"
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