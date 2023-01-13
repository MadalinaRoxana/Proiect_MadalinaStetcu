using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_MP_Madalina.Models
{
    public class JoinScenetaWTeatru
    {
        public int ID { get; set; }
        public int ScenetaID { get; set; }
        public Sceneta Sceneta { get; set; }
        public int TeatruID { get; set; }
        public Teatru Teatru { get; set; }
    }
}
