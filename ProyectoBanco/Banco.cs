using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class Banco
    {
        public List<Usuario> usuarios { get; set; }
        public List<CajaDeAhorro> caja { get; set; }
        public List<PlazoFijo> pfs { get; set; }
        public List<TarjetaDeCredito> tarjetas { get; set; }
        public List<Pago> pagos { get; set; }
        public List <Movimiento> movimientos { get; set; }



    }
}
