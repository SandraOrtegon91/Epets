#pragma checksum "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Medicos\InicioMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5a95ab9e7eb8df672772b33708ff0f9b62cd29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Epets.App.Presentacion.Pages.Medicos.Pages_Medicos_InicioMedico), @"mvc.1.0.razor-page", @"/Pages/Medicos/InicioMedico.cshtml")]
namespace Epets.App.Presentacion.Pages.Medicos
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
#line 1 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\_ViewImports.cshtml"
using Epets.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5a95ab9e7eb8df672772b33708ff0f9b62cd29", @"/Pages/Medicos/InicioMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d40880a7bf140c40cac66976ecbc90f9043f38fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicos_InicioMedico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Elija opcion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Opcion Perro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Opcion Gato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Opcion Pajaro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Opcion todos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Medicos\InicioMedico.cshtml"
  
    ViewData["Title"] = "E-Pets - Mascotas Felices";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tr:hover {
        background-color: rgb(252, 255, 95);
    }

    #jhan {
        border-radius: 150%;
        height: 50px;
        width: 50px;
        font-size: 1px;

    }
    #BannerVeterinarios{
        
        
        background-image: url(""../img/vector-vet-clinic-banner-on-white-background.jpg"");
    }

    #jhan:hover {
        border-radius: 0%;
        height: 50px;
        width: 100px;
        font-size: 30px;

    }

    #btnConsultar:hover{
        background-color: #BBBBBB;
    }

     #btnRegistrar:hover{
        background-color: #0DC7E5;
    }

    #btnActualizar:hover{
        background-color: #10D691;
    }

    #btnEliminar:hover{
        background-color: #FE5D6E;
    }


    #imagen {
        border-top-left-radius: 70%;
    }

    #Cardimagen:hover #imagen {
        border-top-left-radius: 0px;
    }
