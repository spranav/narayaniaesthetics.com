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
    public class IndexModel : PageModel
    {
        private readonly narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext _context;

        public IndexModel(narayaniaesthetics.com.web.Data.narayaniaestheticscomwebContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get;set; }

        public async Task OnGetAsync()
        {
            BlogPost = await _context.BlogPosts.ToListAsync();
        }
    }
}
