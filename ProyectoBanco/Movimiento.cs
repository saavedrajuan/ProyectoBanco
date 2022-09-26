using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class Movimiento
    {
        public int id { get; set; }
        public CajaDeAhorro caja { get; set; }
        public string detalle { get; set; }
        public float monto { get; set; }
        public Date Fecha { get; set; }



    }
}
