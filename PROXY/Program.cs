using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PATRON PROXY");
            int codigoLlave = 532543463;
            int codigoSeguridad = 1038948470;
            Console.WriteLine(codigoSeguridad);

            CriptoVehiculo cripto = new CriptoVehiculo(codigoLlave, codigoSeguridad);

            Llave llaveSimple = new LlaveReal(codigoLlave);
            llaveSimple.RealizarContacto(cripto);

            Llave proxy = new LlaveProxy(llaveSimple);
            proxy.RealizarContacto(cripto);
            Console.ReadLine();
        }
    }
}
