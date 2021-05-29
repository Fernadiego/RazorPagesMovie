using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        /// <summary>
        /// La base de datos requiere el campo para la clave principal.
        /// </summary>
        public int ID { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// El atributo [DataType] especifica el tipo de datos (Date). Con este atributo:
        /// No se requiere que el usuario ingrese información de hora en el campo de fecha.
        /// Solo se muestra la fecha, no la información de la hora.
        /// </summary>
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal Price { get; set; }
    }
}
