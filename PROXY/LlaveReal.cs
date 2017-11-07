using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    public class LlaveReal : Llave
    {
        // Constructor base: asigna el código de la llave a la llave
        public LlaveReal(int codigoLlave)
        {
            this.codigoLlave = codigoLlave;
        }

        // Realizar contacto: comprueba que el código de la llave sea correcto.
        // En caso de que lo sea, arranca el vehículo.
        public override void RealizarContacto(CriptoVehiculo cripto)
        {
            if (LlaveCorrecta(cripto.CodigoLlave))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de llave inválido");
        }

        // Comprueba que el código proporcionado coincide con el de la llave
        public override bool LlaveCorrecta(int codigoLlave)
        {
            return codigoLlave == this.codigoLlave;
        }
    }
}
