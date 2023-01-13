using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Pages.Scenete
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext _context;

        public IndexModel(Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext context)
        {
            _context = context;
        }

        public IList<Sceneta> Sceneta { get;set; }

        public async Task OnGetAsync()
        {
            Sceneta = await _context.Sceneta
                .Include(s => s.Autor)
                .Include(s => s.Teatru).ToListAsync();
        }
    }
}
