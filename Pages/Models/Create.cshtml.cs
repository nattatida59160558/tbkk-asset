using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Models
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;
        private IHostingEnvironment environment;


        

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }


        public IActionResult OnGet()
        {
        ViewData["BrandID"] = new SelectList(_context.Brand, "BrandID", "BrandName");
        ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Model Model { get; set; }

        public async Task<IActionResult> OnPostAsync(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "uploads", photo.FileName);
            var fileStream = new FileStream(file, FileMode.Create);
            await photo.CopyToAsync(fileStream);
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Model.Add(Model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}