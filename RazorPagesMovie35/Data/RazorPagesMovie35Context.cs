using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie35.Models;

namespace RazorPagesMovie35.Data
{
    public class RazorPagesMovie35Context : DbContext
    {
        public RazorPagesMovie35Context (DbContextOptions<RazorPagesMovie35Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie35.Models.Movie> Movie { get; set; }
    }
}
