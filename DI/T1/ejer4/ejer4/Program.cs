using System.ComponentModel.Design;

namespace ejer4
{
    internal class Program
    {
        int num;
        static void Main(string[] args)
        {
            menu();
        }



        public static void menu()
        {
            Program p = new Program();
            int option = 0;
            int anho;
            int num1;
            int num2;


            try
            {
                while (option != 4)
                {
                    Console.WriteLine("Elige una opcion: ");
                    Console.WriteLine("1- Año bisiesto ");
                    Console.WriteLine("2- Suma de rango");
                    Console.WriteLine("3- Opcion 1 y 2");
                    Console.WriteLine("4- Salir");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                           
                                anho = p.pedirNumeros();
                    

                            if (!p.anhoBisiesto(anho) ) //Indicar aqui si es o no bisiesto
                            {
                                Console.WriteLine("El año no es bisiesto");
                            }
                            else
                            {
                                Console.WriteLine("El año es bisiesto");
                            }


                            if (option == 3)
                            {
                                goto case 2;
                            }
                            break;
                        case 2:

                            num1 = p.pedirNumeros();
                            num2 = p.pedirNumeros();

                            int? res = p.sumaRangos(num1, num2);

                            //p.sumaRangos(num1, num2);//Aqui el mensaje de null y llamar solo una vez a la función
                            if (res == null)
                            {
                                Console.WriteLine("El numero 1 no puede ser superior al 2");
                            }
                            else
                            {
                                Console.WriteLine("El resultado es: " + res);
                            }
                            break;
                        case 3:
                            goto case 1;

                        case 4:
                            Console.WriteLine("Hasta la proxima");
                            break;
                        default:
                            break;

                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Algun valor no es numerico");

            }


        }


        //un año bisiesto es divisible 4, si es divisible entre 100 deja de ser bisiesto a
        //no ser que a demas sea divisible entre 400

        public bool anhoBisiesto(int an)
        {
            if (an % 400 == 0 || an % 4 == 0 && an % 100 != 0)
            {
                //Console.WriteLine("El año es bisiesto");
                return true;
            }
            else
            {
                //Console.WriteLine("El año no es bisiesto");
                return false;
            }
        }

        public int? sumaRangos(int n1, int n2) // mostrar resultado de la funcion pero en la funcion dice devolver no mostrar
        {
            int cont = 0;
            if (n1 > n2)
            {
                //Console.WriteLine("El numero 1 no puede ser superior al 2");
                return null;
            }
            else
            {
                for (int i = n1; i <= n2; i++)
                {
                    cont += i;
                }
                //Console.WriteLine(cont);
                return cont;
            }

        }


        public int pedirNumeros()
        {
            try
            {
                do
                {
                    Console.WriteLine("Escribe un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num<0)
                    {
                        Console.Write("Los numeros no pueden ser negativos\n");
                    }
                }
                while (num < 0 || num > 10000);
            }
            catch (FormatException)
            {
                Console.WriteLine("Algun valor no es numerico");
            }
            return num;
        }

    }
}
