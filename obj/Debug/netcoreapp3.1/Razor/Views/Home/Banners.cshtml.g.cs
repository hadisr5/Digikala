#pragma checksum "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa5abdc4ad616f58f3d7ee73c9d67ec0c0f33a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Banners), @"mvc.1.0.view", @"/Views/Home/Banners.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aa5abdc4ad616f58f3d7ee73c9d67ec0c0f33a2", @"/Views/Home/Banners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Banners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiKala.DataAccessLayer.Entities.Banner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""margin-top-50"">

    <h3 class=""pull-right"">
        نمایش تعرفه جایگاه های تبلیغات
    </h3>
</div>

<div class=""margin-top-30"">

    <table class=""table table-bordered table-hover"">

        <thead>

            <tr>

                <th>
                    ");
#nullable restore
#line 23 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
               Write(Html.DisplayNameFor(model => model.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
               Write(Html.DisplayNameFor(model => model.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 40 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
                   Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ریال\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Home\Banners.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigiKala.DataAccessLayer.Entities.Banner>> Html { get; private set; }
    }
}
#pragma warning restore 1591