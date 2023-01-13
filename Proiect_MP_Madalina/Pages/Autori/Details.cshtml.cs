using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Pages.Autori
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext _context;

        public DetailsModel(Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext context)
        {
            _context = context;
        }

        public Autor Autor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Autor = await _context.Autor.FirstOrDefaultAsync(m => m.ID == id);

            if (Autor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
