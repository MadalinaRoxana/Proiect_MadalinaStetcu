using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Pages.Scenete
{
    public class EditModel : PageModel
    {
        private readonly Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext _context;

        public EditModel(Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sceneta Sceneta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sceneta = await _context.Sceneta
                .Include(s => s.Autor)
                .Include(s => s.Teatru).FirstOrDefaultAsync(m => m.ID == id);

            if (Sceneta == null)
            {
                return NotFound();
            }
           ViewData["AutorID"] = new SelectList(_context.Autor, "ID", "Autor_Nume");
           ViewData["TeatruID"] = new SelectList(_context.Teatru, "ID", "Teatru_Denumire");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sceneta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScenetaExists(Sceneta.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScenetaExists(int id)
        {
            return _context.Sceneta.Any(e => e.ID == id);
        }
    }
}
