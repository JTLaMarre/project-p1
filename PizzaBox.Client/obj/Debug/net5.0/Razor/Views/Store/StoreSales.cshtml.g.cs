#pragma checksum "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Store\StoreSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95128c0c92a05b69058cd4fc818e79422030048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreSales), @"mvc.1.0.view", @"/Views/Store/StoreSales.cshtml")]
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
#line 1 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95128c0c92a05b69058cd4fc818e79422030048", @"/Views/Store/StoreSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_StoreSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.StoreViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Store\StoreSales.cshtml"
  
    ViewData["Title"] = "Store History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\"></div>\r\n    <div class=\"col\">\r\n        <h1>");
#nullable restore
#line 9 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Store\StoreSales.cshtml"
       Write(Model.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Total Sales Revenue to date:$ ");
#nullable restore
#line 9 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Store\StoreSales.cshtml"
                                                  Write(Model.Revenue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    </div>
    <div class=""col""></div>
</div>
<div class=""row"">
<div class=""col"" ></div>
<div class=""col"" >
    <a href=""/Home"" class=""btn btn-primary"">Return Home</a>
    <br>
    <br>
    <a href=""/Stores"" class=""btn btn-info"">
    Return to Stores
    </a>
    <br>
    <br>
</div>
<div class=""col"" ></div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.StoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591