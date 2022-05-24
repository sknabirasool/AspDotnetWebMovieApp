using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspWebCoreApp.Models;

namespace AspWebCoreApp.Data
{
    public class AspWebCoreAppContext : DbContext
    {
        public AspWebCoreAppContext (DbContextOptions<AspWebCoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<AspWebCoreApp.Models.Movie>? Movie { get; set; }
    }
}
