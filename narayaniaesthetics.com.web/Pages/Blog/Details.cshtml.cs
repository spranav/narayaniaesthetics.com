using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using narayaniaesthetics.com.web.Data;
using narayaniaesthetics.com.web.Models;

namespace narayaniaesthetics.com.web.Pages.Blog
{
    public class DetailsModel : PageModel
    {
        private readonly narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext _context;

        public DetailsModel(narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext context)
        {
            _context = context;
        }

        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogPost = await _context.BlogPosts.FirstOrDefaultAsync(m => m.Id == id);

            if (BlogPost == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
