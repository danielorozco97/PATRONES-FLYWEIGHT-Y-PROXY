using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    public class LlaveProxy : Llave
    {
        // Referencia a la llave original
        private Llave llaveOriginal;

        // Constructor en el que se inyectará el objeto real
        public LlaveProxy(Llave llave)
        {
            llaveOriginal = llave;
        }

        // Este método realizará el control de acceso sobre el método original.
        // Realizará una comprobación previa comparando el código de seguridad y, si este es
        // correcto, invocará el método del objeto real.
        public override void RealizarContacto(CriptoVehiculo cripto)
        {
            // Realizamos una comprobación adicional de seguridad. En caso de no cumplirse, se
            // aborta la operación. Esta operación podría ser la ejecución de un algoritmo para
            // comprobar la autenticidad del código de la llave, una comprobación de nombre de
            // usuario y contraseña... o cualquier otra comprobación que queramos realizar.
            if (cripto.CodigoSeguridad > llaveOriginal.CodigoLlave)
            {
                Console.WriteLine("Código de seguridad incorrecto. Abortanto arranque");
                return;
            }

            if (LlaveCorrecta(cripto.CodigoLlave))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de llave inválido");
        }

        // Este método no realizará comprobaciones adicionales. Se limitará a invocar el método
        // del objeto real.
        public override bool LlaveCorrecta(int codigoLlave)
        {
            return llaveOriginal.LlaveCorrecta(codigoLlave);
        }
    }
}
