#pragma checksum "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b043cb10035f17af80ea63f990eb177d9d7140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Epets.App.Presentacion.Pages.Propietarios.Pages_Propietarios_BuscarPropietario), @"mvc.1.0.razor-page", @"/Pages/Propietarios/BuscarPropietario.cshtml")]
namespace Epets.App.Presentacion.Pages.Propietarios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b043cb10035f17af80ea63f990eb177d9d7140", @"/Pages/Propietarios/BuscarPropietario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d40880a7bf140c40cac66976ecbc90f9043f38fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Propietarios_BuscarPropietario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
  ViewData["Title"] = "E-Pets-Propietarios";

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
    #BannerPropietarios{
        
        
        background-image: url(""../img/Banner_Dueños.jpg"");
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
            <div class=""text-center"">
                <h");
            WriteLiteral(@"1 class=""display-4"">Bienvenido a Buscar Propietarios</h1>
                <p>MinTic-2021 <a href=""/Grupo_4/InicioGrupo_4"">Grupo_4</a>.</p>
            </div>

            <div id=""BannerPropietarios"" class=""page-banner overlay-dark bg-image"">
                <div class=""banner-section"">
                    <div class=""container text-center wow fadeInUp"">
                        <nav aria-label=""Breadcrumb"">
                            <ol class=""breadcrumb breadcrumb-dark bg-transparent justify-content-center py-0 mb-2"">
                                <li class=""breadcrumb-item""><a href=""/Index"">Inicio</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Buscar Propietarios</li>
                            </ol>
                        </nav>
                        <h1 class=""font-weight-normal"">Datos Propietarios</h1>
                    </div> <!-- .container -->
                </div> <!-- .banner-section -->
            </div> <!-- .page-banner ");
            WriteLiteral(@"-->

        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-5 col-sm-12"">
            <div class=""page-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"" style=""text-align: center;"">
                            <label>
                                <h1 class=""text-center wow fadeInUp"">Datos Propietarios</h1>
                            </label>
                        </div>
                    </div>
                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b043cb10035f17af80ea63f990eb177d9d71406466", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            
                            <div class=""col-md-6 "">
                                <label>Codigo: </label>
                                <input id=Codigo type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2999, "\"", 3035, 1);
#nullable restore
#line 97 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 3013, Model.Propietarios.Id, 3013, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled
                                    style=""margin-bottom: 20px;"">
                            </div>
                            <div class=""col-md-6 "">
                                <label>Cedula: </label>
                                <input id=Cedula type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3341, "\"", 3381, 1);
#nullable restore
#line 102 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 3355, Model.Propietarios.Cedula, 3355, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled
                                    style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                        <div class=""row"" style=""margin-bottom: 20px;"">

                            <div class=""col-md-6 "">
                                <label>Nombres: </label>
                                <input id=Nombres type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3795, "\"", 3835, 1);
#nullable restore
#line 110 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 3809, Model.Propietarios.Nombre, 3809, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled
                                    style=""margin-bottom: 20px;"">
                            </div>

                            <div class=""col-md-6 "">
                                <label>Apellidos: </label>
                                <input id=Apellidos type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4149, "\"", 4191, 1);
#nullable restore
#line 116 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 4163, Model.Propietarios.Apellido, 4163, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled
                                    style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                        <div class=""row"" style=""margin-bottom: 20px;"">
                            <div class=""col-md-6 "">
                                <label>Direccion: </label>
                                <input id=TarjetaProfesional type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4616, "\"", 4659, 1);
#nullable restore
#line 123 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 4630, Model.Propietarios.Direccion, 4630, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled 
                                style=""margin-bottom: 20px;"">
                            </div>
                            
                            <div class=""col-md-6 "">
                                <label>Telefono: </label>
                                <input id=Telefono type=""text"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4996, "\"", 5038, 1);
#nullable restore
#line 129 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Propietarios\BuscarPropietario.cshtml"
WriteAttributeValue("", 5010, Model.Propietarios.Telefono, 5010, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  disabled
                                style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                       


                        <div class=""row"">
                            <button id=""btnEliminar"" type=""submit"" class=""btn btn-danger mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Eliminar</button>
                                <a class=""btn btn-info mt-3 wow zoomIn"" id=""btnAtras""
                             style=""margin-bottom: 20px; margin-left: 10px;"" href=""/Propietarios/InicioPropietario"" role=""button"">Atras</a>
                            
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n     \r\n    </div> <!-- .page-section -->\r\n\r\n</div> <!-- .page-section -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Epets.App.Presentacion.Pages.BuscarPropietarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.BuscarPropietarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.BuscarPropietarioModel>)PageContext?.ViewData;
        public Epets.App.Presentacion.Pages.BuscarPropietarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
