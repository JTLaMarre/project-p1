#pragma checksum "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9be2ab1ff79177468a551d2628af321a76e84b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9be2ab1ff79177468a551d2628af321a76e84b7", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lorda\Sandbox\revature\project-p1\PizzaBox.Client\Views\Order\Order.cshtml"
  
  ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row justify-content-center"">
  <div class=""col-sm""></div>
  <div class=""col-sm"">
    <h2 class="" bg-danger text-white"">Lets Start a Pizza Order</h2>
  </div>
  <div class=""col-sm""></div>

</div>
<div class=""row justify-content-center"">
  <div class=""col-md""></div>
  <div class=""col-md"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9be2ab1ff79177468a551d2628af321a76e84b73773", async() => {
                WriteLiteral(@"
      <h3 class=""bg-danger text-white"">Choose a Store</h3>
      <div class=""input-group"">
        <div class=""input-group-prepend"">
          <div class=""input-group-text"">
            <label for=""store1"">
              <input type=""checkbox"">
              LaMarrinos
            </label>
            <br>
            <label for=""store2"">
              <input type=""checkbox"">
              Meetzeronis
            </label>
          </div>
        </div>
        <br>
        <div class=""row justify-content-center"">

        <h3 class=""bg-danger text-white""> Choose Pizzas</h3>
        <div class=""input-group"">
          <div class=""input-group-prepend"">
            <div class=""input-group-text"">
              <label for=""pepperoni"">
                <input type=""checkbox"">
                Pepperoni
              </label>
            </div>
            <input type=""number"" class=""form-control"">
          </div>
        </div>
        <div class=""input-group"">
          <div class=");
                WriteLiteral(@"""input-group-prepend"">
            <div class=""input-group-text"">
              <label for=""cheese"">
                <input type=""checkbox"">
                Four Cheese
              </label>
            </div>
            <input type=""number"" class=""form-control"">
          </div>
        </div>
        <div class=""input-group"">
          <div class=""input-group-prepend"">
            <div class=""input-group-text"">
              <label for=""meat"">
                <input type=""checkbox"">
                Meat Pizza
              </label>
            </div>
            <input type=""number"" class=""form-control"">
          </div>
        </div>
        <div class=""input-group"">
          <div class=""input-group-prepend"">
            <div class=""input-group-text"">
              <label for=""veggie"">
                <input type=""checkbox"">
                Veggie Pizza
              </label>
            </div>
            <input type=""number"" class=""form-control"">
          </div>
      ");
                WriteLiteral("  </div>\r\n        </div>\r\n\r\n      </div>\r\n\r\n      <br>\r\n\r\n\r\n      <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n  <div class=\"col-md\"></div>\r\n\r\n</div>");
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