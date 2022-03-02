using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Core.Models
{
    public class Direcciones
    {
        [Key]
        public int DireccionId { get; set; }


        public string TipoDeVivienda { get; set; }
        public string Descripcion { get; set; }


        //public DateTime FechaCreacion { get; set; }
        //public DateTime? FechaModificacion { get; set; }

        public int MunicipioId { get; set; }

        [ForeignKey("MunicipioId")]
        public Municipio Municipio { get; set; }

        public int ProvinciaId { get; set; }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

    }
}
