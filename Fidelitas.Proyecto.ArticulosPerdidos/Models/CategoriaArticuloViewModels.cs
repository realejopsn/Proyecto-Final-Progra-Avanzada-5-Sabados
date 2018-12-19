using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fidelitas.Proyecto.ArticulosPerdidos.Models
{
    public class CategoriaArticuloViewModels
    {
        [Display(Name = "Categoría")]
        public string NOMBRE_CATEGORIA;
    }
}