/**/
using Listas.Entidades;
using Listas.Servicios;

namespace Listas.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteDto cliente = new ClienteDto();

            

            //Llamada al método que imprime el mensaje por consola
            InterfazMenu menuInterfaz = new ImplMenu();
            //Control de repetición menú
            bool cerrarMenu = false;
            //Opción sellecionada por usuario
            int opcionSeleccionada;

            menuInterfaz.mensajeBienvenida();

            List<ClienteDto>listaCliente=new List<ClienteDto>();

            /*El menú se mostrará tras cada selección y ejecución de esta mientras no se coja la opción 0 que es la que controla
             * el valor el boolean cerrarMenu
             */
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.Clear();
                Console.WriteLine("\n\t[INFO] - Has seleccionado la opción: " + opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        Console.WriteLine("\n\tLa sesión se cerrará");
                        break;

                    case 1:
                        Console.WriteLine("\n\tSe ejecuta el alta");
                        Console.WriteLine("\n\tIntroduzca su nombre: ");
                        cliente.NombreCliente=Console.ReadLine();
                        listaCliente.Add(cliente.NombreCliente);
                        
                        break;

                    case 2:
                        Console.WriteLine("\n\t");
                        break;

                    case 3:
                        Console.WriteLine("\n\t");
                        break;

                    case 4:
                        Console.WriteLine("\n\t");
                        break;

                    case 5:
                        Console.WriteLine("\n\tg");
                        break;

                    default:
                        Console.WriteLine("\n\t[INFO]- La opción que has seleccionado no se encuentra dentro de los casos");
                        break;
                }
            }
            }

                }
            

            }

