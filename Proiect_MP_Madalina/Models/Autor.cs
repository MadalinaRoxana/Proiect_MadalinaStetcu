using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_MP_Madalina.Models
{
    public class Autor
    {
        public int ID { get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(3, ErrorMessage = "Minim trei caractere."), MaxLength(30, ErrorMessage = "Maxim 30 de caractere.")]
        public string Autor_Nume { get; set; }
        public ICollection<Sceneta> Sceneta { get; set; }
    }
}
