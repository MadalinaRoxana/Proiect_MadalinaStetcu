using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Models
{
    public class Proiect_MP_MadalinaContext : DbContext
    {
        public Proiect_MP_MadalinaContext (DbContextOptions<Proiect_MP_MadalinaContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_MP_Madalina.Models.Sceneta> Sceneta { get; set; }

        public DbSet<Proiect_MP_Madalina.Models.Autor> Autor { get; set; }

        public DbSet<Proiect_MP_Madalina.Models.Teatru> Teatru { get; set; }
    }
}
