using System;
using System.Collections.Generic;
using System.Text;

namespace PlasticosFortuna.Shared
{
    class Plastico
    {
        public int IdPlastico { get; set; }
        // Tipo de plastico
        public TipoPlastico tipo { get; set; }
        // Cantidad total del tipo de plastico en Kg
        public int CantidadTotal { get; set; }
        // Detalles de operaciones de compra y uso de plastico
        public ICollection<Operacion> DetallesPlastico { get; set; }
    }
}
