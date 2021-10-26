using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront358.Models;
using BlazorFront358.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFront358.Pages
{
    public partial class DepartmentPage
    {
      public List<Department> Departments { get; set; } = new List<Department>();
        
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}  