#pragma checksum "C:\Users\15144\Documents\john-abbott-2\15-asp.NET\ASP.NET\MyFriends\Pages\AddSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13117fce1528b4458ade7bf38575f0fbae53457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyFriends.Pages.Pages_AddSuccess), @"mvc.1.0.razor-page", @"/Pages/AddSuccess.cshtml")]
namespace MyFriends.Pages
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
#line 1 "C:\Users\15144\Documents\john-abbott-2\15-asp.NET\ASP.NET\MyFriends\Pages\_ViewImports.cshtml"
using MyFriends;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13117fce1528b4458ade7bf38575f0fbae53457", @"/Pages/AddSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7cb306c07409643e4159d4073d5b9b36fd0c188", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <ol id=""orderProcess"">
    <li><span class=""step-number"">1</span>Choose Item</li>
    <li><span class=""step-number"">2</span>Details &amp; Submit</li>
    <li class=""current""><span class=""step-number"">3</span>Receipt</li>
</ol>
<h1>Friend Added Confirmation</h1>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFriends.Pages.AddSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyFriends.Pages.AddSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyFriends.Pages.AddSuccessModel>)PageContext?.ViewData;
        public MyFriends.Pages.AddSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591