using System;

namespace PlasticosFortuna.Shared
{
    public class Operacion
    {
        public int Id { get; set; }
        // Tipo de operacion para el plastico
        public TipoOperacion TipoOperacion { get; set; }
        // Cantidad comprada o consumida
        public int Cantidad { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}