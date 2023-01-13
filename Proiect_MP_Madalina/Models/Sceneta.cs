using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_MP_Madalina.Models
{
    public class Sceneta { 


    public int ID { get; set; }
    [Display(Name = "Denumire Sceneta")]
    [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim cinci caractere."), MaxLength(30, ErrorMessage = "Maxim treizeci de caractere.")]
    public string Sceneta_denumire { get; set; }

    [Display(Name = "Descriere scurta")]
    [Required(ErrorMessage = "Camp obligatoriu."), MinLength(2, ErrorMessage = "Minim doua caractere."), MaxLength(300, ErrorMessage = "Maxim trei sute de caractere.")]
    public string Sceneta_categorie { get; set; }

    [Display(Name = "Varsta Minima")]
    [Required(ErrorMessage = "Camp obligatoriu.")]
    [Range(12, 18,ErrorMessage = "Varsta intre 12-18 ani.")]
    public int  Sceneta_varsta { get; set; }

    [Display(Name = "Autor")]
    [Required(ErrorMessage = "Camp obligatoriu.")]
    public int AutorID { get; set; }
    public Autor Autor { get; set; }

    [Display(Name = "Teatru")]
    [Required(ErrorMessage = "Camp obligatoriu.")]
    public int TeatruID { get; set; }
    public Teatru Teatru { get; set; }
    public ICollection<JoinScenetaWTeatru> JoinScenetaWTeatru { get; set; }

    [Display(Name = "Data")]
    [Required(ErrorMessage = "Camp obligatoriu.")]
    [DataType(DataType.Date)]
    public DateTime Sceneta_data { get; set; }


    [Display(Name = "Pret")]
    [Required(ErrorMessage = "Camp obligatoriu."), ]
    [Range(10, 1000,ErrorMessage= "Valoare intre 10 si 1000.")]
    public int Sceneta_pret { get; set; }
}
}
