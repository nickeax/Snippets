using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Snippets.Models;

namespace Snippets.Data
{
    public class SnippetsContext : DbContext
    {
        public SnippetsContext (DbContextOptions<SnippetsContext> options)
            : base(options)
        {
        }

        public DbSet<Snippets.Models.Movie> Movie { get; set; }
    }
}
