using System;
using System.Collections.Generic;
using System.Text;

namespace PlasticosFortuna.Shared
{
    public class ItemOrdenTrabajo
    {
        public int Id { get; set; }
        public TipoPlastico TipoPlastico { get; set; }
        public int CantidadDeBobinas { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public int Espesor { get; set; }
        public OrdenDeTrabajo OrdenDeTrabajo { get; set; }
    }
}