</style>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""te");
            WriteLiteral(@"xt-center"">
                <h1 class=""display-4"">Bienvenido Medico</h1>
                <p>MinTic-2021 <a href=""#"">Grupo_4</a>.</p>
            </div>

            <div id=""BannerVeterinarios"" class=""page-banner overlay-dark bg-image"">
                <div class=""banner-section"">
                    <div class=""container text-center wow fadeInUp"">
                        <nav aria-label=""Breadcrumb"">
                            <ol class=""breadcrumb breadcrumb-dark bg-transparent justify-content-center py-0 mb-2"">
                                <li class=""breadcrumb-item""><a href=""/Index"">Inicio</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Veterinarios</li>
                            </ol>
                        </nav>
                        <h1 class=""font-weight-normal"">Nuestros Veterinarios</h1>
                    </div> <!-- .container -->
                </div> <!-- .banner-section -->
            </div> <!-- .page-banner -->


");
            WriteLiteral(@"
            <div class=""page-section bg-light"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-10"">

                            <div class=""row"">

                                <div class=""col-md-6 col-lg-4 py-3 wow zoomIn"">
                                    <div class=""card-doctor"" id=""Cardimagen"">
                                        <div class=""header"">
                                            <img src=""../img/doctors/doctor_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2729, "\"", 2735, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""imagen"">
                                            <div class=""meta"">
                                                <a href=""#""><span class=""mai-call""></span></a>
                                                <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                                            </div>
                                        </div>
                                        <div class=""body"">
                                            <p class=""text-xl mb-0"">Dr. Estefania Perdomo</p>
                                            <span class=""text-sm text-grey"">Medica Veterinaria</span>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-md-6 col-lg-4 py-3 wow zoomIn"">
                                    <div class=""card-doctor"" id=""Cardimagen"">
                                        <div class=""header"">
                              ");
            WriteLiteral("              <img src=\"../img/doctors/doctor_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3812, "\"", 3818, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""imagen"">
                                            <div class=""meta"">
                                                <a href=""#""><span class=""mai-call""></span></a>
                                                <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                                            </div>
                                        </div>
                                        <div class=""body"">
                                            <p class=""text-xl mb-0"">Dr. Alex Mejia</p>
                                            <span class=""text-sm text-grey"">Dentista Canino</span>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-md-6 col-lg-4 py-3 wow zoomIn"">
                                    <div class=""card-doctor"" id=""Cardimagen"">
                                        <div class=""header"">
                                        ");
            WriteLiteral("    <img src=\"../img/doctors/doctor_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4885, "\"", 4891, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""imagen"">
                                            <div class=""meta"">
                                                <a href=""#""><span class=""mai-call""></span></a>
                                                <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                                            </div>
                                        </div>
                                        <div class=""body"">
                                            <p class=""text-xl mb-0"">Dr. Rebecca Rodriguez</p>
                                            <span class=""text-sm text-grey"">Zootecnista</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-5 col-sm-12"">
            <div class=""page");
            WriteLiteral(@"-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"" style=""text-align: center;"">
                            <label>
                                <h1 class=""text-center wow fadeInUp"">CRUD Medido</h1>
                            </label>
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2912245", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-6 "">
                                <input type=""text"" class=""form-control"" placeholder=""Digite Cedula"" style=""margin-bottom: 20px;"">
                            </div>
                            <div class=""col-md-6 "">
                                <input type=""text"" class=""form-control"" placeholder=""Digite Nombres"" style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                        <div class=""row"" style=""margin-bottom: 20px;"">

                            <div class=""col-md-6 "">
                                <input type=""text"" class=""form-control"" placeholder=""Digite Apellidos"" style=""margin-bottom: 20px;"">
                            </div>

                            <div class=""col-md-6 "">
                                <input type=""text"" class=""form-control"" placeholder=""Digite Tarjeta Profesional"">
                            </div>
   ");
                WriteLiteral(@"                     </div>
                        <div class=""row"" style=""margin-bottom: 20px;"">
                             <div class=""col-md-6 "">
                                <input type=""text"" class=""form-control"" placeholder=""Digite Telefono"">
                            </div>
                            <div class=""col-md-6 "">
                                <select name=""Tipo Animal"" id=""Especialidad"" class=""custom-select"" style=""margin-bottom: 20px;"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2914141", async() => {
                    WriteLiteral("--Elija Especialidad--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2915417", async() => {
                    WriteLiteral("Perro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2916676", async() => {
                    WriteLiteral("Gato");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2917934", async() => {
                    WriteLiteral("Pajaro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f5a95ab9e7eb8df672772b33708ff0f9b62cd2919194", async() => {
                    WriteLiteral("Perro, Gato, Pajaro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                </select>


                            </div>
                        </div>


                        <div class=""row"">
                            <button id=""btnConsultar"" type=""submit"" class=""btn btn-secondary mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Consultar</button>
                            <button id=""btnRegistrar"" type=""submit"" class=""btn btn-primary mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Registrar</button>
                            <button id=""btnActualizar"" type=""submit"" class=""btn btn-success mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Actualizar</button>
                            <button id=""btnEliminar"" type=""submit"" class=""btn btn-danger mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Eliminar</button>
                     ");
                WriteLiteral("   </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-7 col-sm-12"">
            <caption><h4>Listado Medicos</h4></caption>
            <table class=""table"">
                <!-- <Mascotas a Cargo</caption>-->
                <thead>
                    <tr class=""bg-warning"" id=""tablaj"">
                        <th scope=""col"">Codigo</th>
                        <th scope=""col"">Cedula</th>
                        <th scope=""col"">Nombres </th>
                        <th scope=""col"">Apellidos</th>
                        <th scope=""col"">N. Tarjeta Profesiona</th>
                        <th scope=""col"">Telefono</th>
                        <th scope=""col"">Especialidad</th>

                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">1</th>

                        <td>1106789789</td>
                        <td>Samuel</td>
                        <td>Rodriguez</td>
        ");
            WriteLiteral(@"                <td>O2345RGH</td>
                        <td>3112345432</td>
                        <td>Perro</td>
                    </tr>
                    <tr>
                        <th scope=""row"">2</th>

                        <td>1110524169</td>
                        <td>German</td>
                        <td>Ospina</td>
                        <td>234520ULB</td>
                        <td>3214748012</td>
                        <td>Gato</td>
                    </tr>
                    <tr>
                         <th scope=""row"">3</th>
                        <td>1105682311</td>
                        <td>Sandra</td>
                        <td>Ortegon</td>
                        <td>1789005YUO</td>
                        <td>3133958228</td>
                        <td>Perro</td>

                    </tr>
                    <tr>
                        <th scope=""row"">4</th>
                         <td>1021067801</td>
                        <td>Jhan</td>");
            WriteLiteral(@"
                        <td>Meneses</td>
                        <td>567296HYTR</td>
                        <td>3124567890</td>
                        <td>Pajaro</td>
                    </tr>
                </tbody>
            </table>
            <caption><h4>Listado de Visitas</h4></caption>
            <table class=""table"">
                <!-- <caption>Listado De visitas</caption>-->
                <thead>
                    <tr class=""bg-warning"" id=""tablaj"">
                        <th scope=""col"">Codigo</th>
                        <th scope=""col"">Nombre Mascota</th>
                        <th scope=""col"">Tipo Animal</th>
                        <th scope=""col"">Fecha y Hora</th>
                        <th scope=""col"">Direccion</th>
                        <th scope=""col"">Estado Visita</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">1</th>
                        <td>Rober");
            WriteLiteral(@"to</td>
                        <td>Pajaro</td>
                        <td>10-10-2021 10:12 am</td>
                        <td>manz 9 casa 17 Espinal-Tolima</td>
                        <td>Pendiente</td>
                    </tr>
                    <tr>
                        <th scope=""row"">2</th>
                        <td>Kira</td>
                        <td>Gato</td>
                        <td>15-10-2021</td>
                        <td>Calle 4 Ibague-Tolima</td>
                        <td>Pendiente</td>
                    </tr>

                    <tr>
                        <th scope=""row"">3</th>
                        <td>Otto</td>
                        <td>Perro</td>
                        <td>30-09-2021 2:45 pm</td>
                        <td>Carrera 1 # 2-34 Espinal-Tolima</td>
                        <td>Realizada</td>
                    </tr>
                    <tr>
                        <th scope=""row"">4</th>
                        <td>Kira</td>
   ");
            WriteLiteral(@"                     <td>Gato</td>
                        <td>30-09-2021 4:40pm</td>
                        <td>Calle 4 Ibague-Tolima</td>
                        <td>Realizada</td>
                    </tr>

                </tbody>
            </table>
        </div> <!-- .container -->
    </div> <!-- .page-section -->

</div> <!-- .page-section -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Epets.App.Presentacion.Pages.InicioMedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.InicioMedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.InicioMedicoModel>)PageContext?.ViewData;
        public Epets.App.Presentacion.Pages.InicioMedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
