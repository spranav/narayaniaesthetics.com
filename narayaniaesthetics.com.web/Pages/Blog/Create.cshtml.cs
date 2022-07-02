using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using narayaniaesthetics.com.web.Data;
using narayaniaesthetics.com.web.Models;

namespace narayaniaesthetics.com.web.Pages.Blog
{
    public class CreateModel : PageModel
    {
        private readonly narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext _context;

        public CreateModel(narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BlogPosts.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
