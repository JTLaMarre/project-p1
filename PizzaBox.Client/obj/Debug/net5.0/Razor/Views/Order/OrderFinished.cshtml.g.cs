#pragma checksum "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26c24b1c17b7f60047f63de32f00157a3639a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderFinished), @"mvc.1.0.view", @"/Views/Order/OrderFinished.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26c24b1c17b7f60047f63de32f00157a3639a37", @"/Views/Order/OrderFinished.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderFinished : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n<div class=\"col\"></div>\r\n<div class=\"col\">\r\n    <h1>Final Order from ");
#nullable restore
#line 7 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
                    Write(Model.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr>\r\n    <h2>");
#nullable restore
#line 9 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
   Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" you have ordered:</h2>\r\n");
#nullable restore
#line 10 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
     foreach (var item in Model.Pizzas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 13 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 15 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Total = $ ");
#nullable restore
#line 16 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\OrderFinished.cshtml"
             Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Return home to make another order or review order history</p>\r\n</div>\r\n<div class=\"col\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591