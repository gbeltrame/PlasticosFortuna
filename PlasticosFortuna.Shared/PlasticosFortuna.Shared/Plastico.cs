using System;
using System.Collections.Generic;
using System.Text;

namespace PlasticosFortuna.Shared
{
    public class Plastico
    {
        public int Id { get; set; }
        // Tipo de plastico
        public TipoPlastico Tipo { get; set; }
        // Cantidad total del tipo de plastico en Kg
        public int CantidadTotal { get; set; }
        // Detalles de operaciones de compra y uso de plastico
        public ICollection<Operacion> Operaciones { get; set; }
    }
}
