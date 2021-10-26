using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront358.Models;
using BlazorFront358.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront358.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }
         [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "7";
            Employee = await EmployeeService.GetById(int.Parse(id));
        }
    }
}