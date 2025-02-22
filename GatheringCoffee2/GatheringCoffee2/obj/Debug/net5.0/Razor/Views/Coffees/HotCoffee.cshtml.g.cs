#pragma checksum "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6521575baa11f06033c3c3a04104dea67cae4bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coffees_HotCoffee), @"mvc.1.0.view", @"/Views/Coffees/HotCoffee.cshtml")]
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
#line 1 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\_ViewImports.cshtml"
using GatheringCoffee2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\_ViewImports.cshtml"
using GatheringCoffee2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6521575baa11f06033c3c3a04104dea67cae4bec", @"/Views/Coffees/HotCoffee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f32c236ad70bcd57e22dec0b7dcadbb5cfe4314", @"/Views/_ViewImports.cshtml")]
    public class Views_Coffees_HotCoffee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
  
    var coffeeHot = (List<CoffeeModel>)ViewData["HotCoffeeModel"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-dark table-striped table-hover"">
    <thead>
        <tr>
            <th></th>
            <th scope=""col"">Id</th>
            <th></th>
            <th scope=""col"" class=""text-nowrap"">Item-Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Image</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
         foreach (var Coffee in coffeeHot)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th></th>\r\n                <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
                           Write(Coffee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th></th>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
               Write(Coffee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
               Write(Coffee.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-nowrap\">");
#nullable restore
#line 27 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
                                   Write(Coffee.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ريال</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 852, "\"", 871, 1);
#nullable restore
#line 28 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
WriteAttributeValue("", 858, Coffee.Image, 858, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" /></td>\r\n                <th></th>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Coffees\HotCoffee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <a href=\"/Coffees/\">\r\n        <button type=\"button\" class=\"btn btn-danger\">Back to Menu of Coffee</button>\r\n    </a>\r\n</div>");
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
