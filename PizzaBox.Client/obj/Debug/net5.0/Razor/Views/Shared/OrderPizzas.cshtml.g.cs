#pragma checksum "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dcace039daaceed0973fc19ad1f19fbcb1019c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_OrderPizzas), @"mvc.1.0.view", @"/Views/Shared/OrderPizzas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dcace039daaceed0973fc19ad1f19fbcb1019c3", @"/Views/Shared/OrderPizzas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_OrderPizzas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderPizzasViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>Order History</h3>\r\n<hr>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
  
    int Total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Pizzas Ordered From ");
#nullable restore
#line 11 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
                   Write(Model.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 12 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
 foreach (var item in Model.Pizzas)
{   
    Total = Total + 10;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 15 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
                                                          
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Total:$ ");
#nullable restore
#line 18 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Shared\OrderPizzas.cshtml"
       Write(Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderPizzasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
