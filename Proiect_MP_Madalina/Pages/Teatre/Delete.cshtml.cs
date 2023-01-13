using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Pages.Teatre
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext _context;

        public DeleteModel(Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teatru Teatru { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teatru = await _context.Teatru.FirstOrDefaultAsync(m => m.ID == id);

            if (Teatru == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teatru = await _context.Teatru.FindAsync(id);

            if (Teatru != null)
            {
                _context.Teatru.Remove(Teatru);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
