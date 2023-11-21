using Listas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Servicios
{
    internal class ClienteNuevoImpl:ClienteNuevoInterfaz
    {
        public void darAltaClienteNuevo(List<ClienteDto2> listaAntigua)
        {
            ClienteDto2 cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
        }

        private ClienteDto2 crearNuevoCliente()
        {
            ClienteDto2 nuevoCliente = new ClienteDto2();

            Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el dni:");
            nuevoCliente.Dni = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca IBAN:");
            nuevoCliente.Iban = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha alta:");
            nuevoCliente.FchAlta = Convert.ToString(Console.ReadLine());

            nuevoCliente.CodigoS = "CSI1SSXX";
            return nuevoCliente;
        }

      
    }
}

