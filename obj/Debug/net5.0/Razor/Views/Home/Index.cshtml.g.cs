#pragma checksum "D:\PROYECTOS\Briefcase .Net 5.0\Briefcase2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb8d5c750b49e2536b5513ea9d758bb7c9d1cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\PROYECTOS\Briefcase .Net 5.0\Briefcase2\Views\_ViewImports.cshtml"
using Briefcase2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROYECTOS\Briefcase .Net 5.0\Briefcase2\Views\_ViewImports.cshtml"
using Briefcase2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb8d5c750b49e2536b5513ea9d758bb7c9d1cea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff832784cf2bcd19adc2543213f9cb4d07b700d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROYECTOS\Briefcase .Net 5.0\Briefcase2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eb8d5c750b49e2536b5513ea9d758bb7c9d1cea3909", async() => {
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
            WriteLiteral(@"
<!------ WELCOME ------->
<div id=""welcome"">
    <div class=""caja"">
        <div class=""title"">
            <h1>BIENVENIDO A</h1>
            <h2>Portafolio Web</h2>
            <h3> Te saluda cordialmente Narvasta Pichilingue Sergio  </h3>
        </div>
        <div class=""text"">
            <p>Las habilidades requeridas para avanzar en su comprension lectora y ganar su lugar en la</p>
            <p>cima no son fáciles. Ahora hay un enfoque más gratificante para el aprendizaje</p>
            <p>práctico que lo ayuda a alcanzar sus objetivos más rápido.</p>
            <strong>¡Gana puntos,niveles y logra más!</strong>
        </div>
    </div>
</div>
<!-- NIVELES -->
<div id=""Niveles"">

    <div class=""Niv-Basico"">
        <a href=""niv-basico.html"">
            <p>Nivel</p> <p>Basico</p>
            <img src=""img/alumno1.gif"">
        </a>
    </div>
    <div class=""Niv-Intermedio"">
        <a href=""niv-intermedio.html"">
            <p>Nivel </p><p>Intermedio</p>
            ");
            WriteLiteral(@"<img src=""img/alumno2.gif"">
        </a>
    </div>
    <div class=""Niv-Avanzado"">
        <a href=""niv-avanzado.html"">
            <p>Nivel </p> <p>Avanzado</p>
            <img src=""img/alumno4.gif"">
        </a>
    </div>
</div>
<!-- PROJECTS -->
<div id=""projects"">
    <div class=""centro"">
        <div class=""unjfsc""><a href=""http://www.unjfsc.edu.pe/"" target=""_blank""><img src=""img/unjfsc.jpg"" width=""140"" height=""140""></a></div>
        <div class=""spinout""><a href=""https://www.facebook.com/SpinOutUNJFSC/"" target=""_blank""><img src=""img/SpinOut.jpg"" width=""140"" height=""140""></a></div>
        <div class=""innova""> <a");
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1765, 0);
            EndWriteAttribute();
            WriteLiteral(@"><img src=""img/Innova.png"" width=""140"" height=""140""></a></div>
        <div class=""SM1551""><a href=""http://www.1551.pe/"" target=""_blank""><img src=""img/1551.png"" width=""140"" height=""140""></a></div>
    </div>
    <div class=""def"">
        <div class=""df1""><p>Universidad Nacional</p> <p>Jose Faustino</p> <p>Sanchez Carrion</p></div>
        <div class=""df2""><p>SpinOut UNJFSC</p></div>
        <div class=""df3""><p>Programa</p> <p>Faustino Innova</p></div>
        <div class=""df4""><p>1551 Incubadora de</p><p>Empresas Innovadoras</p><p>UNMSM</p></div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
