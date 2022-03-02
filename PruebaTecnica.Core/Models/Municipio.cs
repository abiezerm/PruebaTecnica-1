using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Core.Models
{
    public class Municipio
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public int MunicipioId { get; set; }
        /// <summary>
        /// Nombre del municipio
        /// </summary>
        [MaxLength(100)]
        public string MunicipioNombre { get; set; }
        /// <summary>
        /// ID de la tabla provincia
        /// </summary>
        public int ProvinciaId { get; set; }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set; }
        public bool Estado { get; set; }
    }
}
