#pragma checksum "D:\Projets\Git\Nadine\Pages\Samples\CompleteSamplePage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7471676acc125c7615942f09bcc5a91011134d6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nadine.Pages.Samples.Pages_Samples_CompleteSamplePage1), @"mvc.1.0.razor-page", @"/Pages/Samples/CompleteSamplePage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Samples/CompleteSamplePage1.cshtml", typeof(Nadine.Pages.Samples.Pages_Samples_CompleteSamplePage1), null)]
namespace Nadine.Pages.Samples
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projets\Git\Nadine\Pages\_ViewImports.cshtml"
using Nadine;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7471676acc125c7615942f09bcc5a91011134d6d", @"/Pages/Samples/CompleteSamplePage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63cfc3360697a570ac9a3a36eadaff49d6bcabf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Samples_CompleteSamplePage1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10, 50, false);
#line 3 "D:\Projets\Git\Nadine\Pages\Samples\CompleteSamplePage1.cshtml"
Write(await Html.PartialAsync("Samples/CompleteSample1"));

#line default
#line hidden
            EndContext();
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Samples_CompleteSamplePage1> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Samples_CompleteSamplePage1> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Samples_CompleteSamplePage1>)PageContext?.ViewData;
        public Pages_Samples_CompleteSamplePage1 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
