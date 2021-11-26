#pragma checksum "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd9dbe6a503e9ef537aaf1cacf00f768896824dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_ShowStoreCategory), @"mvc.1.0.view", @"/Views/Panel/ShowStoreCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9dbe6a503e9ef537aaf1cacf00f768896824dc", @"/Views/Panel/ShowStoreCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_ShowStoreCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiKala.DataAccessLayer.Entities.StoreCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
  
    ViewData["Title"] = "مدارک فروشگاه";
    Layout = "~/Views/Shared/_Panel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-offset-3 col-lg-8 col-md-offset-3 col-md-8 col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1 panel-back"">

    <div class=""margin-top-50"">

        <h3 class=""pull-right"">
            مجوز های فروشگاه
        </h3>
        <h3 class=""pull-left"">
            <a href=""#"" onclick=""MyCreate()"" class=""btn btn-primary"">جدید</a>
        </h3>

    </div>

    <div class=""margin-top-30"">

        <table class=""table table-bordered table-hover"" id=""myTable"">

            <thead>

                <tr>

                    <th>
                        ");
#nullable restore
#line 30 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                   Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </th>
                    <th>
                        وضعیت
                    </th>
                    <th>
                        عملیات
                    </th>

                </tr>

            </thead>

            <tbody>

");
#nullable restore
#line 48 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                 foreach (var item in Model)
                {
                    string status = "";
                    string color = "";

                    if (item.IsActive)
                    {
                        status = "تأیید شده";
                        color = "darkslategrey";
                    }
                    else
                    {
                        if (item.Desc != null)
                        {
                            status = "تأیید نشده";
                            color = "darkred";
                        }
                        else
                        {
                            status = "درانتظار";
                            color = "dodgerblue";
                        }
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td");
            BeginWriteAttribute("style", " style=\"", 2316, "\"", 2337, 2);
            WriteAttributeValue("", 2324, "color:", 2324, 6, true);
#nullable restore
#line 79 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
WriteAttributeValue(" ", 2330, color, 2331, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 80 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                       Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2480, "\'", 2506, 3);
            WriteAttributeValue("", 2490, "MyEdit(", 2490, 7, true);
#nullable restore
#line 84 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
WriteAttributeValue("", 2497, item.Id, 2497, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2505, ")", 2505, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-warning\">اصلاح</a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2585, "\'", 2613, 3);
            WriteAttributeValue("", 2595, "MyDelete(", 2595, 9, true);
#nullable restore
#line 85 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
WriteAttributeValue("", 2604, item.Id, 2604, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2612, ")", 2612, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-danger\">حذف</a>\r\n");
#nullable restore
#line 86 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                             if (status == "تأیید نشده")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 2782, "\'", 2810, 3);
            WriteAttributeValue("", 2792, "MyDetail(", 2792, 9, true);
#nullable restore
#line 88 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
WriteAttributeValue("", 2801, item.Id, 2801, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2809, ")", 2809, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-info\">توضیح</a>\r\n");
#nullable restore
#line 89 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 92 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\ShowStoreCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>

        </table>

    </div>

</div>

<div id=""myModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"">

    <div class=""modal-dialog"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div id=""bodyModal"" class=""modal-body"">



            </div>

        </div>

    </div>

</div>

");
            DefineSection("mySection", async() => {
                WriteLiteral(@"
    <script>
        function MyCreate() {
            $.ajax({
                url: ""/Panel/CreateStoreCategory/"",
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>

    <script>
        function MyEdit(id) {
            $.ajax({
                url: ""/Panel/EditStoreCategory/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>

    <script>
        function MyDelete(id) {
            $.ajax({
                url: ""/Panel/DeleteStoreCategory/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(re");
                WriteLiteral(@"sult);
            });
        }
    </script>

    <script>
        function MyDetail(id) {
            $.ajax({
                url: ""/Panel/DetailsStoreCategory/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigiKala.DataAccessLayer.Entities.StoreCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
