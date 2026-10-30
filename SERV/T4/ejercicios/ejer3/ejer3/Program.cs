namespace ejer3
{
    internal class Program
    {
        public delegate double Delegado(double param);

        public static void programa()
        {
            double num;
            int option;
            Console.WriteLine("Escribe un numero: ");
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Valor no valido");
            }


            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine("1- El cuadrado del numero");
            Console.WriteLine("2- El cubo del numero");

            while (!int.TryParse(Console.ReadLine(), out option) || option != 1 && option != 2)
            {
                Console.WriteLine("Opcion no valida, elige otra opcion: ");
                Console.WriteLine("1- El cuadrado del numero");
                Console.WriteLine("2- El cubo del numero");
            }

            Delegado delegado = null;


            switch (option)
            {
                case 1:
                    delegado = i => i * i;
                    break;
                case 2:
                    delegado = i => i * i * i;
                    break;
            }
            double resultado = delegado(num);
            Console.WriteLine($"Resultado: {resultado}");
        }
        static void Main(string[] args)
        {
            programa();
        }
    }
}
