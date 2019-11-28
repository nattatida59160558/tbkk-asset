using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages
{
    public class IndexModel : PageModel
    {

        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }

        public Login Login { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string Username = Request.Form["Username"];
            string Password = Request.Form["Password"];
            Debug.WriteLine(Username);
            if (Username == string.Empty && Password == string.Empty)
            {
                return Page();

            }


            Login = await _context.Login.Include(e => e.Employee)
                .FirstOrDefaultAsync(u => u.Username.Equals(Username));

            if (Login == null)
            {
                return Page();
            }
            if (!Login.Password.Equals(Password))
            {
                return Page();
            }
            ViewData["Employee_EmployeeID"] = new SelectList(_context.Set<Employee>(), "EmployeeID", "EmployeeID");
            Debug.WriteLine(Login.Employee_EmployeeID);




            return RedirectToPage("./Homes/Home", new { id = Login.Employee.EmployeeID });


        }

    }
}
