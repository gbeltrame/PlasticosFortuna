using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlasticosFortuna.Shared
{
    public class OrdenDeTrabajo
    {
        [Key]
        [Display(Name = "Numero de Orden")]
        public int Id { get; set; }

        [Display(Name = "Nombre de la Orden")]
        [MaxLength(70, ErrorMessage = "La cantidad maxima de caracteres es 70")]
        public string Nombre { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad maxima de caracteres es 250")]
        public string Descripcion { get; set; }
        
        [Required]
        public ICollection<ItemOrdenTrabajo> Items { get; set; }

        // Determina si se vendera la bobina como producto final
        [Display(Name = "Bobina Producto Final")]
        [Required]
        public bool BobinaProducto { get; set; }

        [Display(Name = "Necesita Impresion")]
        [Required]
        public bool NecesitaImpresion { get; set; }
        
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "El campo 'Estado' es requerido")]
        public EstadoOrden Estado { get; set; }

        [Display(Name = "Tipo de creacion")]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Fecha de modificacion")]
        public DateTime FechaModificacion { get; set; }


    }
}
