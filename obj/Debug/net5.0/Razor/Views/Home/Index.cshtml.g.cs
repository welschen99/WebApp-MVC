#pragma checksum "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421c1b192667c179a61be1659ed18f05b23b1d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\_ViewImports.cshtml"
using WebAppPRODUCTOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\_ViewImports.cshtml"
using WebAppPRODUCTOS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421c1b192667c179a61be1659ed18f05b23b1d18", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8c85efb004b1853b42d9e49e138531f9bace31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebAppPRODUCTOS.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class="" jumbotron text-center bg-dark text-white"" style=""padding: 2%; background: rgb(2,0,36); background: linear-gradient(184deg, rgba(2,0,36,1) 22%, rgba(9,9,121,1) 52%, rgba(0,212,255,1) 97%); "">
    <h3 class=""display-2"">Productos</h3>

</div>

<div class=""row jumbotron"">
    <div class=""col-md-6"" style=""margin: auto;"">
        <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"" style=""max-width: 60%; background-color: black; padding: 7%; margin: auto; justify-content: center; align-items: center;"">
            <ol class=""carousel-indicators"">
");
#nullable restore
#line 16 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleControls\" data-slide-to=\"i\" class=\"active\"></li>\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleControls\" data-slide-to=\"");
#nullable restore
#line 24 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n            <div class=\"carousel-inner d\" style=\" margin-left: auto; margin-right: auto; display: block;\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                  
                    var first = true;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1434, "\"", 1496, 2);
            WriteAttributeValue("", 1442, "carousel-item", 1442, 13, true);
#nullable restore
#line 36 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1455, first?Html.Raw("active"):Html.Raw(""), 1456, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1596, 1);
#nullable restore
#line 37 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
WriteAttributeValue("", 1533, Url.ActionLink("Details", "ProductosOK", new { id = item.Id }), 1533, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "421c1b192667c179a61be1659ed18f05b23b1d187179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 38 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                                   WriteLiteral(item.imagen);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                    first = false;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button""
               data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button""
               data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <br />
    <div class=""col-md-6"" style=""margin: auto;"">
        <div class=""bg-warning text-center"" style=""padding:3%"">
            <h2>Productos Favoritos de los usuarios</h2>
        </div>
        <br />
        <div class=""bg-dark text-justify text-white"" style=""padding:3%"">
            <h5 class=""text-white-50"" style=""padding:3%""><em>Al hacer click en la imagen del producto te brinda mayor d");
            WriteLiteral("etalles</em></h5>\r\n");
#nullable restore
#line 65 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-center \"><strong> ");
#nullable restore
#line 67 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                                    Write(item.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </strong> a un m??dico precio de $ <strong>");
#nullable restore
#line 67 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
                                                                                             Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></p>\r\n");
#nullable restore
#line 68 "C:\Users\User\Desktop\WebAppPRODUCTOS\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<img class=\"img-fluid align-content-sm-center card-img h-25\" style=\"margin: auto; padding\" src=\"/propaganda/propaganda 2.jpg\" alt=\"propaganda\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebAppPRODUCTOS.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
