#pragma checksum "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f776b6658da220a0dec913c6a5905999d4101ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipamentos_Index), @"mvc.1.0.view", @"/Views/Equipamentos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Equipamentos/Index.cshtml", typeof(AspNetCore.Views_Equipamentos_Index))]
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
#line 1 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\_ViewImports.cshtml"
using PaineisSolares;

#line default
#line hidden
#line 2 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\_ViewImports.cshtml"
using PaineisSolares.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f776b6658da220a0dec913c6a5905999d4101ca8", @"/Views/Equipamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ecb55b59f2439d492c88a99e74e42f990764e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaineisSolares.Models.Equipamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-for", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
  
    ViewData["Title"] = "Equipamentos";

#line default
#line hidden
            BeginContext(105, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(112, 17, false);
#line 7 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 26, true);
            WriteLiteral("</h2>\r\n\r\n<br />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(155, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e28e855258e4780a93009cf4dcd0722", async() => {
                BeginContext(202, 21, true);
                WriteLiteral("Adicionar Equipamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 182, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-striped table-hover \">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Editar\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(410, 45, false);
#line 21 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(511, 46, false);
#line 24 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 51, false);
#line 27 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConsumoUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(664, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(720, 48, false);
#line 30 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConsumoTotal));

#line default
#line hidden
            EndContext();
            BeginContext(768, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(824, 46, false);
#line 33 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HorasDeUso));

#line default
#line hidden
            EndContext();
            BeginContext(870, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(926, 54, false);
#line 36 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConsumoTotalPorDia));

#line default
#line hidden
            EndContext();
            BeginContext(980, 125, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Deletar\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1154, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1214, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a16bab7a156f48fe9c50703d3371c30b", async() => {
                BeginContext(1259, 74, true);
                WriteLiteral("\r\n                        <i class=\"fas fa-pen\"></i>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1337, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1405, 44, false);
#line 53 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1517, 45, false);
#line 56 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1630, 50, false);
#line 59 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConsumoUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1748, 47, false);
#line 62 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConsumoTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1863, 45, false);
#line 65 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HorasDeUso));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1976, 53, false);
#line 68 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConsumoTotalPorDia));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2096, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3de2f50ab734ab288363277f7859508", async() => {
                BeginContext(2138, 76, true);
                WriteLiteral("\r\n                        <i class=\"fas fa-trash\"></i>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2218, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "C:\Erich\Cursos\PaineisSolares\Projeto\PaineisSolares\PaineisSolares\Views\Equipamentos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2273, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaineisSolares.Models.Equipamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
