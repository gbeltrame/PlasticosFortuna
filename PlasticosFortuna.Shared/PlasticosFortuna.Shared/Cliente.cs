using System.Collections;
using System.Collections.Generic;

namespace PlasticosFortuna.Shared
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<OrdenDeTrabajo> OrdenesDeTrabajo { get; set; }
    }
}