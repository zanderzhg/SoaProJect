#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40dec2f659a725521d172e4962e53d5ae81dabf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin__LayoutMain), @"mvc.1.0.view", @"/Pages/FytAdmin/_LayoutMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/FytAdmin/_LayoutMain.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin__LayoutMain))]
namespace FytSoa.Web.Pages.FytAdmin
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
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40dec2f659a725521d172e4962e53d5ae81dabf", @"/Pages/FytAdmin/_LayoutMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin__LayoutMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/nprogress.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/nprogress.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(59, 592, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4786dcef4ec94865abac1f0c6a499692", async() => {
                BeginContext(65, 169, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    ");
                EndContext();
                BeginContext(234, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48a525971f9d4c84ac58c834150f6977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fafa54d9f3f488a8a87df6327dc9e90", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(353, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(359, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0e33ad52a1c44a49a1a7b0cd3907ad5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(418, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(424, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac0c47f8027f41c683c8243fc3db7ded", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(475, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(481, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20134d2c5e344fda58fb173ccdb90c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(554, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(560, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae7c6aeaf6ab4c4bb4a39ceef5581d03", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(607, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(621, 13, false);
#line 15 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(634, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(651, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(653, 7873, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6737a0408c45ceb9b90353edd06cc6", async() => {
                BeginContext(659, 248, true);
                WriteLiteral("\r\n    <div class=\"layui-layout layui-layout-admin\">\r\n        <div class=\"layui-header\">\r\n            <div class=\"layui-logo\">FytErp-SaaS平台</div>\r\n            <ul class=\"layui-nav layui-layout-left\">\r\n                <li class=\"layui-nav-item pr50\">");
                EndContext();
                BeginContext(907, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d067c492ee44b01987edcd76967304c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(959, 552, true);
                WriteLiteral(@"</li>
            </ul>
            <ul class=""layui-nav layui-layout-right"">
                <li class=""layui-nav-item"">
                    <a data-pjax href=""/fytadmin/default""><i class=""layui-icon""></i></a>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""/demo/""><i class=""layui-icon""></i><span class=""layui-badge-dot""></span></a>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">
                        <span class=""username"">");
                EndContext();
                BeginContext(1512, 78, false);
#line 33 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
                                          Write(User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Name).Value);

#line default
#line hidden
                EndContext();
                BeginContext(1590, 65, true);
                WriteLiteral(" <i class=\"layui-icon\"></i></span>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1655, "\"", 1746, 1);
#line 34 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
WriteAttributeValue("", 1661, User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Thumbprint).Value, 1661, 85, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1747, 5336, true);
                WriteLiteral(@" class=""layui-nav-img"">
                    </a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax href=""/fytadmin/sys/admin/"">个人中心</a></dd>
                        <hr />
                        <dd><a href=""/fytadmin/logout/"">退出登录</a></dd>
                    </dl>
                </li>
            </ul>
        </div>

        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                <ul class=""layui-nav layui-nav-tree fyt-nav-tree"" lay-filter=""test"">
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>系统管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/sys/organize/"">部门管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/role/"">角色管理</a></dd>
                            <dd><a data-pjax ");
                WriteLiteral(@"href=""/fytadmin/sys/admin/"">用户管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/menu/"">菜单管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/log/"">系统日志</a></dd>
                            <dd><a data-pjax href=""/fytadmin/sys/codes/"">字典管理</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>采购管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/test/"">未完成入库</a></dd>
                            <dd><a href=""javascript:;"">已完成付款</a></dd>
                            <dd><a href=""javascript:;"">未完成到票</a></dd>
                            <dd><a href=""javascript:;"">全部采购</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i clas");
                WriteLiteral(@"s=""layui-icon""></i>加盟商管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/shop/index/"">加盟商列表</a></dd>
                            <dd><a data-pjax href=""/fytadmin/shop/staffindex/"">店员管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/shop/push/"">消息通知</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a class="""" href=""javascript:;""><i class=""layui-icon""></i>库存管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a data-pjax href=""/fytadmin/goods/barcode/"">条形码管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/import/"">入库管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/export/"">出库管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/transfer/"">调拨管理</a></dd>
                            <dd><a data-pjax ");
                WriteLiteral(@"href=""/fytadmin/goods/index/"">商品管理</a></dd>
                            <dd><a data-pjax href=""/fytadmin/stock/inventory/"">库存盘点</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>财务管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">总账</a></dd>
                            <dd><a href=""javascript:;"">应收应付</a></dd>
                            <dd><a href="""">付款核销</a></dd>
                            <dd><a href="""">报表中心</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>会员管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">会员列表</a></dd>
                            <dd><a href=""javascript:;"">会员积分</a></dd>
 ");
                WriteLiteral(@"                           <dd><a href="""">消费日志</a></dd>
                            <dd><a href="""">生日祝福</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>销售管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">销售明细</a></dd>
                            <dd><a href=""javascript:;"">退货管理</a></dd>
                            <dd><a href="""">返货管理</a></dd>
                            <dd><a href="""">折扣管理</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;""><i class=""layui-icon""></i>报表管理</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">采购报表</a></dd>
                            <dd><a href=""javascript:;"">出入库报表</a></dd>
                      ");
                WriteLiteral("      <dd><a href=\"\">销售报表</a></dd>\r\n                        </dl>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"layui-body\" id=\"container\">\r\n            ");
                EndContext();
                BeginContext(7084, 12, false);
#line 128 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7096, 34, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(7130, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fe8714f7f644240ad23f4735e773472", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7203, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7209, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17cb3e52b7864dfd95a8dbc0f648cb47", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7279, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7285, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beef7174de804ee19c4812e93ecf9119", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7356, 1119, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['element', 'layer', 'jquery', 'common', 'pjax'], function () {
            var os = layui.common
                , element = layui.element
                , $ = layui.$;
            $(document).pjax('a', '#container',
                {
                    fragment: ""#container"",
                    cache: false,
                    show: 'fade'
                }
            );
            //定位到菜单
            $("".layui-bg-black .fyt-nav-tree li a"").each(function () { 
                if (window.location.pathname === $(this).attr('href')) {
                    $("".layui-bg-black .fyt-nav-tree li"").removeClass('layui-nav-itemed');
                    $(this).parents('.layui-nav-item').addClass('layui-nav-itemed');
                    $(this).parent().addClass('layui-this');
                }
            });
            $(document).on('pjax:start', function () { NProgress.start(); });
            $");
                WriteLiteral("(document).on(\'pjax:end\', function () { NProgress.done(); });\r\n        });\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(8476, 41, false);
#line 160 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\_LayoutMain.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(8517, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8526, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
