#pragma checksum "G:\asp _2\WebBanHang\Areas\Admin\Views\Product\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4705e27d3ed1db7d6ae990969979353400233b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ShowAll), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ShowAll.cshtml")]
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
#line 1 "G:\asp _2\WebBanHang\Areas\Admin\_ViewImports.cshtml"
using WebBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\asp _2\WebBanHang\Areas\Admin\_ViewImports.cshtml"
using WebBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4705e27d3ed1db7d6ae990969979353400233b47", @"/Areas/Admin/Views/Product/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br>
<h2 class=""text-primary"">List Product</h2>
<table id=""myTable"" class=""display"">
    <thead>
        <tr class=""text-primary table-primary "">
            <th>Name</th>
            <th>Price</th>
            <th>Category</th>
            <th>Image</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $.ajax({
                url: ""/Product/GetAll"",
                success: function (data) {
                    $('#myTable').DataTable({
                        data: data,
                        columns: [
                            { data: 'name' },
                            { data: 'price' },
                            { data: 'category.name' },
                            {
                                data: 'imageUrl', render: function (data) {
                                    if (data != null)
                                        return '<img src=""' + data + '"" style=""Width:100px"">'
                                    else
                                        return '';
                                }
                            },
                            {
                                data: 'id', render: function (data) {
                                    let link = '<a href=""/Product/Up");
                WriteLiteral(@"date/' + data + '"" class=""btn btn-outline-primary mr-3""> <i class=""bi bi-pencil-square""></i> Edit </a>';
                                    link += '<a href=""/Product/Delete/' + data + '"" class=""btn btn-outline-danger""><i class=""bi bi-trash""></i>Delete</a>';
                                    return link;
                                }
                            }
                        ]
                    });
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591