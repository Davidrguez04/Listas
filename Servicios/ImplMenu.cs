using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Servicios
{
    internal class ImplMenu:InterfazMenu
    {
        public void mensajeBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mensaje = "Bienvenido a cajero de CSI1";
            Console.WriteLine("\n\n\t\t\t\t" + mensaje);
        }
        public int mostrarMenu()
        {
            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t--------------------------------");
            Console.WriteLine("\t\t\t\t|\tMenú:            ");
            Console.WriteLine("\t\t\t\t|0.-Salir                     ");
            Console.WriteLine("\t\t\t\t|1.-Dar de alta Cliente                     ");
            Console.WriteLine("\t\t\t\t|2.- Ingresar Dinero                    ");
            Console.WriteLine("\t\t\t\t|3.-Sacar Dinero            ");
            Console.WriteLine("\t\t\t\t|4.-Transferir Dinero            ");
            Console.WriteLine("\t\t\t\t|5.-Historial de operaciones            ");
            Console.Write("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;

        }
    }
}
