using System;
using System.ComponentModel.DataAnnotations;

namespace PlasticosFortuna.Shared
{
    public class Operacion
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo de operacion")]
        [Required(ErrorMessage = "El campo 'Tipo de operacion' es requerido")]
        public TipoOperacion TipoOperacion { get; set; }

        [Required(ErrorMessage = "El campo 'Plastico' es requerido")]
        public Plastico Plastico { get; set; }

        [Required(ErrorMessage = "El campo 'Cantidad' es requerido")]
        [Range(0, Int32.MaxValue, ErrorMessage = "El campo 'Cantidad' debe ser mayor a 0")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo 'Proveedor' es requerido")]
        public Proveedor Proveedor { get; set; }

        [Display(Name = "Fecha de Operacion")]
        public DateTime FechaOperacion { get; set; }
    }
}