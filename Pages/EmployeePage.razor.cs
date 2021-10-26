using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront358.Models;
using BlazorFront358.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront358.Pages
{
    public partial class EmployeePage
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}