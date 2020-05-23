using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlasticosFortuna.Shared
{
    public class Plastico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Tipo' es requerido")]
        public TipoPlastico Tipo { get; set; }

        [Display(Name = "Cantidad Total")]
        [Range(0, Int32.MaxValue, ErrorMessage = "El campo 'Cantidad Total' debe ser mayor o igual a 0")]
        public int CantidadTotal { get; set; }

        public ICollection<Operacion> Operaciones { get; set; }
    }
}
