#pragma checksum "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e882e822ac12729f493cb465f7b2088a14a099b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 2 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e882e822ac12729f493cb465f7b2088a14a099b", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21bb3d15c31c9fb8b3f01c7beefa5f51dff066f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultServiceDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Hizmet Başlığı</th>\r\n            <th>Sil</th>\r\n            <th>Güncelle</th>\r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
               Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 19 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 491, "\"", 536, 2);
            WriteAttributeValue("", 498, "/Service/DeleteService/", 498, 23, true);
#nullable restore
#line 20 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
WriteAttributeValue("", 521, item.ServiceID, 521, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 614, "\"", 659, 2);
            WriteAttributeValue("", 621, "/Service/UpdateService/", 621, 23, true);
#nullable restore
#line 21 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
WriteAttributeValue("", 644, item.ServiceID, 644, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-success\">Güncelle</a></td>\r\n               \r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\admin\source\repos\HotelProject\FrontEnd\HotelProject.WebUI\Views\Service\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </table>\r\n    <a href=\"/Service/AddService/\" class=\"btn mb-1 btn-rounded btn-info\">Yeni Hizmet Giriş</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultServiceDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591