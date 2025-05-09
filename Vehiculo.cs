using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    internal class Vehiculo
    {
        public int idregistro { get; set; }
        public string num_placa { get; set; }
        public string tipo { get; set; }
        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
        public TimeSpan tiempo { get; set; }
        public DateTime create_date { get; set; }
        public DateTime moified_date { get; set; }
    }
}
