﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee
                .Include(e => e.Company)
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).ToListAsync();
        }
    }
}
