#pragma checksum "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\PROYECTO\Avances\T1\Usuarios\Usuarios\Usuarios\Usuarios\Areas\Users\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a15a19f6d047bcba36af02646c4ac960d4c3016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Users/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a15a19f6d047bcba36af02646c4ac960d4c3016", @"/Areas/Users/Views/Users/Index.cshtml")]
    public class Areas_Users_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a15a19f6d047bcba36af02646c4ac960d4c30162807", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" />
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans|Oswald|PT+Sans"" rel=""stylesheet"">

    <link href=""/css/Nosotros.css"" rel=""stylesheet"" />
    <link href=""/css/normalize.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a15a19f6d047bcba36af02646c4ac960d4c30164129", async() => {
                WriteLiteral(@"
    <header class=""site-header"">
        <div class=""hero"">
            <div class=""contenido-header"">
                <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-Online-101111435084124/""><i class=""fa fa-facebook""></i></a>
                    <a href=""https://twitter.com/""><i class=""fa fa-twitter"" ></i></a>
                    <a href=""https://www.youtube.com/""><i class=""fa fa-youtube-play"" ></i></a>
                    <a href=""https://www.instagram.com/""><i class=""fa fa-instagram"" ></i></a>
                </nav>
                <div class=""informacion-evento"">
                    <div class=""clearfix"">
                        <p class=""fecha""><i class=""fa fa-calendar"" ></i> 12-09-2020</p>
                        <p class=""ciudad""><i class=""fa fa-map-marker"" ></i> Cajamarca, Perú</p>
                    </div>

                    <h1 class=""nombre-sitio"">Gold Conference Online</h1>
                    <p class=""slogan"">La mejor confer");
                WriteLiteral(@"encia de <span>diseño web</span></p>
                </div>
                <!--.informacion-evento-->

            </div>
        </div>
        <!--.hero-->
    </header>

    <div class=""barra"">
        <div class=""contenedor clearfix"">
            <div class=""logo"">
                <!--<a href=""../Users/Index"">
                    <img src="""" alt=""logo"">-->
                <h3>Gold Conference Online</h3>
                <!--</a>-->
            </div>

            <nav class=""navegacion-principal clearfix"">
                <a href=""#"">Conferencia</a>
                <a href=""#"">Calendario</a>
                <a href=""#"">Invitados</a>
                <a href=""../Users/Users?area=Users"">Login</a>
            </nav>
        </div>
        <!--.contenedor-->
    </div>
    <!--.barra-->
    <section class=""seccion contenedor"">
        <h2>La mejor conferencia de diseño web en español</h2>
        <p class=""p-0 font-weight-lighter"">
            El vídeo proporciona una manera efic");
                WriteLiteral(@"az para ayudarle a demostrar el punto. Cuando haga clic en Vídeo en línea, puede pegar el código para insertar del vídeo que desea agregar. También puede escribir una palabra clave para buscar en línea el vídeo que mejor se adapte a su documento. Para otorgar a su documento un aspecto profesional, Word proporciona encabezados,
            pies de página, páginas de portada y diseños de cuadro de texto que se complementan entre sí.
        </p>
    </section>
    <!--seccion-->

    <section class=""programa"">
        <!--.contenedor-video-->
        <div class=""contenido-programa"">
            <div class=""contenedor"">
                <div class=""programa-evento"">
                    <h2>Programa del Evento</h2>

                    <nav class=""menu-programa"">
                        <a href=""#seminario"">
                            <i class=""fa fa-university""></i> Seminario
                        </a>
                        <a href=""#conferencias"">
                            <i class=""fa f");
                WriteLiteral(@"a-comment"" ></i> Conferencias
                        </a>
                        <a href=""#talleres"">
                            <i class=""fa fa-code""></i> Talleres
                        </a>
                    </nav>

                    <div id=""seminario"" class=""info-curso clearfix"">
                        <div class=""detalle-evento"">
                            <h3>Diseño UI y UX para móviles</h3>
                            <p><i class=""fa fa-clock-o""></i> 10:00:00</p>
                            <p><i class=""fa fa-calendar"" ></i> 29-09-2020</p>
                            <p><i class=""fa fa-user"" ></i> Jhan Ignacio</p>
                        </div>
                        <div class=""detalle-evento"">
                            <h3>Angular 10</h3>
                            <p><i class=""fa fa-clock-o"" ></i> 19:00:00</p>
                            <p><i class=""fa fa-calendar"" ></i> 10-10-2020</p>
                            <p><i class=""fa fa-user"" ></i> Brenda Sanchez</p>
  ");
                WriteLiteral(@"                      </div>
                        <a href=""#"" class=""button float-right"">Ver todos</a>
                    </div>
                    <!--#talleres-->

                </div>
                <!--.programa-evento-->
            </div>
            <!--.contenedor-->
        </div>
        <!--.contenido-programa-->
    </section>
    <!--.programa-->


    <section class=""precios seccion"">
        <h2>Precios</h2>
        <div class=""contenedor"">
            <ul class=""lista-precios clearfix"">
                <li>
                    <div class=""tabla-precio"">
                        <h3>Pase por día</h3>
                        <p class=""numero"">S/. 80</p>
                        <ul>
                            <li>Tips</li>
                            <li>Todas las conferencias</li>
                            <li>Todos los talleres</li>
                        </ul>
                        <a href=""#"" class=""button"">Comprar</a>
                    </div>
    ");
                WriteLiteral(@"            </li>
                <li>
                    <div class=""tabla-precio"">
                        <h3>Todos los días</h3>
                        <p class=""numero"">S/. 120</p>
                        <ul>
                            <li>Tips</li>
                            <li>Todas las conferencias</li>
                            <li>Todos los talleres</li>
                        </ul>
                        <a href=""#"" class=""button"">Comprar</a>
                    </div>
                </li>

                <li>
                    <div class=""tabla-precio"">
                        <h3>Pase por 2 días</h3>
                        <p class=""numero"">S/. 100</p>
                        <ul>
                            <li>Tips</li>
                            <li>Todas las conferencias</li>
                            <li>Todos los talleres</li>
                        </ul>
                        <a href=""#"" class=""button"">Comprar</a>
                    </div>
   ");
                WriteLiteral(@"             </li>
            </ul>
        </div>
    </section>
   
    <footer>
        <div class=""contenedor clearfix"">
            <div class=""footer-informacion"">
                <h3>Sobre <span>Gold Conference Online</span></h3>
                <p>
                    El vídeo proporciona una manera eficaz para ayudarle a demostrar el punto. Cuando haga clic en Vídeo en línea, puede pegar el código para insertar del vídeo que desea agregar. También puede escribir una palabra clave para buscar en línea el vídeo que mejor se adapte a su documento.
                </p>
            </div>

            <div class=""menu"">
                <h3>Redes <span>sociales</span></h3>
                <nav class=""redes-sociales"">
                    <a href=""https://www.facebook.com/Gold-Conference-Online-101111435084124/""><i class=""fa fa-facebook""></i></a>
                    <a href=""https://twitter.com/""><i class=""fa fa-twitter"" ></i></a>
                    <a href=""https://www.youtube.com/""><i ");
                WriteLiteral(@"class=""fa fa-youtube-play""></i></a>
                    <a href=""https://www.instagram.com/""><i class=""fa fa-instagram""></i></a>
                </nav>
            </div>
        </div>

        <p class=""copyright"">
            Todos los derechos Reservados GOLD CONFERENCE ONLINE 2020.
        </p>
    </footer>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
