using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Licenses
{
    public class CreateModel : PageModel
    {
        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public CreateModel(tbkk_AC.Models.tbkk_ACContext context)
        {
            _context = context;
        }
        [BindProperty]
        public License License { get; set; }
        [BindProperty]
        public Update_License UpdateLicense { get; set; }
        public IList<Model> Model { get; set; }
        public IList<Supplier> Supplier { get; set; }
        public IList<Department> Department { get; set; }
        public IList<Company> Company { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Supplier = await _context.Supplier.ToListAsync();
            Model = await _context.Model.ToListAsync();
            Department = await _context.Department.ToListAsync();
            Company = await _context.Company.ToListAsync();
            return Page();
        }
        //public IActionResult OnGet()
        //{
            //ViewData["Company_CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyID");
            //ViewData["Department_DepartmentID"] = new SelectList(_context.Department, "DepartmentID", "DepartmentID");
            //ViewData["Model_ModelID"] = new SelectList(_context.Model, "ModelID", "ModelID");
            //ViewData["Supplier_SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "SupplierID");
            //ViewData["License_LicenseID"] = new SelectList(_context.License, "LicenseID", "LicenseID");
            //return Page();
        //}

        

        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            UpdateLicense.Date = DateTime.Now;
            UpdateLicense.LicenseName = License.LicenseName.ToString();
            UpdateLicense.SoftewareName = License.SoftewareName.ToString();
            UpdateLicense.PurchaseDate = License.PurchaseDate;
            UpdateLicense.StartDate = License.StartDate;
            UpdateLicense.ExpireDate = License.ExpireDate;
            UpdateLicense.PONumber = License.PONumber.ToString();
            UpdateLicense.Attachfiles = License.Attachfiles.ToString();
            UpdateLicense.Note = License.Note.ToString();
            UpdateLicense.Status = License.Status.ToString();
            UpdateLicense.Model_ModelID = License.Model_ModelID;
            UpdateLicense.Supplier_SupplierID = License.Supplier_SupplierID;
            UpdateLicense.Department_DepartmentID = License.Department_DepartmentID;
            UpdateLicense.Company_CompanyID = License.Company_CompanyID;
            UpdateLicense.License_LicenseID = License.LicenseID;
            
            _context.License.Add(License);
            await _context.SaveChangesAsync();
            _context.Attach(UpdateLicense).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
        
    }
}