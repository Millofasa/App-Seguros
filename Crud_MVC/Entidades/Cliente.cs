using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Cliente
    {
        public int IdCliente { get; set; }

       [Required(ErrorMessage = "Ingresar un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El # de documento es requerido")]
        public string Documento { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El Email ingresado no es valido.")]
        public string Correo { get; set; }
    }
}
