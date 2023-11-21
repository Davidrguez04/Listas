
using Listas.Entidades;
using Listas.Servicios;

namespace Listas.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista para base de datos
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            List<ClienteDto2> listaCliente2 = new List<ClienteDto2>();


            InterfazMenu menuInterfaz = new ImplMenu();
            ClienteInterfaz ci =new ClienteImplementacion();
            ClienteNuevoInterfaz mi=new ClienteNuevoImpl();


            //Control de repetición menú
            bool cerrarMenu = false;

            //Opción sellecionada por usuario
            int opcionSeleccionada;

            menuInterfaz.mensajeBienvenida();

            

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
                        ci.darAltaCliente(listaCliente);
                        Console.Clear();

                        foreach(ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString());
                            Console.WriteLine("\n");
                        }
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
                        Console.WriteLine("\n\tMostar clientes registrados en banco");
                        Console.Clear();
                        foreach (ClienteDto2 cliente in listaCliente2)
                        {
                            Console.WriteLine(cliente.ToString());
                            Console.WriteLine("\n");
                        }
                       
                        break;

                    case 6:
                        Console.WriteLine("\n\tNuevo Cliente:");
                        mi.darAltaClienteNuevo(listaCliente2);
                        Console.Clear();

                        foreach(ClienteDto2 cliente in listaCliente2)
                        {
                            Console.WriteLine(cliente.ToString());
                            Console.WriteLine("\n");
                        }
                        break;

                   

                    default:
                        Console.WriteLine("\n\t[INFO]- La opción que has seleccionado no se encuentra dentro de los casos");
                        break;
                }
            }
            }

                }
            

            }

