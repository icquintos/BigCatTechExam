#pragma checksum "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d8e9e08ac5b6a2d95e5be17f477e15abf000db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Checkout.cshtml", typeof(AspNetCore.Views_Home_Checkout))]
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
#line 1 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\_ViewImports.cshtml"
using BigCatTechExam.Web;

#line default
#line hidden
#line 2 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\_ViewImports.cshtml"
using BigCatTechExam.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d8e9e08ac5b6a2d95e5be17f477e15abf000db", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d664e79a569daf0c12d94e9f1e98ea1490e6fc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BikeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    ViewData["IsAuthenticated"] = "true";

#line default
#line hidden
            BeginContext(112, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(117, 17, false);
#line 7 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(134, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
 using (Html.BeginForm("Checkout", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(215, 30, false);
#line 12 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
Write(Html.HiddenFor(m => m.Bike.id));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
                                   
    //@Html.TextBoxFor(m => m.Bike.CustomerName, new { @class = "form-control"})

#line default
#line hidden
            BeginContext(329, 30, true);
            WriteLiteral("    <h2>Customer Name: </h2>\r\n");
            EndContext();
            BeginContext(364, 62, false);
#line 15 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
Write(Html.EditorFor(m => m.Bike.CustomerName, null, "customerName"));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
                                                                   ;


#line default
#line hidden
            BeginContext(431, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 18 "C:\Users\ICQUINTOS\Documents\Visual Studio 2017\Projects\BigCatTechExam.Web\BigCatTechExam.Web\Views\Home\Checkout.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BikeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
