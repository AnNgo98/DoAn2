#pragma checksum "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a797de92da4c619029bffc72fc362b35626c7208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES;

#line default
#line hidden
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES.Models;

#line default
#line hidden
#line 3 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES.Models.Common;

#line default
#line hidden
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
using RES.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a797de92da4c619029bffc72fc362b35626c7208", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdcd4bfcd2d1ebbc40950dcfbe29b8ed6bfd87a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard | Admin BDS Miền Trung";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(182, 648, true);
            WriteLiteral(@"
<link rel=""apple-touch-icon"" href=""apple-icon.png"">
<link rel=""shortcut icon"" href=""favicon.ico"">

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>

<div class=""content mt-3"">

    <div class=""col-sm-12 mb-4"">
        <div class=""card-group"">
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-sign-in""></i>
                    </div>

                    <div class=""h4 mb-0"">
                        <span class=""count"">");
            EndContext();
            BeginContext(831, 16, false);
#line 25 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalGuest);

#line default
#line hidden
            EndContext();
            BeginContext(847, 639, true);
            WriteLiteral(@"</span>
                    </div>

                    <small class=""text-muted text-uppercase font-weight-bold"">Truy cập website</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-1"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-user-plus""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span class=""count"">");
            EndContext();
            BeginContext(1487, 18, false);
#line 38 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalNewUser);

#line default
#line hidden
            EndContext();
            BeginContext(1505, 631, true);
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Người dùng mới</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-2"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-users""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span class=""count"">");
            EndContext();
            BeginContext(2137, 15, false);
#line 50 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalUser);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 581, true);
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Người dùng</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-3"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-meh-o""></i>
                    </div>
                    <div class=""h4 mb-0"">");
            EndContext();
            BeginContext(2734, 22, false);
#line 61 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                    Write(Model.totalBlockedUser);

