using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    // Clase abstracta de la que heredará el elemento original y el proxy
    public abstract class Llave
    {
        // Código de la llave
        protected int codigoLlave;

        // Propiedad de sólo lectura para obtener el código de la llave
        public int CodigoLlave
        {
            get { return codigoLlave; }
        }

        // Métodos abstractos que implementarán el elemento real y el proxy
        public abstract void RealizarContacto(CriptoVehiculo cripto);
        public abstract bool LlaveCorrecta(int codigoLlave);
    }
}
