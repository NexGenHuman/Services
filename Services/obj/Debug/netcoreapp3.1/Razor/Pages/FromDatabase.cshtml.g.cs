#pragma checksum "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\FromDatabase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "860cc611e3ec789504d5f6c7c95bfd28fe0b5a73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Services.Pages.Pages_FromDatabase), @"mvc.1.0.razor-page", @"/Pages/FromDatabase.cshtml")]
namespace Services.Pages
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
#line 1 "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\_ViewImports.cshtml"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"860cc611e3ec789504d5f6c7c95bfd28fe0b5a73", @"/Pages/FromDatabase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d02e3b1fc2f11832b39b1c0e3340981648a341", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FromDatabase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 7 "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\FromDatabase.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 184, "\"", 232, 4);
            WriteAttributeValue("", 192, "background-image:", 192, 17, true);
            WriteAttributeValue(" ", 209, "url(\'", 210, 6, true);
#nullable restore
#line 10 "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\FromDatabase.cshtml"
WriteAttributeValue("", 215, product.Image, 215, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 229, "\');", 229, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"card-body\">\r\n                <div class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\FromDatabase.cshtml"
                                   Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\NexGenHuman\source\repos\Services\Services\Pages\FromDatabase.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FromDatabaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FromDatabaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FromDatabaseModel>)PageContext?.ViewData;
        public FromDatabaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
