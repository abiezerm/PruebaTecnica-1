using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Core.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [MaxLength(30)]
        public string Nombre { get; set; }

        [MaxLength(40)]
        public string Apellido { get; set; }

        [MaxLength(25)]
        public string DocumentoIdentidad { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public ICollection<Direcciones> Direcciones { get; set; }
    }
}
