#pragma checksum "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224f212858b0b9793a51cc1391d12b397fd7082d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f212858b0b9793a51cc1391d12b397fd7082d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activivdad2.Models.Promedio>
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
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224f212858b0b9793a51cc1391d12b397fd7082d2740", async() => {
                WriteLiteral("\n    <title>Calcular Promedio</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224f212858b0b9793a51cc1391d12b397fd7082d3740", async() => {
                WriteLiteral("\n\n    <form action=\"/\" method=\"post\">\n        <h2>Promediar clificaciones</h2><br />\n        <input type=\"number\" name=\"Cal1\"");
                BeginWriteAttribute("value", " value=\"", 242, "\"", 261, 1);
#nullable restore
#line 12 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
WriteAttributeValue("", 250, Model.Cal1, 250, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br /><br />\n        <input type=\"number\" name=\"Cal2\"");
                BeginWriteAttribute("value", " value=\"", 319, "\"", 338, 1);
#nullable restore
#line 13 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
WriteAttributeValue("", 327, Model.Cal2, 327, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br /><br />\n        <input type=\"number\" name=\"Cal3\"");
                BeginWriteAttribute("value", " value=\"", 396, "\"", 415, 1);
#nullable restore
#line 14 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
WriteAttributeValue("", 404, Model.Cal3, 404, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> <br /><br />\n        <input type=\"submit\" name=\"Resultado\" />\n        <p>Resultado: ");
#nullable restore
#line 16 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
                 Write(Model.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p>\n            Estado: ");
#nullable restore
#line 18 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
                     if (Model.Resultado >= 70)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>Aprobado </p>");
#nullable restore
#line 20 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
                            }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<p>Reprobado </p>");
#nullable restore
#line 22 "C:\Users\Cecilia\Desktop\Programacion web 2021\Actividad 1\Activivdad2\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    </form>\n\n\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activivdad2.Models.Promedio> Html { get; private set; }
    }
}
#pragma warning restore 1591
