#pragma checksum "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f16c7423b618588b26d4113df29db46f3ee77f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_Details), @"mvc.1.0.view", @"/Views/Candidate/Details.cshtml")]
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
#line 1 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\_ViewImports.cshtml"
using PruebaTecnica.PresentationWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\_ViewImports.cshtml"
using PruebaTecnica.PresentationWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
using PruebaTecnica.Application.Features.Candidates.Queries.GetCandidate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f16c7423b618588b26d4113df29db46f3ee77f3", @"/Views/Candidate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2386be6395ad23cc489bdb6ee35d6ba9f35f237d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Candidate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CandidateWithExperiencesVm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Candidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    <h2>Detalles del Candidato</h2>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f16c7423b618588b26d4113df29db46f3ee77f35161", async() => {
                WriteLiteral(" < Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 12 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                              Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">ID: ");
#nullable restore
#line 17 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                    Write(Model.CandidateId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Fecha de Nacimiento: ");
#nullable restore
#line 18 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                                     Write(Model.Birthdate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Correo Electrónico: ");
#nullable restore
#line 19 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h5 class=\"mt-4\">Experiencias Laborales</h5>\r\n");
#nullable restore
#line 22 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                 if (Model.CandidateExperiences != null && Model.CandidateExperiences.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Empresa</th>
                                <th>Puesto de Trabajo</th>
                                <th>Descripción</th>
                                <th>Salario</th>
                                <th>Fecha de Inicio</th>
                                <th>Fecha de Fin</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 36 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                             foreach (var experience in Model.CandidateExperiences)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.BeginDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                                   Write(experience.EndDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 49 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>No hay experiencias laborales registradas.</p>\r\n");
#nullable restore
#line 53 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 56 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No se encontraron detalles del candidato.</p>\r\n");
#nullable restore
#line 60 "C:\Users\kevin\OneDrive\Documentos\Personal\PruebaTecnica\PruebaTecnica.PresentationWeb\Views\Candidate\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CandidateWithExperiencesVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
