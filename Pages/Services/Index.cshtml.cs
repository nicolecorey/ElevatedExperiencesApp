using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ElevatedExperiencesApp.Data;
using ElevatedExperiencesApp.Models;

namespace ElevatedExperiencesApp.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly ElevatedExperiencesApp.Data.ElevatedExperiencesAppContext _context;

        public IndexModel(ElevatedExperiencesApp.Data.ElevatedExperiencesAppContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Service != null)
            {
                Service = await _context.Service.ToListAsync();
            }
        }
    }
}
