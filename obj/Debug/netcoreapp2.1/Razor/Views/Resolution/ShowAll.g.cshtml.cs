#pragma checksum "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907ad2f783cec7103b6562f64cc174f222ff3813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resolution_ShowAll), @"mvc.1.0.view", @"/Views/Resolution/ShowAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Resolution/ShowAll.cshtml", typeof(AspNetCore.Views_Resolution_ShowAll))]
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
#line 1 "C:\Users\TBOREK\Desktop\ASP\Views\_ViewImports.cshtml"
using ASP;

#line default
#line hidden
#line 2 "C:\Users\TBOREK\Desktop\ASP\Views\_ViewImports.cshtml"
using ASP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907ad2f783cec7103b6562f64cc174f222ff3813", @"/Views/Resolution/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1380f5418ca4a9a4a07dd423700cc0ce146df93", @"/Views/_ViewImports.cshtml")]
    public class Views_Resolution_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Resolution>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resolution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddResolution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-resolution-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pdg-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 43, true);
            WriteLiteral("\r\n<div class=\"repository-navigation\">\r\n    ");
            EndContext();
            BeginContext(75, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9063bd0cc034ed080221cddfa6254cf", async() => {
                BeginContext(160, 23, true);
                WriteLiteral("Nowa uchwała? Dodaj ją!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 693, true);
            WriteLiteral(@"
</div>


<table id=""resolution-table"">
	<tr id=""table-headers"">
		<th class=""table-header"">Nazwa uchwały</th>
		<th class=""table-header"">Opis uchwały</th>
		<th class=""table-header"">Data</th>
		<th>Plik</th>
	</tr>
	<tr class=""inputs-row"">
		<td class=""search-column""><input type=""text"" placeholder=""szukaj po nazwie..."" onkeyup=""nameSearch()"" id=""name-input"" /></td>
		<td class=""search-column""><input type=""text"" placeholder=""szukaj po opisie..."" onkeyup=""descriptionSearch()"" id=""description-input""/></td>
		<td class=""search-column""><input type=""text"" placeholder=""szukaj po dacie..."" onkeyup=""dateSearch()"" id=""date-input"" /></td>
		<td class=""data-column""></td>
	</tr>
");
            EndContext();
#line 21 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
     foreach (var item in Model)
    {
    var filePath = item.ResolutionFilePath;

#line default
#line hidden
            BeginContext(963, 59, true);
            WriteLiteral("    <tr class=\"data-row\">\r\n        <td class=\"data-column\">");
            EndContext();
            BeginContext(1023, 39, false);
#line 25 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 39, true);
            WriteLiteral("</td>\r\n        <td class=\"data-column\">");
            EndContext();
            BeginContext(1102, 46, false);
#line 26 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 51, true);
            WriteLiteral("</td>\r\n        <td class=\"data-column date-column\">");
            EndContext();
            BeginContext(1200, 49, false);
#line 27 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DateOfAdopting));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1282, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0587d366fd054cb79cd3aa0b43d23a85", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1343, 34, true);
            WriteLiteral("\r\n            <br>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1377, "\"", 1393, 1);
#line 31 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
WriteAttributeValue("", 1384, filePath, 1384, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1394, 45, true);
            WriteLiteral(">Plik uchwały</a>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\TBOREK\Desktop\ASP\Views\Resolution\ShowAll.cshtml"
    }

#line default
#line hidden
            BeginContext(1446, 232, true);
            WriteLiteral("</table>  \r\n\r\n<script>\r\n    var dates = document.getElementsByClassName(\"date-column\");\r\n    for (i=0; i<dates.length; i++)\r\n    {\r\n    \tvar str = dates[i].innerText;\r\n    \tdates[i].innerText = str.split(\" \")[0];\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Resolution>> Html { get; private set; }
    }
}
#pragma warning restore 1591
