
namespace ejer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ordenador ordenador = new Ordenador();
            //Hashtable ordenadoresRed = new Hashtable(); //Es con Dictionary

            Dictionary<String, Ordenador> ordenadoresRed = new Dictionary<string, Ordenador>();
            //ordenadoresRed.Add("IPs Ordenadores", "Tipo ordenador"); //EJEMPLO
            //ordenadoresRed.Add("a", ordenador); //EJEMPLO
            int option;

            bool flag = false;

            do
            {
                flag = false;
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("1. Añadir un nuevo equipo");
                Console.WriteLine("2. Añadir varios equipos");
                Console.WriteLine("3. Elimina dato por clave");
                Console.WriteLine("4. Mostrar lista de nombres");
                Console.WriteLine("5. Mostrar un elemento de la coleccion");
                Console.WriteLine("6. Salir");
                flag = int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        anhadirEquipo(ordenadoresRed);
                        break;
                    case 2:
                        anhadirVarios(ordenadoresRed);
                        break;
                    case 3:
                        if (ordenadoresRed == null || ordenadoresRed.Count == 0)
                        {
                            Console.WriteLine("La caleccion es nula");
                        }
                        else
                        {
                            Console.WriteLine("Introduce la clave del elemento que deseas eliminar");
                            //String clave = Console.ReadLine();
                            eliminarDato(ordenadoresRed, Console.ReadLine());
                        }

                        break;
                    case 4:
                        if (ordenadoresRed == null || ordenadoresRed.Count == 0)
                        {
                            Console.WriteLine("La caleccion es nula");
                        }
                        else
                        {
                            mostrarElementos(ordenadoresRed);
                        }
                        break;
                    case 5:
                        if (ordenadoresRed == null || ordenadoresRed.Count == 0)
                        {
                            Console.WriteLine("La caleccion es nula");
                        }
                        else
                        {
                            Console.WriteLine("Escribe la IP del ordenador que quieres obtener informacion: ");
                            mostrarUnElemento(ordenadoresRed, Console.ReadLine());
                        }
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }

            } while (option != 6);
        }

        // se le pasa una hashtable de ordenadores en la que meter los equipos, se le pide una ip al usuario,
        // llama a la funcion para comprobar ip, si no da error mira que no existaen la coleccion, en caso de estar todo bien
        // se crea un objeto ordenador nuevo y se le añade el nombre y la ram que tiene, para esta ultima se comprueba que no sea 
        // negativa y que no sea texto
        public static void anhadirEquipo(Dictionary<string, Ordenador> ordenadores)
        {
            String ip;
            bool flag = false;
            bool flagRam = true;
            //do
            //{
                flag = false;
                //try
                //{
                Console.WriteLine("Escribe una ip para el equipo: ");
                ip = Console.ReadLine();

                if (!Ordenador.compruebaIP(ip))
                {
                    Console.WriteLine("Hay un error en la ip");
                    flag = true;
                }
                else if (ordenadores.ContainsKey(ip))
                {
                    Console.WriteLine("La ip ya se encuentra ocupada");
                    flag = true;
                }

                if (flag == false)
                {
                    Ordenador nuevo = new Ordenador();

                    Console.WriteLine("Escribe el nombre del ordenador: ");
                    nuevo.Nombre = Console.ReadLine();

                    flagRam = true;
                    do
                    {
                        Console.WriteLine("Escribe cuantos GB tiene la RAM: ");
                        if (int.TryParse(Console.ReadLine(), out int ram))
                        {
                            try
                            {
                                nuevo.Ram = ram;
                                flagRam = false;
                            }
                            catch (NegativeRAMException)
                            {
                                Console.WriteLine("La RAM no puede ser negativa");
                                flagRam = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tienes que escribir un numero");
                            flagRam = true;
                        }
                    }
                    while (flagRam);

                    ordenadores.Add(ip, nuevo);
                }
                }
                //    catch (IOException)//TODO revisar
                //    {
                //        Console.WriteLine("Hay un error en la ip");
                //        flag = true;
                //    }
                //}
                //while (flag == true);
            //}

        //Se le pasa un hashtable de ordenadores, pedimos una lista de nombres al usuario en formato: ip:ram separados por ",", creamos
        // un array de ips(ips con rams separados por equipos), recorremos el array para separar las rams de las IPS (comprueba que tenga dos partes (ip y ram)), cogemos la primera parte 
        // ip y la segunda parte (ram)

        public static void anhadirVarios(Dictionary<string, Ordenador> ordenadores)
        {
            string nombre;

            Console.WriteLine("Introduce los equipos en formato ip:ram separados por una \",\" ej:192.0.0.1:16,192.0.0.2:8 :");
            string cadenaOrdenadores = Console.ReadLine();

            string[] ips = cadenaOrdenadores.Split(',');

            for (int i = 0; i < ips.Length; i++)
            {
                String[] rams = ips[i].Split(':');
                if (rams.Length != 2)
                {
                    Console.WriteLine("Formato incorrecto en: " + ips[i]);
                }
                else
                {
                    string ip = rams[0].Trim();
                    if (!Ordenador.compruebaIP(ip))
                    {
                        Console.WriteLine("IP no valida: " + ips[i]);
                    }
                    else if (ordenadores.ContainsKey(ip))
                    {
                        Console.WriteLine("La ip ya esta ucupada: " + ip);
                    }
                    else if (!int.TryParse(rams[1].Trim(), out int ramP))
                    {
                        Console.WriteLine("La ram debe ser un numero: " + ips[i]);
                    }
                    else
                    {
                        Ordenador ordenador = new Ordenador();
                        ordenador.Nombre = "NONAME_" + ips[i];
                        try
                        {
                            ordenador.Ram = ramP;
                            ordenadores.Add(ip, ordenador);
                        }
                        catch (NegativeRAMException)
                        {
                            Console.WriteLine("La RAM no puede ser negativa: " + ips[i]);
                        }
                    }
                }
            }
        }

        public static void eliminarDato(Dictionary<String, Ordenador> ordenadores, string clave)
        {
            if (ordenadores.Remove(clave))
            {
                Console.WriteLine("exito");
            }
            else
            {
                Console.WriteLine("No ese ha eliminadoP");
            }

        }

        public static void mostrarElementos(Dictionary<String, Ordenador> ordenadores)
        {
            foreach (KeyValuePair<string, Ordenador> de in ordenadores)
            {
                Console.WriteLine("IP:{0} Nombre:{1} ", de.Key, de.Value.Nombre);
            }
        }

        public static void mostrarUnElemento(Dictionary<String, Ordenador> ordenadores, string clave)
        {
            if (ordenadores.ContainsKey(clave))
            {
                Ordenador o = ordenadores[clave];
                Console.WriteLine($"IP: {clave}  Nombre: {o.Nombre}  RAM: {o.Ram} ");
            }
            else
            {
                Console.WriteLine("No existe esa IP");
            }
        }
    }
}
