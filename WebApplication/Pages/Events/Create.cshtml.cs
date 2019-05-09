using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication.Models;

namespace WebApplication.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication.Models.WebApplicationContext _context;

        public CreateModel(WebApplication.Models.WebApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IList<WebApplication.Models.Events> Events { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events.Add(Events);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}