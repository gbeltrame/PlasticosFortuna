using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlasticosFortuna.Shared
{
    public class Proveedor
    {
        [Display(Name = "Numero de Proveedor")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' es requerido")]
        [MaxLength(70, ErrorMessage = "La cantidad maxima de caracteres es 70")]
        [MinLength(2, ErrorMessage = "La cantidad minima de caracteres es 2")]
        public string Nombre { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad maxima de caracteres es 250")]
        public string Descripcion { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "El valor del campo 'Email' no tiene un formato valido")]
        public string Email { get; set; }

        public ICollection<Operacion> Operaciones { get; set; }
    }
}