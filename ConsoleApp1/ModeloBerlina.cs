using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ModeloBerlina : ModeloVehiculo
    {
        internal ModeloBerlina(string marca, string modelo, string color)
            : base(marca, modelo, color)
        {
        }

        public override void MostrarCaracteristicas(string datosExtra)
        {
            base.MostrarCaracteristicas(datosExtra);
        }
    }
}
