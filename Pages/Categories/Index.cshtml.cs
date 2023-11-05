﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nistor_Anamaria_Lab2.Data;
using Nistor_Anamaria_Lab2.Models;
using Nistor_Anamaria_Lab2.Models.ViewModels;

namespace Nistor_Anamaria_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Nistor_Anamaria_Lab2.Data.Nistor_Anamaria_Lab2Context _context;

        public IndexModel(Nistor_Anamaria_Lab2.Data.Nistor_Anamaria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
