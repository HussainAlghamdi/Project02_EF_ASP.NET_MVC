#pragma checksum "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a633423cfc704377d2455026590902d173d0d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a633423cfc704377d2455026590902d173d0d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f32c236ad70bcd57e22dec0b7dcadbb5cfe4314", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hussa\source\repos\GatheringCoffee2\GatheringCoffee2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center w-100"">
    <div class=""text-center"">
        <div class=""header"">
            <h1 class=""display-4 fs-1 white-title"">Gathering Caffee</h1>

            <h2 class=""align-bottom white-title"">Welecome To Our Coffee</h2>
        </div>
        <div class=""row text-center"">

            <div class=""col-6 center-card"">
                <div class=""card text-dark bg-light mb-3"" style=""max-width: 18rem;"">
                    <div class=""card-header"">Gathering Caffee</div>
                    <div class=""card-body"">
                        <h5 class=""card-title"">Coffee</h5>
                        <p class=""card-text"">Here we have a list of the best hot and cold coffees.</p>
                        <a class=""btn btn-primary"" href=""./Coffees/"">Go To Menu</a>
                    </div>
                </div>
            </div>

            <div class=""col-6 center-card"">
                <div class=""card text-dark bg-light mb-3"" style=""max-width: 18rem;"">

                  ");
            WriteLiteral(@"  <div class=""card-header"">Gathering Caffee</div>
                    <div class=""card-body"">
                        <h5 class=""card-title"">Sweet and Food</h5>
                        <p class=""card-text"">Here we have a list of the best Sweet and Food.</p>
                        <a class=""btn btn-primary"" href=""./SweetsAndFoods/"">Go To Menu</a>
                    </div>

                </div>
            </div>
        </div>
");
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
