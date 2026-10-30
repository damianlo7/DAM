namespace ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Planeta p = new Planeta();


            //Constructor con parametros
            Planeta vegetta = new Planeta(true, 7, "vegetta", 777);
            Planeta willy = new Planeta(false, 3, "willy", 3000);

            Console.WriteLine("Planeta del constructor: " + vegetta);
            Console.WriteLine("Planeta del constructor: " + willy);

            //Comprobacion habitable

            Console.WriteLine($"{vegetta.Nombre} Es habitable?:  {vegetta.esHabitable()}");
            Console.WriteLine($"{willy.Nombre} Es habitable?:  {willy.esHabitable()}");


            //Operadores
            Planeta Ope = new Planeta();
            Ope++;
            Console.WriteLine("Satelites tras sumar: " + Ope.NumSat);
            Ope--;
            Console.WriteLine("Satelites tras restar: " + Ope.NumSat);
            Ope--;
            Console.WriteLine("Satelites tras volver a restar: " + Ope.NumSat);// no puede dar negativo 

            //equals
            Planeta vegetta2 = new Planeta(false, 1, "vegetta", 666);
            Console.WriteLine("ejemplo true: " + vegetta.Equals(vegetta2));
            Console.WriteLine("ejemplo false: " + vegetta.Equals(willy));


            int option;

            Console.WriteLine("Escribe el nombre del planeta");
            string nombre = Console.ReadLine();
            p.Nombre = nombre;

            Console.WriteLine("Escribe el radio del planeta: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            try
            {
                p.Radio = radio;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Radio invalido: " + e.Message);
            }

            Console.WriteLine("¿El planeta es gaseoso?");
            Console.WriteLine("1- Si");
            Console.WriteLine("2- No");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    p.Gaseoso = true;
                    break;
                case 2:
                    p.Gaseoso = false;
                    break;
                default:
                    break;
            }


            Console.WriteLine("Escribe el numero de satelites que tiene: ");
            int numSatelites = Convert.ToInt32(Console.ReadLine());
            p.NumSat = numSatelites;

            Console.WriteLine($"\nResultado: Nombre: {p.Nombre}, radio: {p.Radio}, es gaseoso?: {p.Gaseoso}, numero de satelites: {p.NumSat}");

            Console.WriteLine("\nEscribe el nombre del cometa:");
            string nombreCometa = Console.ReadLine();

            Console.WriteLine("\nEscribe el radio del cometa:");
            double radioCometa = Convert.ToDouble(Console.ReadLine());

            try
            {
                Cometa c = new Cometa(nombreCometa, radioCometa);
                ITerraformable itr = new Cometa(nombreCometa,radio);

                Console.WriteLine($"{c.Nombre} tiene radio: {c.Radio}, habitable?: {itr.esHabitable()}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Radio invalido");
            }
            
        }
    }
}
