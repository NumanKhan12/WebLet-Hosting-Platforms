#pragma checksum "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5749a25a6c11317e5b46ec5142fb459c305cc38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_PanelList), @"mvc.1.0.view", @"/Views/Panel/PanelList.cshtml")]
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
#line 1 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\_ViewImports.cshtml"
using WEBLET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\_ViewImports.cshtml"
using WEBLET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5749a25a6c11317e5b46ec5142fb459c305cc38", @"/Views/Panel/PanelList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7597e1dcd4ac7e220a2bd0b691f39d85016eb6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Panel_PanelList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP_SM_PANEL>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\" id=\"example1\">\r\n    <thead>\r\n        <tr>\r\n            <th>Panel Code</th>\r\n            <th>Panel Name</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 12 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 274, "\"", 343, 7);
            WriteAttributeValue("", 284, "SetValues(\'", 284, 11, true);
#nullable restore
#line 14 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
WriteAttributeValue("", 295, item.ID, 295, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 303, "\',\'", 303, 3, true);
#nullable restore
#line 14 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
WriteAttributeValue("", 306, item.Panel_Code, 306, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 322, "\',\'", 322, 3, true);
#nullable restore
#line 14 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
WriteAttributeValue("", 325, item.Panel_Name, 325, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 341, "\')", 341, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 15 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
               Write(item.Panel_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
               Write(item.Panel_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "D:\Working\project\HOS\Weblet\WEBLET-06-05-21\WEBLET\Views\Panel\PanelList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP_SM_PANEL>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
