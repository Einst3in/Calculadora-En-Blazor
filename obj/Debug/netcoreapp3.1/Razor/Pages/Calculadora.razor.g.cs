#pragma checksum "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd922d51cb0a2e75675507bdaa0868b9ab73888b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calculadora")]
    public partial class Calculadora : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>C A L C U L A D O R A</h1>\n\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<th>Primer Numero</th>\n        ");
            __builder.OpenElement(7, "th");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
                          n1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => n1 = __value, n1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\n        ");
            __builder.AddMarkupContent(15, "<th>Segundo numero</th>\n        ");
            __builder.OpenElement(16, "th");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
                          n2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => n2 = __value, n2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\n        ");
            __builder.AddMarkupContent(24, "<th>Suma:</th>\n        ");
            __builder.OpenElement(25, "th");
            __builder.AddContent(26, 
#nullable restore
#line 38 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
             Suma

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n     ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\n        ");
            __builder.AddMarkupContent(31, "<th>Resta:</th>\n        ");
            __builder.OpenElement(32, "th");
            __builder.AddContent(33, 
#nullable restore
#line 42 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
             Resta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n     ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\n        ");
            __builder.AddMarkupContent(38, "<th>Multiplicacion:</th>\n        ");
            __builder.OpenElement(39, "th");
            __builder.AddContent(40, 
#nullable restore
#line 46 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
             Multiplicacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n\n");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
                                          Calcular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Calcular");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/miguelgondres/OneDrive - Universidad Católica Nordestana (UCNE)/ucne/3-2020/Aplicada 2/tests/BlazorApp1/Pages/Calculadora.razor"
      

    public int n1{ get; set; } = 0;
    public int n2 { get; set; } = 0;
    public int suma { get; set; } = 0;
    public int resta { get; set; } = 0;
    public int multiplicacion { get; set; } = 0;
    public String Suma { get; set; }
    public String Resta { get; set; }
    public String Multiplicacion { get; set; }
    
    public void Calcular()
    {
        var suma = n1+n2;
        Suma = suma.ToString();
        var resta = n1-n2;
        Resta= resta.ToString();
        var multiplicacion= n1*n2;
        Multiplicacion= multiplicacion.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
