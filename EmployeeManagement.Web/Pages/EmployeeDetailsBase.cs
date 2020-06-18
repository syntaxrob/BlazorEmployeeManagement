using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        protected string Coodinates { get; set; }

        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Id ??= "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        //protected void Mouse_Move(MouseEventArgs e)
        //{
        //    Coodinates = $"X = {e.ClientX} Y = {e.ClientY}";
        //}
    }
}
