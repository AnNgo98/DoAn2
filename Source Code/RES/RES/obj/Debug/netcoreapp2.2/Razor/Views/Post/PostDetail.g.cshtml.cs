#pragma checksum "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26fd55392136998bcbcf8a6b12d8c4d576a3ea88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostDetail), @"mvc.1.0.view", @"/Views/Post/PostDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/PostDetail.cshtml", typeof(AspNetCore.Views_Post_PostDetail))]
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
#line 1 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\_ViewImports.cshtml"
using RES;

#line default
#line hidden
#line 2 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\_ViewImports.cshtml"
using RES.Models;

#line default
#line hidden
#line 1 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
using RES.Data.DBModels;

#line default
#line hidden
#line 2 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
using RES.Models.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fd55392136998bcbcf8a6b12d8c4d576a3ea88", @"/Views/Post/PostDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a590fce6fc06d2f224b7f8179158f4c5564dfb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
  
    ViewData["Title"] = "Chi tiết | Bất động sản Miền Trung";
    RealEstateSystemContext db = new RealEstateSystemContext();

#line default
#line hidden
            BeginContext(200, 157, true);
            WriteLiteral("\r\n<!-- Page top section -->\r\n<section class=\"page-top-section set-bg\" data-setbg=\"img/page-top-bg.jpg\">\r\n    <div class=\"container text-white\">\r\n        <h2>");
            EndContext();
            BeginContext(358, 22, false);
