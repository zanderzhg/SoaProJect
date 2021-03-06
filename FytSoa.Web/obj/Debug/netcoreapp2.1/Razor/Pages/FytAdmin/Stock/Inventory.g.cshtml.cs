#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e68774b70aeb159ee844579322da505d68edf6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Inventory), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/Inventory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/Inventory.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Inventory), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e68774b70aeb159ee844579322da505d68edf6f", @"/Pages/FytAdmin/Stock/Inventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_Inventory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
  
    ViewData["Title"] = "库存盘点";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(147, 574, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <div class=""layui-inline"">
                <select id=""years"" lay-search="""">
                    ");
            EndContext();
            BeginContext(721, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04835c34038d4e7bb306b6bfef2998dc", async() => {
                BeginContext(738, 11, true);
                WriteLiteral("--可根据年份搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(758, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                      
                        if (Model.yearCodeList != null)
                        {
                            foreach (var item in Model.yearCodeList)
                            {

#line default
#line hidden
            BeginContext(969, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1001, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dcf442ad6d74ed3b56fc1d9c64aca53", async() => {
                BeginContext(1029, 9, false);
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1047, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(1130, 145, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"branks\">\r\n                    ");
            EndContext();
            BeginContext(1275, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85df42f533d14da5b4ca08348ea46666", async() => {
                BeginContext(1292, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1312, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                      
                        foreach (var item in Model.codeList)
                        {

#line default
#line hidden
            BeginContext(1427, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1455, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b93605b7f2b84a75b150d59d853ceec0", async() => {
                BeginContext(1483, 9, false);
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1501, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1553, 160, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"seasons\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(1713, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f043dfe8eb724a6ea542647aa0069b21", async() => {
                BeginContext(1730, 11, true);
                WriteLiteral("--可根据季节搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1750, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                      
                        if (Model.seasonCodeList != null)
                        {
                            foreach (var item in Model.seasonCodeList)
                            {

#line default
#line hidden
            BeginContext(1965, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1997, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9ca3275d90406bbddc6d2d9b454c6a", async() => {
                BeginContext(2025, 9, false);
#line 49 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 49 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(2126, 157, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"size\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(2283, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67f7e49309a44d018691f7bd7d2b739c", async() => {
                BeginContext(2300, 11, true);
                WriteLiteral("--可根据尺码搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                      
                        if (Model.sizeCodeList != null)
                        {
                            foreach (var item in Model.sizeCodeList)
                            {

#line default
#line hidden
            BeginContext(2531, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2563, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adec83d5f50f46f3a6ae602116dd9c82", async() => {
                BeginContext(2591, 9, false);
#line 63 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 63 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2609, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Inventory.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(2692, 4414, true);
            WriteLiteral(@"                </select>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'laydate', 'form'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form,
                    objOrder = { field: 'totalStock', type:'desc'};
                form.render('select');
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , format: 'yyyy/MM/dd'
                    , range: true
");
            WriteLiteral(@"                });
                table.render({
                    toolbar:true,
                    elem: '#tablist',
                    loading: true,
                    url: '/api/inventory/stock',
                    totalRow: true,
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left', totalRowText: '合计行' },
                            { field: 'code',width:200, title: '条形码', sort: true, fixed: 'left' },
                            { field: 'totalStock', title: '总入库数', sort: true, totalRow: true },
                            { field: 'stock', title: '剩余库存', sort: true, totalRow: true },
                            { field: 'outStock', title: '出库数', sort: true, totalRow: true },
                            { field: 'transfer', title: '调拨', sort: true, totalRow: true },
                            { field: 'return', title: '返货', sort: true, totalRow: true },
                            { field: 'back', title: '退货', sort: t");
            WriteLiteral(@"rue, totalRow: true },
                            { field: 'sale', title: '销售数', sort: true, totalRow: true },
                            { field: 'loss', title: '报损数', sort: true, totalRow: true }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 15,
                    id: 'tables'
                });

                table.on('sort(tool)', function (obj) { 
                    var e = layer.load(2, { shade: [.05, '#000']});
                    table.reload('tables', {
                        initSort: obj,
                        page: {
                            curr: 1
                        },
                        where: {
                            field: obj.field,
                            order: obj.type
                        },
                        done: function () {
                            layer.close(e);
                        }
      ");
            WriteLiteral(@"              });
                });

                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    time: $(""#times"").val(),
                                    guid: $(""#branks"").val(),
                                    size: $('#size').val(),
                                    year: $('#years').val(),
                                    season: $('#seasons').val(),
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolExport: function () {
                        os.s");
            WriteLiteral(@"uccess('正在开发中');
                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });  
            });
    </script>
</div>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.InventoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.InventoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.InventoryModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.InventoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
