using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Web.Areas.Clientes.Models
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(40)]
        public string Apellido { get; set; }

        [MaxLength(25)]
        [Required(ErrorMessage = "El documento de identidad es requerido")]
        public string DocumentoIdentidad { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public ICollection<PruebaTecnica.Core.Models.Direcciones> Direcciones { get; set; }
    }
}