#line 12 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
       Write(Model.Tittle.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(380, 146, true);
            WriteLiteral("</h2>\r\n    </div>\r\n</section>\r\n<!--  Page top end -->\r\n<!-- Breadcrumb -->\r\n<div class=\"site-breadcrumb\">\r\n    <div class=\"container\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 526, "\"", 561, 1);
#line 19 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
WriteAttributeValue("", 533, Url.Action("Index", "Home"), 533, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 368, true);
            WriteLiteral(@"><i class=""fa fa-home""></i>Home</a>
        <span><i class=""fa fa-angle-right""></i>Chi tiết Bài đăng</span>
    </div>
</div>

<!-- Page -->
<section class=""page-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 single-list-page"">
                <div class=""single-list-slider owl-carousel"" id=""sl-slider"">

");
            EndContext();
#line 31 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                       List<PostImage> lstImage = db.PostImage.Where(n => n.PostId == Model.PostId).ToList();

#line default
#line hidden
            BeginContext(1042, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                     if (Model.PostType == 1)
                    {
                        foreach (var image in lstImage)
                        {

#line default
#line hidden
            BeginContext(1198, 68, true);
            WriteLiteral("                            <div class=\"sl-item set-bg\" data-setbg=\"");
            EndContext();
            BeginContext(1268, 34, false);
#line 37 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                                Write(Constants.POST_IMG_URL + image.Url);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 111, true);
            WriteLiteral("\">\r\n                                <div class=\"sale-notic\">Cần bán</div>\r\n                            </div>\r\n");
            EndContext();
#line 40 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                        }
                    }
                    else
                    {
                        foreach (var image in lstImage)
                        {

#line default
#line hidden
            BeginContext(1597, 68, true);
            WriteLiteral("                            <div class=\"sl-item set-bg\" data-setbg=\"");
            EndContext();
            BeginContext(1667, 34, false);
#line 46 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                                Write(Constants.POST_IMG_URL + image.Url);

#line default
#line hidden
            EndContext();
            BeginContext(1702, 116, true);
            WriteLiteral("\">\r\n                                <div class=\"rent-notic\">Cần cho thuê</div>\r\n                            </div>\r\n");
            EndContext();
#line 49 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1868, 105, true);
            WriteLiteral("                </div>\r\n                <div class=\"owl-carousel sl-thumb-slider\" id=\"sl-slider-thumb\">\r\n");
            EndContext();
#line 53 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                     foreach (var image in lstImage)
                    {

#line default
#line hidden
            BeginContext(2050, 65, true);
            WriteLiteral("                        <div class=\"sl-thumb set-bg\" data-setbg=\"");
            EndContext();
            BeginContext(2117, 34, false);
#line 55 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                             Write(Constants.POST_IMG_URL + image.Url);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 10, true);
            WriteLiteral("\"></div>\r\n");
            EndContext();
#line 56 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                    }

#line default
#line hidden
            BeginContext(2185, 203, true);
            WriteLiteral("                </div>\r\n                <div class=\"single-list-content\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xl-8 sl-title\">\r\n                            <h2>");
            EndContext();
            BeginContext(2389, 47, false);
#line 61 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                           Write(CommonFunction.getDetailAddress(Model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 70, true);
            WriteLiteral("</h2>\r\n                            <p><i class=\"fa fa-map-marker\"></i>");
            EndContext();
            BeginContext(2507, 41, false);
#line 62 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                          Write(CommonFunction.getAddress(Model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 86, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-xl-4\">\r\n");
            EndContext();
#line 65 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                             if (Model.PostType == 1)
                            {

#line default
#line hidden
            BeginContext(2720, 62, true);
            WriteLiteral("                                <a href=\"#\" class=\"price-btn\">");
            EndContext();
            BeginContext(2783, 41, false);
#line 67 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                         Write(string.Format("{0:0,0 VND}", Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2824, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 68 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2926, 62, true);
            WriteLiteral("                                <a href=\"#\" class=\"price-btn\">");
            EndContext();
            BeginContext(2989, 49, false);
#line 71 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                         Write(string.Format("{0:0,0 VND / tháng}", Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 72 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3075, 188, true);
            WriteLiteral("                        </div>\r\n\r\n                        <div class=\"col-xl-12 mb-5\">\r\n                            <div class=\"fb-like\" data-href=\"http://realestate-ute.azurewebsites.net/");
            EndContext();
            BeginContext(3264, 12, false);
#line 76 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                                                               Write(Model.PostId);

#line default
#line hidden
            EndContext();
            BeginContext(3276, 185, true);
            WriteLiteral("\" data-width=\"\" data-layout=\"standard\" data-action=\"like\" data-size=\"small\" data-show-faces=\"true\" data-share=\"true\"></div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 79 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                     if (Model.Detail != null)
                    {

#line default
#line hidden
            BeginContext(3532, 271, true);
            WriteLiteral(@"                        <h3 class=""sl-sp-title"">Thông tin chi tiết</h3>
                        <div class=""row property-details-list"">
                            <div class=""col-md-4 col-sm-6"">
                                <p><i class=""fa fa-th-large""></i> Hướng ");
            EndContext();
            BeginContext(3804, 116, false);
#line 84 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                                   Write(db.Direction.First(n => n.DirectionId == db.Detail.First(c => c.DetailId == Model.Detail).DirectionId).DirectionName);

#line default
#line hidden
            EndContext();
            BeginContext(3920, 67, true);
            WriteLiteral("</p>\r\n                                <p><i class=\"fa fa-bed\"></i> ");
            EndContext();
            BeginContext(3988, 56, false);
#line 85 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                        Write(db.Detail.First(c => c.DetailId == Model.Detail).Bedroom);

#line default
#line hidden
            EndContext();
            BeginContext(4044, 78, true);
            WriteLiteral(" phòng ngủ</p>\r\n                                <p><i class=\"fa fa-user\"></i> ");
            EndContext();
            BeginContext(4124, 136, false);
#line 86 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                          Write(db.Customer.First(c => c.CustomerId == Model.AuthorId).LastName + " " + db.Customer.First(c => c.CustomerId == Model.AuthorId).Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(4261, 164, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-md-4 col-sm-6\">\r\n                                <p><i class=\"fa fa-car\"></i> ");
            EndContext();
            BeginContext(4427, 94, false);
#line 89 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                         Write(db.Detail.First(c => c.DetailId == Model.Detail).Alley == true ? "Trong hẻm" : "Mặt đường lớn");

#line default
#line hidden
            EndContext();
            BeginContext(4522, 74, true);
            WriteLiteral("</p>\r\n                                <p><i class=\"fa fa-building-o\"></i> ");
            EndContext();
            BeginContext(4597, 54, false);
#line 90 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                               Write(db.Detail.First(c => c.DetailId == Model.Detail).Floor);

#line default
#line hidden
            EndContext();
            BeginContext(4651, 75, true);
            WriteLiteral(" lầu</p>\r\n                                <p><i class=\"fa fa-clock-o\"></i> ");
            EndContext();
            BeginContext(4727, 44, false);
#line 91 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                            Write(CommonFunction.GetTimeOfPost(Model.PostTime));

#line default
#line hidden
            EndContext();
            BeginContext(4771, 156, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <p><i class=\"fa fa-bath\"></i> ");
            EndContext();
            BeginContext(4928, 57, false);
#line 94 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                         Write(db.Detail.First(c => c.DetailId == Model.Detail).Bathroom);

#line default
#line hidden
            EndContext();
            BeginContext(4985, 80, true);
            WriteLiteral(" phòng tắm</p>\r\n                                <p><i class=\"fa fa-trophy\"></i> ");
            EndContext();
            BeginContext(5067, 48, false);
#line 95 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                            Write(Model.PostType == 1 ? "Nhà bán" : "Nhà cho thuê");

#line default
#line hidden
            EndContext();
            BeginContext(5116, 74, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 98 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5262, 267, true);
            WriteLiteral(@"                        <h3 class=""sl-sp-title"">Thông tin chi tiết</h3>
                        <div class=""row property-details-list"">
                            <div class=""col-md-6 col-sm-6"">
                                <p><i class=""fa fa-building-o""></i> ");
            EndContext();
            BeginContext(5530, 77, false);
#line 104 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                               Write(db.RealEstateType.First(n => n.RealEstateTypeId == Model.RealEstaleType).Name);

#line default
#line hidden
            EndContext();
            BeginContext(5607, 68, true);
            WriteLiteral("</p>\r\n                                <p><i class=\"fa fa-user\"></i> ");
            EndContext();
            BeginContext(5677, 136, false);
#line 105 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                          Write(db.Customer.First(c => c.CustomerId == Model.AuthorId).LastName + " " + db.Customer.First(c => c.CustomerId == Model.AuthorId).Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(5814, 168, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-md-6 col-sm-6\">\r\n                                <p><i class=\"fa fa-th-large\"></i>");
            EndContext();
            BeginContext(5983, 10, false);
#line 108 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                            Write(Model.Area);

#line default
#line hidden
            EndContext();
            BeginContext(5993, 79, true);
            WriteLiteral(" m&sup2;</p>\r\n                                <p><i class=\"fa fa-clock-o\"></i> ");
            EndContext();
            BeginContext(6073, 44, false);
#line 109 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                            Write(CommonFunction.GetTimeOfPost(Model.PostTime));

#line default
#line hidden
            EndContext();
            BeginContext(6117, 74, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 112 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                    }

#line default
#line hidden
            BeginContext(6214, 130, true);
            WriteLiteral("                    <h3 class=\"sl-sp-title\">Mô tả</h3>\r\n                    <div class=\"description\">\r\n                        <p>");
            EndContext();
            BeginContext(6345, 17, false);
#line 115 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(6362, 313, true);
            WriteLiteral(@"</p>
                    </div>

                    <h3 class=""sl-sp-title bd-no"">Location</h3>
                    <div id=""map""></div>
                </div>
            </div>
            <!-- sidebar -->
            <div class=""col-lg-4 col-md-7 sidebar"">
                <div class=""author-card"">
");
            EndContext();
#line 125 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                       string imgName = Model.Author.AvatarUrl; 

#line default
#line hidden
            BeginContext(6742, 63, true);
            WriteLiteral("                    <div class=\"author-img set-bg\" data-setbg=\"");
            EndContext();
            BeginContext(6807, 30, false);
#line 126 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                           Write(Constants.AVATAR_URL + imgName);

#line default
#line hidden
            EndContext();
            BeginContext(6838, 85, true);
            WriteLiteral("\"></div>\r\n                    <div class=\"author-info\">\r\n                        <h5>");
            EndContext();
            BeginContext(6925, 52, false);
#line 128 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                        Write(Model.Author.LastName + " " + Model.Author.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(6978, 190, true);
            WriteLiteral("</h5>\r\n                        <p>Real Estate Agent</p>\r\n                    </div>\r\n                    <div class=\"author-contact\">\r\n                        <p><i class=\"fa fa-phone\"></i> ");
            EndContext();
            BeginContext(7170, 59, false);
#line 132 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                   Write(String.Format("{0:0### ### ###}", Model.Author.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(7230, 63, true);
            WriteLiteral("</p>\r\n                        <p><i class=\"fa fa-envelope\"></i>");
            EndContext();
            BeginContext(7294, 18, false);
#line 133 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                    Write(Model.Author.Email);

#line default
#line hidden
            EndContext();
            BeginContext(7312, 266, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-8 single-list-page"">
                <div class=""fb-comments"" data-href=""http://realestate-ute.azurewebsites.net/");
            EndContext();
            BeginContext(7579, 12, false);
#line 140 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                                                       Write(Model.PostId);

#line default
#line hidden
            EndContext();
            BeginContext(7591, 699, true);
            WriteLiteral(@""" data-width="""" data-numposts=""10""></div>
            </div>
        </div>
    </div>
</section>
<!-- Page end -->
<!-- load for map -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>
<script>


    //$(document).ready(function () {
    //    initAutocomplete();
    //});

    function initAutocomplete() {
        var map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: -33.8688, lng: 151.2195 },
            zoom: 15,
            mapTypeId: 'roadmap'
        });

        var geocoder = new google.maps.Geocoder();

        geocoder.geocode({ 'address': $(""<div>"").html(""");
            EndContext();
            BeginContext(8291, 14, false);
#line 164 "C:\Users\AnNgo\Documents\GitHub\DoAn2\Source Code\RES\RES\Views\Post\PostDetail.cshtml"
                                                  Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(8305, 665, true);
            WriteLiteral(@""").text() }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                map.setCenter(results[0].geometry.location);
                var marker = new google.maps.Marker({
                    map: map,
                    position: results[0].geometry.location
                });
            } else {
                alert('Geocode was not successful for the following reason: ' + status);
            }
        });
    }


</script>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAV6dcVxUDSUS_09lE9FzTv6qilBs32qOA&libraries=places&callback=initAutocomplete""
        async defer></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
