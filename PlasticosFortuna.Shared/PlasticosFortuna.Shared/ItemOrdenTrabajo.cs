using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlasticosFortuna.Shared
{
    public class ItemOrdenTrabajo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tipo de plastico")]
        [Required(ErrorMessage = "El campo 'Tipo de plastico' es requerido")]
        public TipoPlastico TipoPlastico { get; set; }

        [DisplayName("Cantidad de bobinas")]
        [Required(ErrorMessage = "El campo 'Cantidad de Bobinas' es requerido")]
        public int CantidadDeBobinas { get; set; }

        
        [Required(ErrorMessage = "El campo 'Ancho' es requerido")]
        [Range(0,Int32.MaxValue,ErrorMessage = "El campo 'Ancho' debe ser mayor a 0")]
        public int Ancho { get; set; }
        
        [Required(ErrorMessage = "El campo 'Largo' es requerido")]
        public int Largo { get; set; }
        
        [Required(ErrorMessage = "El campo 'Espesor' es requerido")]
        public int Espesor { get; set; }
        
        public OrdenDeTrabajo OrdenDeTrabajo { get; set; }
    }
}
