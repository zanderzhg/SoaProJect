#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c2ed2007f1bede49b616430bea10ddf1d1be83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Transfer), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/Transfer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/Transfer.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Transfer), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c2ed2007f1bede49b616430bea10ddf1d1be83", @"/Pages/FytAdmin/Stock/Transfer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_Transfer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml"
  
    ViewData["Title"] = "调拨管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(146, 852, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增调拨单</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除调拨单</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolExport""><i class=""layui-icon layui-icon-component""></i> 导出Excel</button>
        </div>
        <div class=""layui-form list-search"" style=""margin-top:10px;"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline"">
                <select id=""shopGuid"">
                    ");
            EndContext();
            BeginContext(998, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5861518fa34444c390883250e1c8994d", async() => {
                BeginContext(1015, 11, true);
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
            BeginContext(1035, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml"
                      
                        foreach (var item in Model.List)
                        {

#line default
#line hidden
            BeginContext(1146, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1174, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0f8616009c4f309d04c62f84a57471", async() => {
                BeginContext(1202, 13, false);
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml"
                                                  Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml"
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
            BeginContext(1224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Transfer.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1276, 8603, true);
            WriteLiteral(@"                </select>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""goodsAdd""><i class=""layui-icon""></i> 添加调拨商品</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""goodsDel""><i class=""layui-icon""></i> 删除调拨商品</button>
        </div>
        <table class=""layui-hide"" id=""table-goods"" lay-filter=""acttool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquer");
            WriteLiteral(@"y,
                    os = layui.common,
                    form = layui.form;
                table.render({
                    elem: '#tablist',
                    url: '/api/stock/transferlist',
                    height: 400,
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'number', title: '编号', sort: true, fixed: 'left', event: 'gotool' },
                            { field: 'inShopName', title: '入库加盟商', event: 'gotool' },
                            { field: 'outShopName', title: '出库加盟商', event: 'gotool' },
                            { field: 'goodsSum', title: '数量', sort: true, event: 'gotool' },
                            { field: 'addDate', title: '添加时间', event: 'gotool' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    limit: 1000,
        ");
            WriteLiteral(@"            id: 'tables'
                });

                //调拨商品
                table.render({
                    elem: '#table-goods',
                    url: '/api/stock/transfergoodslist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', title: '条形码' },
                            { field: 'brankName',  title: '品牌' },
                            { field: 'styleName', title: '款式'},
                            { field: 'goodsSum', title: '数量', sort: true }
                        ]
                    ],
                    page: true,
                    limit: 10,
                    id: 'tabgoods'
                });

               

                var transferGuid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                  ");
            WriteLiteral(@"                  curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    guid: $(""#shopGuid"").val()
                                }
                            });
                    },
                    //点击店铺查询活动和店铺会员
                    reloadGoods: function () {
                        table.reload('tabgoods',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    guid: transferGuid
                                }
                            });                        
                    },
                    //调拨单搜索
                    toolSearch: function () {
                        active.reload();
                    },                    
                    //添加调拨单
           ");
            WriteLiteral(@"         toolAdd: function () {
                        os.Open('添加调拨单', '/fytadmin/stock/transfermodify', '600px', '450px', function () {
                            active.reload();
                        });
                    },
                    //删除调拨单
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']");
            WriteLiteral(@"
                            });
                            os.ajax('api/stock/deltransfer/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    //调拨商品添加
                    goodsAdd: function () {
                        if (transferGuid === '') {
                            os.error('请选择调拨单~');
                            return;
                        }
                        os.Open('添加商品', '/fytadmin/stock/transfergoods/?transferGuid=' + transferGuid, '950px', '650px', function () {
                            active.reloadGoods();
           ");
            WriteLiteral(@"             });
                    },
                    //删除调拨商品
                    goodsDel: function () {
                        var checkStatus = table.checkStatus('tabgoods')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/deltransfergoods/', { parm: str }, function (res) {
                                layer.close(loadindex);
  ");
            WriteLiteral(@"                              if (res.statusCode === 200) {
                                    active.reloadGoods();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });

                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑调拨单', '/fytadmin/stock/transfermodify/?guid='+data.guid, '600px', '450px', function () {
                            active.reload();
                        });
                ");
            WriteLiteral(@"    }
                    if (obj.event === 'gotool') {
                        transferGuid = data.guid;
                        active.reloadGoods();
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.TransferModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.TransferModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.TransferModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.TransferModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
