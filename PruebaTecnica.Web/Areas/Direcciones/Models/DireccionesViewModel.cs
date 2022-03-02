using PruebaTecnica.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Web.Areas.Direcciones.Models
{
    public class DireccionesViewModel
    {
        public int DireccionId { get; set; }

        [Required(ErrorMessage = "El tipo de vivienda es requerido")]
        public string TipoDeVivienda { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [Required(ErrorMessage = "El municipio es requerido")]
        public int MunicipioId { get; set; }

        public Municipio Municipio { get; set; }

        [Required(ErrorMessage = "La provincia es requerida")]
        public int ProvinciaId { get; set; }

        public Provincia Provincia { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
