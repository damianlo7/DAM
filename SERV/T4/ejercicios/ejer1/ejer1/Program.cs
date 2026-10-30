using System.Numerics;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string directory;
            string separator;
            string fullName;




            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                directory = Environment.GetEnvironmentVariable("HOME");
                separator = "/";
            }
            else
            {
                directory = Environment.GetEnvironmentVariable("APPDATA");
                separator = "\\";
            }

            fullName = directory + separator + "cometas.txt";
            Console.WriteLine(fullName);

            //sr = new StreamReader(fullName);
            //line = sr.ReadLine();
            //while (line != null)
            //{

            //}


            List<Astro> astros = new List<Astro>();
            CargarAstros(astros, fullName);
            int option;
            bool flag = false;

            do
            {

                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1- Añade un planeta");
                Console.WriteLine("2- Añade cometa");
                Console.WriteLine("3- Mostrar datos");
                Console.WriteLine("4- Incrementa/decrementa");
                Console.WriteLine("5- Eliminar no terraformables");
                Console.WriteLine("6- Salir");


                flag = !int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6;


                switch (option)
                {
                    case 1:
                        anhadePlaneta(astros);
                        break;
                    case 2:
                        anhadeCometa(astros);
                        break;
                    case 3:
                        if (comprobarCol(astros))
                        {
                            Console.WriteLine("La coleccion es nula o esta vacia");
                        }
                        else
                        {
                            muestraColAstro(astros);
                        }

                        break;
                    case 4:
                        if (comprobarCol(astros))
                        {
                            Console.WriteLine("La coleccion es null o esta vacia");
                        }
                        else
                        {
                            IncreDecre(astros);
                        }

                        break;
                    case 5:
                        if (comprobarCol(astros))
                        {
                            Console.WriteLine("La coleccion es nulla o esta vacia");
                        }
                        else
                        {
                            eliminarNoTerraformables(astros);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("La opcion es incorrecta");
                        break;
                }

            } while (option != 6);
            guardarAstros(astros, fullName);
        }


        //Funcion que añade planeta

        //permite añadir el nombre, comprueba el radio que le da el usuario, en caso de pasar un radio negativo lanza excepcion,
        //en caso de pasar "strings" volvera a pedir el dato, en el caso de la peticion de si es gaseoso o no en caso de poner cualquier opcion no valida lo vuelve a pedir
        //

        static void anhadePlaneta(List<Astro> colAstros)
        {
            Planeta p = new Planeta();
            int option = 0;
            bool flag;
            double radio;
            string nombre;
            Console.WriteLine("***PLANETA***");
            nombre = pedirNombre();
            p.Nombre = nombre;


            radio = pedirRadio();
            p.Radio = radio;

            do
            {
                flag = false;
                Console.WriteLine("¿El planeta es gaseoso?");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");

                flag = !int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 2;
            } while (flag);

            p.Gaseoso = option == 1; //Gaseoso es true si option es igual a 1

            do
            {
                flag = false;
                Console.WriteLine("Escribe el numero de satelites que tiene: ");
                int numSatelites;
                try
                {
                    numSatelites = Convert.ToInt32(Console.ReadLine());
                    p.NumSat = numSatelites;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes escribir un numero entero");
                    flag = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Numero de satelites invalido");
                    flag = true;
                }
            } while (flag);
            colAstros.Add(p);
        }


        // Funcion que añade cometa 

        //(Revisar numeros negativos en radio)
        //permite añadir el nombre del cometa, comprueba el radio que le pasa el usuario, en este caso siempre que se le pase un "string" se lo vuelve a pedir al usuario, en caso de pasar un numero negativo vuelve al menu principal
        static void anhadeCometa(List<Astro> colAstros)
        {
            bool flag;
            string nombreCometa;
            Console.WriteLine("***COMETA***");
            nombreCometa = pedirNombre();
            //Console.WriteLine("\nEscribe el nombre del cometa:");
            //string nombreCometa = Console.ReadLine();

            double radioCometa;

            radioCometa = pedirRadio();

            Cometa c = new Cometa(nombreCometa, radioCometa);
            ITerraformable itr = c;
            colAstros.Add(c);
            //Console.WriteLine($"{c.Nombre} tiene radio: {c.Radio}, habitable?: {itr.esHabitable()}");

            //Console.WriteLine("Muestra coleccion: ");
            //muestraColAstro(colAstros);
        }





        //funcion que indica si el elemento de la coleccion  es terraformable o no
        //si es un COMETA muestra el nombre y si es PLANETA muestra lo que devuelve toString
        static void muestraColAstro(List<Astro> col)
        {
            foreach (Astro item in col)
            {

                string habitable;
                if (item is ITerraformable terraformable && terraformable.esHabitable())
                {
                    habitable = ($"{item.Nombre} es terraformable");
                }
                else
                {
                    habitable = ($"{item.Nombre} no es terraformable");
                }

                if (item is Cometa)
                {
                    Console.WriteLine("{0} es habitable?: {1}", item.Nombre, habitable);
                }
                else if (item is Planeta)
                {
                    Console.WriteLine("{0} ", item.ToString());
                }
            }
        }


        //Funcion para incremenar o decemenrar satelites
        //Pide el nombre del astro al usuario, si el nombre del astro es incorrecto vuelve al menu principal, en caso de seleccionar una opcion suma o resta astros segun lo seleccionado, 
        //en caso de tener 0 satelites y pulsar decrementar no hace nada y vuelve al menu principal 
        static void IncreDecre(List<Astro> col)
        {
            bool flag;
            int option;
            String nombre;

            int indice = -1;

            //Sin try/catch

            Console.WriteLine("Escribe el nombre del astro: ");
            nombre = Console.ReadLine();

            //indice = col.IndexOf(new Cometa(nombre, 1));


            if (col.IndexOf(new Cometa(nombre, 1)) == -1)
            {
                Console.WriteLine("No existe ese astro");
            }
            else if (col[indice] is Planeta planeta)
            {
                do
                {
                    flag = false;
                    Console.WriteLine("Elige una opcion: ");
                    Console.WriteLine("1- Incrementar satelites");
                    Console.WriteLine("2- Decrementar satelites");
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                planeta++;
                                break;
                            case 2:
                                planeta--;
                                break;
                            default:
                                Console.WriteLine("opcion no valida");
                                flag = true;
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Opcion no valida");
                        flag = true;
                    }
                    catch (ArgumentException)//Overflow
                    {
                        Console.WriteLine("El numero no es valido");
                        flag = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("El numero no es valido");
                        flag = true;
                    }
                }
                while (flag);

            }
            else
            {
                Console.WriteLine("El astro no es un planeta");
            }
        }

        static void eliminarNoTerraformables(List<Astro> col)
        {
            for (int i = col.Count - 1; i >= 0; i--)
            {
                bool habitable = (col[i] is ITerraformable t) && t.esHabitable();
                if (!habitable)
                {
                    col.RemoveAt(i);
                }
            }
        }

        static bool comprobarCol(List<Astro> col)
        {

            return col == null || col.Count == 0;
        }

        static double pedirRadio()
        {
            double radio;
            bool flag;
            do
            {
                flag = false;
                Console.WriteLine("Escribe el radio: ");
                string leerRadio = Console.ReadLine();

                if (!(double.TryParse(leerRadio, out radio) && radio > 0))
                {
                    flag = true;
                }

            } while (flag);
            return radio;
        }


        static String pedirNombre()
        {
            bool flag;
            string nombre;
            do
            {
                flag = false;
                Console.WriteLine("Escribe el nombre que deseas poner: ");
                nombre = Console.ReadLine();
                if (nombre == null || nombre == "")
                {
                    flag = true;
                    Console.WriteLine("Debes introducir un nombre valido");
                }

            }
            while (flag);
            return nombre;


        }

        static void guardarAstros(List<Astro> col, string ruta)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    foreach (Astro a in col)
                    {
                        if (a is Planeta)
                        {
                            Planeta p = (Planeta)a;
                            sw.WriteLine($"PLANETA;{a.Nombre};{p.Radio};{p.Gaseoso};{p.NumSat}");
                        }
                        else if (a is Cometa)
                        {
                            Cometa c = (Cometa)a;
                            sw.WriteLine($"COMETA;{c.Nombre};{c.Radio}");
                        }

                    }
                }
            }
            catch (IOException e)//TODO excepcion genérica no
            {
                Console.WriteLine("Error al guardar lso datos?");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("No tienes permisos para acceder al archivo");
            }
        }

        static void CargarAstros(List<Astro> col, string ruta)
        {
            if (File.Exists(ruta))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(linea))
                            {
                                string[] datos = linea.Split(';');
                                string tipo = datos[0];
                                if (tipo == "PLANETA" && datos.Length >= 5)
                                {
                                    string nombre = datos[1];
                                    if (double.TryParse(datos[2], out double radio) && (bool.TryParse(datos[3], out bool gaseoso) && (int.TryParse(datos[4], out int numSat))))//TODO comprobacion de tipos
                                    {
                                        Planeta p = new Planeta(gaseoso, numSat, nombre, radio);
                                        col.Add(p);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hay datos invalidos");
                                    }

                                    //double radio = Convert.ToDouble(datos[2]);
                                    //bool gaseoso = Convert.ToBoolean(datos[3]);
                                    //int numSat = Convert.ToInt32(datos[4]);

                                }
                                else if (tipo == "COMETA" && datos.Length >= 3)
                                {
                                    string nombre = datos[1];
                                    if (double.TryParse(datos[2], out double radio))
                                    {
                                            Cometa c = new Cometa(nombre, radio);
                                    col.Add(c);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hay datos erroneos");
                                    }
                                    //double radio = Convert.ToDouble(datos[2]);
                                }
                            }
                        }
                    }
                }
                catch (IOException ex)//TODO excepcion genérica no
                {
                    Console.WriteLine("Error en el archivo");
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("No tienes permisos para modificar este archivo");
                }
            }
        }


    }
}