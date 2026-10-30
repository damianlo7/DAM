namespace ejer10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GestorMatriz gm = new GestorMatriz();
            int option;

            do
            {
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("1- Mostrar tabla");
                Console.WriteLine("2- Mostrar medias");
                Console.WriteLine("3- Mostrar suma de una columna");
                Console.WriteLine("4- Mostrar suma de una fila");
                Console.WriteLine("5- Incremento aleatorio");
                Console.WriteLine("6- Cambiar Matriz");
                Console.WriteLine("7- Salir");


                option = int.Parse(Console.ReadLine());



                switch (option)
                {
                    case 1:
                        GestorMatriz.MostrarMatriz(gm.Matriz);
                        break;
                    case 2:
                        Console.WriteLine("Escoge una opcion: ");
                        Console.WriteLine("1- Media de las filas");
                        Console.WriteLine("2- Media de las columnas");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                double[] mediaFilas = gm.Medias(true);
                                for (int i = 0; i < mediaFilas.Length; i++)
                                {
                                    Console.WriteLine("Media Filas: "+ mediaFilas[i]);
                                }
                                break;
                            case 2:
                                double[]mediaColumnas = gm.Medias(false);
                                for (int i = 0; i < mediaColumnas.Length; i++)
                                {
                                    Console.WriteLine("Media columnas: {0:F3}", mediaColumnas[i]);
                                }
                                break;
                        }
                        break;
                    case 3:
                        int fila;
                        Console.WriteLine("Escribe el numero de fila: ");
                        fila = int.Parse(Console.ReadLine());
                        Console.WriteLine(gm.SumaFila(fila));
                        
                        break;
                    case 4:
                        int columna;
                        int res;
                        Console.WriteLine("Escribe el numero de columna: ");
                        columna = int.Parse(Console.ReadLine());
                        gm.SumaColumna(columna, out res);
                        break;
                    case 5:
                        double[,] aleatoria = new double[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];
                        Random generador = new Random();
                        for (int i = 0; i < aleatoria.GetLength(0); i++)
                        {
                            for (int j = 0; j < aleatoria.GetLength(1); j++)
                            {
                                aleatoria[i, j] = (generador.NextDouble() * 9 + 1);
                            }
                        }
                        //crear matriz aux para guardar resultado
                        double[,] aux = new double[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];
                        gm.SumaMatriz(aleatoria);
                        GestorMatriz.MostrarMatriz(aleatoria);
                        GestorMatriz.MostrarMatriz(aleatoria);
                        //GestorMatriz.MostrarMatriz(resultado);


                        break;
                    case 6:
                        int filas;
                        int columnas;
                        Console.WriteLine("Escribe el numero de filas que quieres:");
                        filas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el numero de columas que quieres:");
                        columnas = int.Parse(Console.ReadLine());
                        if (filas > 0 && columnas > 0)
                        {
                            gm = new GestorMatriz(filas, columnas);
                        }
                        else
                        {
                            Console.WriteLine("las filas y las columnas no pueden ser menores a 0");
                        }

                        //double[,]nueva = new double[filas, columnas];


                        break;
                    case 7:
                        Console.WriteLine("Hasta luego");
                        break;
                    default:
                        break;
                }


            }
            while (option != 7);

        }
    }
}
