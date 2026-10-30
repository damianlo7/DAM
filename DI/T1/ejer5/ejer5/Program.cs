//#define PRUEBA
namespace ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int resultado = 0;
            int num;
#if PRUEBA
            Console.WriteLine("De que numero quieres el factorial?: ");
            num = Convert.ToInt32(Console.ReadLine());
            p.factorial(num, ref resultado);
            Console.WriteLine("Resultado: "+resultado);
            // Faltan resultados
#else
            Console.WriteLine("Cuantos asteriscos quieres poner?:");
            string aux = Console.ReadLine();
            if (aux == null || aux == "")
            {
                p.imprimeAsteriscos();
            }
            else
            {
                int cAst = Convert.ToInt32(aux);
                p.imprimeAsteriscos(cAst);
                Console.ReadLine();
            }

#endif
        }



        // Se calcula multiplicando todos los numeros desde el 1 hasta ese numero
        public bool factorial(int num, ref int resultado) //separar peticion de datos de interfaz de usuario, el resultado no se muestra en esta funcion
        {
            if (num < 0 || num > 10)
            {
                return false;
            }
            else
            {
                resultado = 1;
                for (int i = 1; i <= num; i++)
                {
                    resultado *= i;
                }
                //       Console.WriteLine(resultado.ToString());
                return true;
            }

        }

        public void imprimeAsteriscos(int cant = 10)//Parametro opcional
        {
            Random rand = new Random();
            for (int i = 0; i < cant; i++)
            {
                Console.SetCursorPosition(rand.Next(1, 20), rand.Next(1, 10));

                Console.WriteLine("*");
            }

        }
    }
}
