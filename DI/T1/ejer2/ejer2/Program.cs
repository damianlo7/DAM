namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe tu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nombre: {0,12} Edad: {1,4} \n\tPeso: {2,5:F1} \n\"{0}\" \\{1}\\", nombre, edad, peso);

        }
    }
}
