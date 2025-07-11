using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KiemTraMVC.Models;

namespace KiemTraMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KiemTraMVC.Models.nguyenchithanh> nguyenchithanh { get; set; } = default!;
    }
}
