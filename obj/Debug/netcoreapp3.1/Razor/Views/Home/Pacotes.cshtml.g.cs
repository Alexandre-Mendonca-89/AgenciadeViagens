#pragma checksum "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc415e9b20e95a67e01f1d170190953c62f8384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pacotes), @"mvc.1.0.view", @"/Views/Home/Pacotes.cshtml")]
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
#line 1 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\_ViewImports.cshtml"
using projeto_destino_certo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\_ViewImports.cshtml"
using projeto_destino_certo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc415e9b20e95a67e01f1d170190953c62f8384", @"/Views/Home/Pacotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7317d4c760d2f84c0297249d72e62202191ecda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pacotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacotes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icones-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-pacotes.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-shopping.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("icone-sacola"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-add.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Adicionar novo pacote"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro_Pacotes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-close.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
  
    ViewData["Title"] = "Pacotes";

    string conta = Context.Session.GetString("conta");

    if (conta == "usuario")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <style>\r\n            .card-button button {\r\n                display: none;\r\n            }\r\n        </style>\r\n");
#nullable restore
#line 15 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .nav-bar,
    footer,
    .menu-hamburger ul {
        background-color: #34495e !important;
        border: none !important;
    }

    .fundo-img {
        background-image: none !important;
        min-height: none !important;
        overflow-y: scroll !important;
    }
</style>

<main class=""fundo-color"">

    <div class=""pacotes-content"">
        <div class=""icone-titulo"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcc415e9b20e95a67e01f1d170190953c62f83848368", async() => {
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
            WriteLiteral("\r\n            <h3 class=\"titulos\">PACOTES</h3>\r\n        </div>\r\n        <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcc415e9b20e95a67e01f1d170190953c62f83849572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
    </div>

    <p class=""paragrafos"">Aproveite agora os descontos exclusivos com parcelamento em até 15x sem juros! Não perca essa
        chance, compre e viaje quando quiser!</p>

    <div class=""splide"">
        <div class=""splide__track"">
            <ul class=""splide__list"">
");
#nullable restore
#line 48 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                 foreach (Pacotes p in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"splide__slide\">\r\n\r\n                        <div class=\"cards\" id=\"card01\">\r\n                            <div class=\"card-button\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcc415e9b20e95a67e01f1d170190953c62f838411604", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcc415e9b20e95a67e01f1d170190953c62f838411821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <a class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1736, "\"", 1773, 2);
            WriteAttributeValue("", 1743, "/Home/Excluir_Pacotes?id=", 1743, 25, true);
#nullable restore
#line 58 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
WriteAttributeValue("", 1768, p.id, 1768, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcc415e9b20e95a67e01f1d170190953c62f838414587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n\r\n                            </div>\r\n                            <div class=\"cards-text\">\r\n                                <h6>");
#nullable restore
#line 63 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                               Write(p.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                <ul>\r\n                                    <li>Saindo de ");
#nullable restore
#line 66 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                                             Write(p.origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                                    <li>Saída: ");
#nullable restore
#line 68 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                                          Write(p.saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                                    <li>Retorno: ");
#nullable restore
#line 70 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                                            Write(p.retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                                    <li>Preço ida e volta: <b>");
#nullable restore
#line 72 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                                                         Write(p.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</b></li>\r\n\r\n                                    <li>Usuário: ");
#nullable restore
#line 74 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                                            Write(p.usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 80 "E:\projetos_vscode\Modulo_A_Estruturar_E_Implementar_Banco_de_Dados_Para_Aplicacoes_Web\extra\projeto-destino-certo\Views\Home\Pacotes.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacotes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
