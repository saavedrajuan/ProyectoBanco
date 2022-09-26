using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class CajaDeAhorro
    {
        public int id { get; set; }
        public int cbu { get; set; }
        public float saldo { get; set; }

        public List<Usuario> titulares;
        public List<Usuario> movimientos;

    
    }
}
