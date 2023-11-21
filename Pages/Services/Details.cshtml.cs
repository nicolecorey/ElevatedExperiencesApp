﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly ElevatedExperiencesApp.Data.ElevatedExperiencesAppContext _context;

        public DetailsModel(ElevatedExperiencesApp.Data.ElevatedExperiencesAppContext context)
        {
            _context = context;
        }

      public Service Service { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Service == null)
            {
                return NotFound();
            }

            var service = await _context.Service.FirstOrDefaultAsync(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }
            else 
            {
                Service = service;
            }
            return Page();
        }
    }
}
