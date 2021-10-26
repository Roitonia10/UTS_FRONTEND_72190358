#pragma checksum "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82af10bf2e22896cc6dc222dd9fb668e8760927"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFront358.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using BlazorFront358;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\UTS_Frontend\Blazor\BlazorFront358\_Imports.razor"
using BlazorFront358.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{id}")]
    public partial class DetailEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Detail Employee</h2>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "my-2 mt-4");
            __builder.AddAttribute(3, "border", "3");
            __builder.AddAttribute(4, "align", "left");
            __builder.AddAttribute(5, "colspan", "2");
            __builder.AddAttribute(6, "font");
            __builder.AddAttribute(7, "face", "Times New Roman");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "<td><b>Employee Id </b></td> ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "b");
            __builder.AddContent(12, " : ");
            __builder.AddContent(13, 
#nullable restore
#line 6 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                    Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, " \r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<td><b>First Name </b></td> ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "b");
            __builder.AddContent(19, " : ");
            __builder.AddContent(20, 
#nullable restore
#line 7 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                   Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, " \r\n        ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<td><b>Last Name </b></td> ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "b");
            __builder.AddContent(26, " : ");
            __builder.AddContent(27, 
#nullable restore
#line 8 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                  Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<td><b>Email </b></td> ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "b");
            __builder.AddContent(33, " : ");
            __builder.AddContent(34, 
#nullable restore
#line 9 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                              Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<td><b>DateOfBirth </b></td> ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "b");
            __builder.AddContent(40, " : ");
            __builder.AddContent(41, 
#nullable restore
#line 10 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                    Employee.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "<td><b>Gender </b></td> ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "b");
            __builder.AddContent(47, " : ");
            __builder.AddContent(48, 
#nullable restore
#line 11 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                               Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "<td><b>DepartmentId </b></td> ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "b");
            __builder.AddContent(54, " : ");
            __builder.AddContent(55, 
#nullable restore
#line 12 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                     Employee.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "<td><b>PhotoPath </b></td>");
            __builder.OpenElement(59, "td");
            __builder.OpenElement(60, "b");
            __builder.AddContent(61, " : ");
            __builder.AddContent(62, 
#nullable restore
#line 13 "C:\UTS_Frontend\Blazor\BlazorFront358\Pages\DetailEmployee.razor"
                                                 Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591