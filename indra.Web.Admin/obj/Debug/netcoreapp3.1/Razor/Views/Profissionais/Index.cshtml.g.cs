#pragma checksum "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53098ab51034fb82582d87acdb2de3685d6aa8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profissionais_Index), @"mvc.1.0.view", @"/Views/Profissionais/Index.cshtml")]
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
#line 1 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\_ViewImports.cshtml"
using indra.Web.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\_ViewImports.cshtml"
using indra.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
using indra.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
using indra.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53098ab51034fb82582d87acdb2de3685d6aa8d", @"/Views/Profissionais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f7aecdeaf77e4e686e937e54f46b2c26e52b4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profissionais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<indra.Models.PessoaFisica>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("adicaoProfissional"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtribuirServico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("atribuirServico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
  
    ViewData["Title"] = "Profissional";
    var lista = new List<eFiltro> { eFiltro.Todos, eFiltro.Ativos, eFiltro.Inativos }
        .Select(c => new CodigoDescricaoDTO { Codigo = (int)c, Descricao = c.ToString() });
    var selectList = new SelectList(lista, "Codigo", "Descricao");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["S_PROF_C"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        <strong>Sucesso! </strong> ");
#nullable restore
#line 16 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                              Write(TempData["S_PROF_C"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["S_PROF_E"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        <strong>Sucesso! </strong> ");
#nullable restore
#line 23 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                              Write(TempData["S_PROF_E"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["S_PROF_D"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        <strong>Sucesso! </strong> ");
#nullable restore
#line 30 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                              Write(TempData["S_PROF_D"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["S_ATRI_SER"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        ");
#nullable restore
#line 37 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
   Write(TempData["S_ATRI_SER"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["S_PROF_A"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-success alert-dismissible fade show text-center\" id=\"alert\">\r\n        ");
#nullable restore
#line 45 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
   Write(TempData["S_PROF_A"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
 if (TempData["E_PROF_A"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Error Alert -->\r\n    <div class=\"alert alert-danger alert-dismissible fade show text-center\" id=\"alert\">\r\n        ");
#nullable restore
#line 53 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
   Write(TempData["E_PROF_A"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary titulo"">
                        <h2 class=""card-title""><i class=""fa fa-user""></i>Profissionais</h2>
                    </div>
                    <div class=""card-body"">
                        <br />
                        <div class=""row"">
                            <div class=""col col-xs-12"">
                                <div class=""btnPesquisa"">
                                    <span class=""labelSearch"">Pesquisar</span>
                                    <br />
                                    <input type=""text"" id=""filtro"" />
                                    <button id=""btnFiltro"" class=""pesquisaButton"" type=""button""><i class=""fa fa-search""></i></button>
                                </div>
                                <br />
                     ");
            WriteLiteral("           <br />\r\n                                <div>\r\n                                    <span class=\"labelFilter\">Filtro</span>\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 79 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                               Write(Html.DropDownList("selectAtivos", selectList, new { @class = "select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53098ab51034fb82582d87acdb2de3685d6aa8d13841", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-plus-circle\"></i> Adicionar Profissional\r\n\r\n                                ");
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53098ab51034fb82582d87acdb2de3685d6aa8d15244", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-user-plus\"></i> Atribuir Serviço ao Profissional\r\n\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 92 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                         if (Model != null && Model.Any())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"divTabelaExibicao\">\r\n                                ");
#nullable restore
#line 95 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                           Write(Html.Partial("_TabelaProfissionaisPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 97 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <br />
                            <br />
                            <div class=""alert alert-info alert-dismissible fade show text-center"" id=""alert"">
                                Não existe nenhum profissional cadastrado.
                            </div>
");
#nullable restore
#line 105 "C:\Users\bruno\Google Drive\PROGRAMAÇÃO\Projeto Interdisciplinar ADS - Bruno Carlos da Silva\Aplicação\indra\indra.Web.Admin\Views\Profissionais\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var desativarProfissional = function (id) {
        Swal.fire({
            title: 'Atenção!',
            text: ""Tem certeza que deseja desativar esse profissional?"",
            icon: 'question',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sim',
            cancelButtonText: 'Não'
        }).then((result) => {
            if (result.isConfirmed) {
                var url = '/Profissionais/ConfirmarDesativacao';
                $.ajax({
                    url: url,
                    type: 'POST',
                    data: { id }
                }).done(function (data) {

                    if (data.success) {
                        Swal.fire({
                            title: 'Sucesso!',
                            html: data.message,
                  ");
            WriteLiteral(@"          icon: 'success'
                        }).then(function () {
                            window.location = '/Profissionais/Index';
                        });

                    } else {
                        Swal.fire(
                            'Ops',
                            data.message,
                            'warning'
                        );
                    }
                });
            }
        });

        var ativarProfissional = function (id) {
            Swal.fire({
                title: 'Atenção!',
                text: ""Tem certeza que deseja ativar esse profissional?"",
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Sim',
                cancelButtonText: 'Não'
            }).then((result) => {
                if (result.isConfirmed) {
                    var url = '/Clientes/Ativa");
            WriteLiteral(@"r';
                    $.ajax({
                        url: url,
                        type: 'GET',
                        data: { id }
                    }).done(function (data) {

                        if (data.success) {
                            Swal.fire({
                                title: 'Sucesso!',
                                html: data.message,
                                icon: 'success'
                            }).then(function () {
                                window.location = '/Clientes/Index';
                            });

                        } else {
                            Swal.fire(
                                'Ops',
                                data.message,
                                'warning'
                            );
                        }
                    });
                }
            })
        }
    }

    $(document).ready(function () {
        assineClickAplicarFiltro();
        assineCh");
            WriteLiteral(@"angeAtivo();
        $(""#alert"").hide();
        $(""#alert"").fadeTo(3000, 600).slideUp(600, function () {
            $(""#alert"").slideUp(600);
        });
    });

    var assineChangeAtivo = function () {
        $('#selectAtivos').on('change', function () {
            var valor = $(this).val();
            if (valor) {
                if (valor == 0) {
                    $('#tabela').find('tr').each(function (i, el) {
                        $(el).show();
                    });
                } else if (valor == 1) {
                    $('#tabela').find('.ativo').each(function (i, el) {
                        $(el).show();
                    });
                    $('#tabela').find('.inativo').each(function (i, el) {
                        $(el).hide();
                    });
                } else {
                    $('#tabela').find('.ativo').each(function (i, el) {
                        $(el).hide();
                    });
                    $('#tabela').find('");
            WriteLiteral(@".inativo').each(function (i, el) {
                        $(el).show();
                    });
                }
            }
        });
    }

    var assineClickAplicarFiltro = function () {
        $('#btnFiltro').on('click', function () {
            var url = '/Profissionais/GetListaDeProfissionais';
            var termoDeBusca = $('#filtro').val();
            $.ajax({
                url: url,
                type: 'GET',
                data: { termoDeBusca }
            }).done(function (data) {
                if (data.success) {
                    $('#divTabelaExibicao').fadeOut('slow', function () {
                        $('#divTabelaExibicao').html(data.html);
                        assineChangeAtivo();
                        $('#divTabelaExibicao').fadeIn('slow');
                    });
                } else {
                    Swal.fire(
                        'Ops',
                        data.message,
                        'warning'
              ");
            WriteLiteral(@"      );

                    $('#divTabelaExibicao').fadeOut('slow', function () {
                        $('#divTabelaExibicao').html('');
                        $('#divTabelaExibicao').fadeIn('slow');
                    });
                }
            });
        })
    }
</script>

<style>
    .btnVermelho:hover {
        background-color: #dc3545;
        border: 0px;
    }

    .btnVerde:hover {
        background-color: #47a44b;
        border: 0px;
    }

    .labelFilter {
        font-size: 1rem;
        font-weight: 500;
        color: #212529;
        text-align: center;
        margin-left: 15px;
    }

    .labelSearch {
        color: black;
        margin-left: -143px;
    }

    a:hover, a:focus {
        color: #ffffff;
        text-decoration: none;
    }

    .adicaoProfissional {
        background-color: #00bcd4;
        float: right;
        position: relative;
        padding: 12px 30px;
        margin: 0.3125rem 15px;
        font-si");
            WriteLiteral(@"ze: .75rem;
        font-weight: 400;
        line-height: 1.428571;
        text-decoration: none;
        text-transform: uppercase;
        letter-spacing: 0;
        cursor: pointer;
        outline: 0;
        transition: box-shadow 0.2s cubic-bezier(0.4, 0, 1, 1), background-color 0.2s cubic-bezier(0.4, 0, 0.2, 1);
        will-change: box-shadow, transform;
        color: #fff;
        box-shadow: 0 2px 2px 0 rgb(153 153 153 / 14%), 0 3px 1px -2px rgb(153 153 153 / 20%), 0 1px 5px 0 rgb(153 153 153 / 12%);
    }

    .atribuirServico {
        background-color: #00bcd4;
        float: right;
        position: relative;
        padding: 12px 30px;
        margin: 0.3125rem -15px;
        font-size: .75rem;
        font-weight: 400;
        line-height: 1.428571;
        text-decoration: none;
        text-transform: uppercase;
        letter-spacing: 0;
        cursor: pointer;
        outline: 0;
        transition: box-shadow 0.2s cubic-bezier(0.4, 0, 1, 1), background-colo");
            WriteLiteral(@"r 0.2s cubic-bezier(0.4, 0, 0.2, 1);
        will-change: box-shadow, transform;
        color: #fff;
        box-shadow: 0 2px 2px 0 rgb(153 153 153 / 14%), 0 3px 1px -2px rgb(153 153 153 / 20%), 0 1px 5px 0 rgb(153 153 153 / 12%);
    }

    .pesquisaButton {
        color: white;
        border-radius: 0.2rem;
        height: 31px;
        width: 36px;
        border: 0;
        margin-left: -15px;
        background-color: #00bcd4;
    }

    #filtro {
        margin: 0 13px;
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
        border: 2px solid black;
        border-radius: 5px;
    }

    .btnPesquisa {
        display: inline-block;
        font-weight: 500;
        color: #212529;
        text-align: center;
        vertical-align: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        background-color: transparent;
        border: 1px sol");
            WriteLiteral(@"id transparent;
        padding: 0.4rem 0.75rem;
        font-size: 1rem;
        line-height: 1.6;
        border-radius: 0.25rem;
        transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
        margin-top: -30px;
        margin-left: -12px;
    }

    .select {
        background: url(http://www.webcis.com.br/images/imagens-noticias/select/ico-seta-appearance.gif) no-repeat hsl(0deg 0% 91%);
        background-color: #00bcd4;
        background-position: 75px center;
        border: 0px;
        float: left;
        padding: 12px 50px 12px 7px;
        margin: 0.3125rem 15px;
        font-size: 0.75rem;
        font-weight: 400;
        line-height: 1.428571;
        text-decoration: none;
        text-transform: uppercase;
        letter-spacing: 0;
        cursor: pointer;
        border-radius: 0.2rem;
        outline: 0;
        transition: box-shadow 0.2s cubic-bezier(0.4, 0, 1, 1), backgro");
            WriteLiteral("und-color 0.2s cubic-bezier(0.4, 0, 0.2, 1);\r\n        color: #fff;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<indra.Models.PessoaFisica>> Html { get; private set; }
    }
}
#pragma warning restore 1591
