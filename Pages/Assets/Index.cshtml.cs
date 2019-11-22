using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk_AC.Models;

namespace tbkk_AC.Pages.Assets
{
    public class IndexModel : PageModel
    {
        private IHostingEnvironment environment;


        public void OnPost(IFormFile photo)
        {
            var file = Path.Combine(environment.ContentRootPath, "uploads",photo.FileName );
            var fileStream = new FileStream(file, FileMode.Create);
            photo.CopyToAsync(fileStream);
            
        }

        private readonly tbkk_AC.Models.tbkk_ACContext _context;

        public IndexModel(tbkk_AC.Models.tbkk_ACContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }

        public IList<Asset> Asset { get;set; }
        public BufferedSingleFileUploadDb FileUpload { get; set; }

        public async Task OnGetAsync()
        {
            Asset = await _context.Asset.ToListAsync();
        }

    }
    public class BufferedSingleFileUploadDb
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile ImageFile { get; set; }
    }

}
