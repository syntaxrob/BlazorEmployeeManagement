#pragma checksum "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe0d8015a393c13dba985b2c6ee318b1d9ee4a7"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width: 30.5%");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                          CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "h3");
            __builder.AddContent(12, 
#nullable restore
#line 6 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
             Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 6 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                 Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 9 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 11 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-footer text-center");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 14 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-primary m-1");
            __builder.AddContent(28, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 15 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "btn btn-primary m-1");
            __builder.AddContent(33, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 18 "D:\Education\BlazorEmployeeTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
