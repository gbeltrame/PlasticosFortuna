using System;
using System.Collections.Generic;

namespace PlasticosFortuna.Shared
{
    public class OrdenDeTrabajo
    {
        // Identificador unico de orden de trabajo (autoincremental)
        public int OrdenId { get; set; }
        // Nombre de la orden
        public string Nombre { get; set; }
        // Descripcion o notas de la orden
        public string Descripcion { get; set; }
        // Lista de items de la orden de trabajo
        public ICollection<ItemOrdenTrabajo> Items { get; set; }
        // Determina si se vendera la bobina como producto final
        public bool BobinaProducto { get; set; }
        // Determina si la orden necsita tener impresion
        public bool NecesitaImpresion { get; set; }
        public Cliente Cliente { get; set; }
        // Estado de la orden (enum)
        public EstadoOrden Estado { get; set; }
        // Fecha de creacion de la orden
        public DateTime FechaCreacion { get; set; }
        // Fecha de ultima modificacion de la orden
        public DateTime FechaModificacion { get; set; }
    }
}
