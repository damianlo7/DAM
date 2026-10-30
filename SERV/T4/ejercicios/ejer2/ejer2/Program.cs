using System.Timers;

namespace ejer2
{
    internal class Program//TODO   
                          // No IndexOutOfRangeException
                          // cat overflow




    {

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("No se paso ningun comando, las opciones posibles son: \ntool ls\ntool cat\ntool newfile");
                }
                else
                {
                    // se le pase el directorio y muestra su contenido, subdirectorios y archivos

                    //D:\2026-27\SERV\T1\ejercicios\ejer2\ejer2\bin\Debug\net10.0\ejer2.exe ls %appdata%
                    if (args[0] == "ls")
                    {
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Falta el directorio");
                        }
                        else
                        {
                            DirectoryInfo directory = new DirectoryInfo(args[1]);
                            //Console.WriteLine("Se eligio ls");
                            Console.WriteLine(args[1]);

                            Console.WriteLine("DIRECTORIOS");

                            foreach (var sub in directory.GetDirectories())
                            {
                                Console.WriteLine(sub.Name);
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("ARCHIVOS");
                            foreach (var files in directory.GetFiles())
                            {
                                Console.WriteLine($" {files.Name,20} Tamaño: {files.Length} bytes");
                            }
                            Console.ResetColor();
                        }


                    }
                    //Se le pasa un archivo y muestra el contenido, si tiene el parametro "-n" con un numero pegado ese sera el numero de lineas que mostrara

                    //D:\2026-27\SERV\T1\ejercicios\ejer2\ejer2\bin\Debug\net10.0\ejer2.exe cat C:\Users\dloppin\Desktop\textoPruebas.txt
                    else if (args[0] == "cat" && args.Length >= 2 && args[1].StartsWith("-n"))
                    {
                        if (args.Length < 3)
                        {
                            Console.WriteLine("Falta el archivo");
                        }
                        else
                        {
                            int n = int.Parse(args[1].Substring(2));
                            string[] lineas = File.ReadAllLines(args[2]);

                            for (int i = 0; i < n && i < lineas.Length; i++)
                            {
                                Console.WriteLine(lineas[i]);
                            }
                        }

                    }
                    else if (args[0] == "cat")
                    {
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Falta el archivo");
                        }
                        else
                        {
                            string file = File.ReadAllText(args[1]);
                            Console.WriteLine(file);
                        }


                    }
                    //D:\2026 - 27\SERV\T1\ejercicios\ejer2\ejer2\bin\Debug\net10.0\ejer2.exe newfile anhadirTexto.txt alcachofa con tortilla de patatas estofada, pruebo a añadir este trozo


                    //debe añadir en el archivo todo lo puesto posteriormente
                    else if (args[0] == "newfile" && args.Length >= 2 && args[1] == "-a")
                    {
                        if (args.Length < 3)
                        {
                            Console.WriteLine("Falta el nombre del archivo");
                        }
                        else
                        {
                            String frase = "";

                            for (int i = 3; i < args.Length; i++)
                            {
                                frase += args[i] + " ";
                            }
                            File.AppendAllText(args[2], frase + "\n");
                        }

                    }

                    //D:\2026-27\SERV\T1\ejercicios\ejer2\ejer2\bin\Debug\net10.0\ejer2.exe newfile anhadirTexto.txt alcachofa con tortilla de patatas estofada
                    else if (args[0] == "newfile")
                    {
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Falta el nombre del archivo");
                        }
                        else
                        {
                            String frase = "";
                            for (int i = 2; i < args.Length; i++)
                            {
                                frase += args[i] + " ";
                            }
                            if (File.Exists(args[1]))
                            {
                                Console.WriteLine("El archivo ya existia");
                            }
                            File.WriteAllText(args[1], frase);
                        }


                    }
                    else
                    {
                        Console.WriteLine("El comando no existe");
                    }
                }
            }
            //catch (IndexOutOfRangeException e) //No controlar salidas de indices con try, siempre con if
            //{
            //    Console.WriteLine("Faltan parametros");
            //}
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontro el archivo");
            }
            catch (IOException)
            {
                Console.WriteLine("No existe o no se encuentra el directorio o archivo indicado");
            }
            catch (FormatException)
            {
                Console.WriteLine("Faltan parametros, tras -n debe ir un numero sin espacios");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tienes permisos");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Se puso un argumento no valido");
            }


            //1ºif funciona 
            //2º necesito como saber el numero tras -n 
            //3º funciona
            //4º "Funciona" pero pone cada palabra con un salto de linea
            //5º tambien necesito que coja todas las palabras y no solo la primera pasada
            //tool newfile -a C:\Users\dloppin\Desktop\textoPruebas.txt lalala


            //Proyecto//ejer2 Propiedades//Depurar//Abrir la interfaz de perfiles...


            //cat C:\Users\dloppin\Desktop\textoPruebs.txt
        }
    }
}
