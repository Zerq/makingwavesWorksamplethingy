#pragma checksum "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192d5da9bab1f8581e5be4c9bd5f7b183297a0bd"
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
#line 1 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\_ViewImports.cshtml"
using MakingWaves;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\_ViewImports.cshtml"
using MakingWaves.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
using MakingWaves.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"192d5da9bab1f8581e5be4c9bd5f7b183297a0bd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834b9b617e4ce5e3e2391f27b494293d950f74f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<ExampleData> Group1, List<ExampleData> Group2, List<ExampleData> Group3, PagingModel paging)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ColorList\">\r\n    <h3>ColorExamples</h3>\r\n    <ul class=\"group1\">\r\n        <h4>Group1</h4>\r\n");
#nullable restore
#line 10 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
         foreach (var item in this.Model.Group1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"colorBlock\"");
            BeginWriteAttribute("style", " style=\"", 380, "\"", 486, 10);
            WriteAttributeValue("", 388, "background-color:", 388, 17, true);
#nullable restore
#line 12 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 405, item.Color, 405, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 416, ";", 416, 1, true);
            WriteAttributeValue(" ", 417, "border:solid", 418, 13, true);
            WriteAttributeValue(" ", 430, "1px", 431, 4, true);
#nullable restore
#line 12 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 434, item.ContrastColor(), 435, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 456, ";", 456, 1, true);
            WriteAttributeValue(" ", 457, "color:", 458, 7, true);
#nullable restore
#line 12 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 464, item.ContrastColor(), 464, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 485, ";", 485, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>");
#nullable restore
#line 13 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 14 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.PantoneValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 15 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </li>\r\n");
#nullable restore
#line 17 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"group2\">\r\n        <h4>Group2</h4>\r\n");
#nullable restore
#line 21 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
         foreach (var item in this.Model.Group2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"colorBlock\"");
            BeginWriteAttribute("style", " style=\"", 801, "\"", 907, 10);
            WriteAttributeValue("", 809, "background-color:", 809, 17, true);
#nullable restore
#line 23 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 826, item.Color, 826, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 837, ";", 837, 1, true);
            WriteAttributeValue(" ", 838, "border:solid", 839, 13, true);
            WriteAttributeValue(" ", 851, "1px", 852, 4, true);
#nullable restore
#line 23 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 855, item.ContrastColor(), 856, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 877, ";", 877, 1, true);
            WriteAttributeValue(" ", 878, "color:", 879, 7, true);
#nullable restore
#line 23 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 885, item.ContrastColor(), 885, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 906, ";", 906, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>");
#nullable restore
#line 24 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 25 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.PantoneValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 26 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </li>\r\n");
#nullable restore
#line 28 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"group3\">\r\n        <h4>Group3</h4>\r\n");
#nullable restore
#line 32 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
         foreach (var item in this.Model.Group3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"colorBlock\"");
            BeginWriteAttribute("style", " style=\"", 1222, "\"", 1328, 10);
            WriteAttributeValue("", 1230, "background-color:", 1230, 17, true);
#nullable restore
#line 34 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 1247, item.Color, 1247, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1258, ";", 1258, 1, true);
            WriteAttributeValue(" ", 1259, "border:solid", 1260, 13, true);
            WriteAttributeValue(" ", 1272, "1px", 1273, 4, true);
#nullable restore
#line 34 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1276, item.ContrastColor(), 1277, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1298, ";", 1298, 1, true);
            WriteAttributeValue(" ", 1299, "color:", 1300, 7, true);
#nullable restore
#line 34 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
WriteAttributeValue("", 1306, item.ContrastColor(), 1306, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1327, ";", 1327, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>");
#nullable restore
#line 35 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 36 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.PantoneValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>");
#nullable restore
#line 37 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
                Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </li>\r\n");
#nullable restore
#line 39 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n   ");
#nullable restore
#line 43 "C:\Users\zerq_\Source\Repos\Zerq\makingwavesWorksamplethingy\MakingWaves\MakingWaves\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("../shared/_PagingPartial.cshtml", Model.paging));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<ExampleData> Group1, List<ExampleData> Group2, List<ExampleData> Group3, PagingModel paging)> Html { get; private set; }
    }
}
#pragma warning restore 1591
