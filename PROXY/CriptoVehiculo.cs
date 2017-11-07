using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    public class CriptoVehiculo
    {
        private int codigoLlave;
        private int codigoSeguridad;

        public CriptoVehiculo(int codigoLlave, int codigoSeguridad)
        {
            this.codigoLlave = codigoLlave;
            this.codigoSeguridad = codigoSeguridad;
        }

        public int CodigoLlave
        {
            get { return codigoLlave; }
        }
        public int CodigoSeguridad
        {
            get { return codigoSeguridad; }
        }
    }
}
