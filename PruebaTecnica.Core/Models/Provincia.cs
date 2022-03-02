using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Core.Models
{
    public class Provincia
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public int ProvinciaId { get; set; }
        /// <summary>
        /// El nombre de la provincia
        /// </summary>
        [MaxLength(150)]
        public string ProvinciaNombre { get; set; }
        public bool Estado { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
