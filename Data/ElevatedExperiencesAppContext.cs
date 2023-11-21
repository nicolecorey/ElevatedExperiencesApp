using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ElevatedExperiencesApp.Models;

namespace ElevatedExperiencesApp.Data
{
    public class ElevatedExperiencesAppContext : DbContext
    {
        public ElevatedExperiencesAppContext (DbContextOptions<ElevatedExperiencesAppContext> options)
            : base(options)
        {
        }

        public DbSet<ElevatedExperiencesApp.Models.Service> Service { get; set; } = default!;
    }
}
