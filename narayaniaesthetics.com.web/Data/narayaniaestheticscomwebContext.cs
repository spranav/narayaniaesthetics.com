using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using narayaniaesthetics.com.web.Models;

namespace narayaniaesthetics.com.web.Data
{
    public class narayaniaestheticscomwebContext : DbContext
    {
        public narayaniaestheticscomwebContext (DbContextOptions<narayaniaestheticscomwebContext> options)
            : base(options)
        {
        }

        public DbSet<narayaniaesthetics.com.web.Models.BlogPost>? BlogPosts { get; set; }
    }
}