#line default
#line hidden
            EndContext();
            BeginContext(2756, 608, true);
            WriteLiteral(@"</div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Người dùng bị khóa</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-5"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-th-list""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span class=""count"">");
            EndContext();
            BeginContext(3365, 15, false);
#line 72 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalPost);

#line default
#line hidden
            EndContext();
            BeginContext(3380, 625, true);
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Bài đăng</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-4"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
            <div class=""card col-md-6 no-padding "">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-money""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span class=""count"">");
            EndContext();
            BeginContext(4006, 22, false);
#line 84 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalSellingPost);

#line default
#line hidden
            EndContext();
            BeginContext(4028, 523, true);
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Bài đăng đang bán</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-1"" style=""width: 40%; height: 5px;""></div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-lg-3 col-md-6"">
        <div class=""social-box facebook"">
            <i class=""fa fa-facebook""></i>
            <ul>
                <strong><span class=""count"">");
            EndContext();
            BeginContext(4552, 18, false);
#line 97 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalFBClick);

#line default
#line hidden
            EndContext();
            BeginContext(4570, 297, true);
            WriteLiteral(@"</span></strong>
                <span>lượt ghé thăm</span>
            </ul>
        </div>
    </div>


    <div class=""col-lg-3 col-md-6"">
        <div class=""social-box twitter"">
            <i class=""fa fa-twitter""></i>
            <ul>
                <strong><span class=""count"">");
            EndContext();
            BeginContext(4868, 19, false);
#line 108 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalTwiClick);

#line default
#line hidden
            EndContext();
            BeginContext(4887, 339, true);
            WriteLiteral(@"</span></strong>
                <span>lượt ghé thăm</span>
            </ul>
        </div>
        <!--/social-box-->
    </div><!--/.col-->


    <div class=""col-lg-3 col-md-6"">
        <div class=""social-box linkedin"">
            <i class=""fa fa-linkedin""></i>
            <ul>
                <strong><span class=""count"">");
            EndContext();
            BeginContext(5227, 19, false);
#line 120 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalLinClick);

#line default
#line hidden
            EndContext();
            BeginContext(5246, 343, true);
            WriteLiteral(@"</span></strong>
                <span>lượt ghé thăm</span>
            </ul>
        </div>
        <!--/social-box-->
    </div><!--/.col-->


    <div class=""col-lg-3 col-md-6"">
        <div class=""social-box google-plus"">
            <i class=""fa fa-instagram""></i>
            <ul>
                <strong><span class=""count"">");
            EndContext();
            BeginContext(5590, 19, false);
#line 132 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(Model.totalInsClick);

#line default
#line hidden
            EndContext();
            BeginContext(5609, 452, true);
            WriteLiteral(@"</span></strong>
                <span>lượt ghé thăm</span>
            </ul>
        </div>
        <!--/social-box-->
    </div><!--/.col-->

    <div class=""col-xl-8"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <h4 class=""card-title mb-0"">Biểu đồ thống kê</h4>
                        <div class=""small text-muted"">");
            EndContext();
            BeginContext(6062, 34, false);
#line 145 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                                 Write(DateTime.Now.ToString("MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6096, 1263, true);
            WriteLiteral(@"</div>
                    </div>


                </div><!--/.row-->
                <div class=""chart-wrapper mt-4"">
                    <iframe class=""chartjs-hidden-iframe"" tabindex=""-1"" style=""display: block; overflow: hidden; border: 0px; margin: 0px; top: 0px; left: 0px; bottom: 0px; right: 0px; height: 100%; width: 100%; position: absolute; pointer-events: none; z-index: -1;""></iframe>
                    <canvas id=""trafficChart"" style=""height: 256px; display: block; width: 384px;"" height=""320"" width=""480""></canvas>
                </div>

            </div>
        </div>
    </div>

    <div class=""col-xl-4 col-lg-12"">
        <section class=""card"">
            <div class=""twt-feed blue-bg"">
                <div class=""corner-ribon black-ribon"">
                    <i class=""fa fa-twitter""></i>
                </div>
                <div class=""fa fa-twitter wtt-mark""></div>

                <div class=""media"">
                    <a href=""#"">
                        <img c");
            WriteLiteral("lass=\"align-self-center rounded-circle mr-3\" style=\"width:85px; height:85px;\" alt=\"\" src=\"images/admin.jpg\">\r\n                    </a>\r\n                    <div class=\"media-body\">\r\n                        <h2 class=\"text-white display-6\">");
            EndContext();
            BeginContext(7360, 23, false);
#line 172 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                                                    Write(Model.customer.fullName);

#line default
#line hidden
            EndContext();
            BeginContext(7383, 296, true);
            WriteLiteral(@"</h2>
                        <p class=""text-light"">Real Estate Agent</p>
                    </div>
                </div>
            </div>
            <div class=""weather-category twt-category"">
                <ul>
                    <li class=""active"">
                        <h5>");
            EndContext();
            BeginContext(7680, 25, false);
#line 180 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                       Write(Model.customer.totalPosts);

#line default
#line hidden
            EndContext();
            BeginContext(7705, 122, true);
            WriteLiteral("</h5>\r\n                        Bài đăng\r\n                    </li>\r\n                    <li>\r\n                        <h5>");
            EndContext();
            BeginContext(7828, 29, false);
#line 184 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                       Write(Model.customer.totalSoldPosts);

#line default
#line hidden
            EndContext();
            BeginContext(7857, 129, true);
            WriteLiteral("</h5>\r\n                        Bài đăng đã bán\r\n                    </li>\r\n                    <li>\r\n                        <h5>");
            EndContext();
            BeginContext(7987, 32, false);
#line 188 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                       Write(Model.customer.totalSellingPosts);

#line default
#line hidden
            EndContext();
            BeginContext(8019, 1867, true);
            WriteLiteral(@"</h5>
                        Bài đăng đang bán
                    </li>
                </ul>
            </div>
        </section>
    </div>
</div>

<script src=""assets/js/lib/chart-js/Chart.bundle.js""></script>
<script src=""assets/js/dashboard.js""></script>
<script src=""assets/js/widgets.js""></script>
<script src=""assets/js/lib/vector-map/jquery.vmap.js""></script>
<script src=""assets/js/lib/vector-map/jquery.vmap.min.js""></script>
<script src=""assets/js/lib/vector-map/jquery.vmap.sampledata.js""></script>
<script src=""assets/js/lib/vector-map/country/jquery.vmap.world.js""></script>

<script>
    (function ($) {
        ""use strict"";

        jQuery('#vmap').vectorMap({
            map: 'world_en',
            backgroundColor: null,
            color: '#ffffff',
            hoverOpacity: 0.7,
            selectedColor: '#1de9b6',
            enableZoom: true,
            showTooltip: true,
            values: sample_data,
            scaleColors: ['#1de9b6', '#03a9f5'],
     ");
            WriteLiteral(@"       normalizeFunction: 'polynomial'
        });
    })(jQuery);
    (function ($) {
        ""use strict"";


        // const brandPrimary = '#20a8d8'
        const brandSuccess = '#4dbd74';
        const brandInfo = '#63c2de';
        const brandDanger = '#f86c6b';

        function convertHex(hex, opacity) {
            hex = hex.replace('#', '');
            const r = parseInt(hex.substring(0, 2), 16);
            const g = parseInt(hex.substring(2, 4), 16);
            const b = parseInt(hex.substring(4, 6), 16);

            const result = 'rgba(' + r + ',' + g + ',' + b + ',' + opacity / 100 + ')';
            return result;
        }

        function random(min, max) {
            return Math.floor(Math.random() * (max - min + 1) + min);
        }

        var elements = 27;
        var data1 = ");
            EndContext();
            BeginContext(9887, 49, false);
#line 246 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.chart.lstNewUsers)));

#line default
#line hidden
            EndContext();
            BeginContext(9936, 23, true);
            WriteLiteral(";\r\n        var data2 = ");
            EndContext();
            BeginContext(9960, 49, false);
#line 247 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.chart.lstNewPosts)));

#line default
#line hidden
            EndContext();
            BeginContext(10009, 23, true);
            WriteLiteral(";\r\n        var data3 = ");
            EndContext();
            BeginContext(10033, 53, false);
#line 248 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.chart.lstNewRealPosts)));

#line default
#line hidden
            EndContext();
            BeginContext(10086, 60, true);
            WriteLiteral(";\r\n        var labels = [];\r\n\r\n        for (var i = 1; i <= ");
            EndContext();
            BeginContext(10147, 27, false);
#line 251 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Home\Index.cshtml"
                        Write(Model.chart.totalDayOfMonth);

#line default
#line hidden
            EndContext();
            BeginContext(10174, 2532, true);
            WriteLiteral(@"; i++) {
            labels.push(i);
        }


        //Traffic Chart
        var ctx = document.getElementById(""trafficChart"");
        ctx.height = 200;
        var myChart = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [
                    {
                        label: 'Người dùng mới',
                        backgroundColor: 'transparent',
                        borderColor: brandDanger,
                        pointHoverBackgroundColor: '#fff',
                        borderWidth: 2,
                        data: data1
                    },
                    {
                        label: 'Bài đăng mới',
                        backgroundColor: convertHex(brandInfo, 10),
                        borderColor: brandSuccess,
                        pointHoverBackgroundColor: '#fff',
                        borderWidth: 2,
                        data: data2
                    },
           ");
            WriteLiteral(@"         {
                        label: 'Bài đăng thực',
                        backgroundColor: 'transparent',
                        borderColor: brandInfo,
                        pointHoverBackgroundColor: 'red',
                        borderWidth: 2,
                        data: data3
                    }
                ]
            },
            options: {
                maintainAspectRatio: true,
                legend: {
                    display: false
                },
                responsive: true,
                scales: {
                    xAxes: [{
                        gridLines: {
                            drawOnChartArea: false
                        }
                    }],
                    yAxes: [{
                        ticks: {
                            beginAtZero: true,
                            maxTicksLimit: 5,
                            stepSize: Math.ceil(10 / 5),
                            max: 10
                     ");
            WriteLiteral(@"   },
                        gridLines: {
                            display: true
                        }
                    }]
                },
                elements: {
                    point: {
                        radius: 0,
                        hitRadius: 10,
                        hoverRadius: 4,
                        hoverBorderWidth: 3
                    }
                }


            }
        });


    })(jQuery);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
