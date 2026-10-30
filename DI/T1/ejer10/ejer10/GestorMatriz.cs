using System;
using System.Collections.Generic;
using System.Text;

namespace ejer10
{
    internal class GestorMatriz
    {
        public int[,] Matriz { set; get; }

        public GestorMatriz(int nFilas, int nColumnas)
        {
            Random random = new Random();
            Matriz = new int[nFilas, nColumnas];

            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nColumnas; j++)
                {
                    Matriz[i, j] = random.Next(-5, 21);
                }
            }

        }

        //CONSTRUCTOR SOBRECARGADO DEL ANTERIROR
        public GestorMatriz() : this(3, 4)
        {
        }

        public (int, bool) SumaFila(int fila)
        {
            int suma = 0;
            if (fila < 0 || fila >= Matriz.GetLength(0))
            {
                return (0, false);

            }
            else
            {
                for (int i = 0; i < Matriz.GetLength(1); i++)
                {
                    suma += Matriz[fila, i];
                }
            }

            return (suma, true);
        }

        public bool SumaColumna(int columna, out int resultado)
        {
            resultado = 0;

            if (columna < 0 || columna >= Matriz.GetLength(1))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    resultado += Matriz[i, columna];
                }

                return true;
            }
        }

        public double[,] SumaMatriz(object obj)
        {
            double[,] aux;

            switch (obj)
            {
                case int[,] i:
                    aux = ConvertirADouble(i);
                    break;
                case double[,] d:
                    aux = d;
                    break;
                case GestorMatriz g:
                    aux = ConvertirADouble(g.Matriz);
                    break;
                default:
                    throw new MatrizException();


            }
            int filasM = Matriz.GetLength(0);
            int columnasM = Matriz.GetLength(1);

            if (aux.GetLength(0) != filasM || aux.GetLength(1) != columnasM)
            {
                throw new MatrizException();
            }

            double[,] resultado = new double[filasM, columnasM];
            for (int i = 0; i < filasM; i++)
            {
                for (int j = 0; j < columnasM; j++)
                {
                    resultado[i, j] = Matriz[i, j] + aux[i, j];
                }
            }

            return resultado;

        }

        public static double[,] ConvertirADouble(int[,] arrayInt)
        {
            double[,] parse = new double[arrayInt.GetLength(0), arrayInt.GetLength(1)];
            for (int i = 0; i < arrayInt.GetLength(0); i++)
            {
                for (int j = 0; j < arrayInt.GetLength(1); j++)
                {
                    parse[i, j] = arrayInt[i, j];
                }
            }
            return parse;
        }

        public double[] Medias(bool flag)
        {
            int cont = 0;
            double[] medias;
            double suma = 0;

            switch (flag)//if-else
            {
                case true: //filas
                    medias = new double[Matriz.GetLength(0)];
                   // suma = 0;
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        suma = 0;
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            suma += Matriz[i, j];
                        }
                        medias[i] = suma / Matriz.GetLength(1);
                    }
                    break;

                case false: //columnas
                    medias = new double[Matriz.GetLength(1)];
                   // suma = 0;

                    for (int i = 0; i < Matriz.GetLength(1); i++)
                    {
                        suma = 0;
                        for (int j = 0; j < Matriz.GetLength(0); j++)
                        {
                            suma += Matriz[j, i];
                        }
                        medias[i] = suma / Matriz.GetLength(0);
                    }
                    break;
                default:
                    break;

            }

            return medias;
        }

        public static void MostrarMatriz<T>(T[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.Write($"{"",5}");
            for (int i = 0; i < columnas; i++)
            {
                Console.Write($"{(char)('A' + i),5}");
            }
            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                Console.Write($"{i + 1,5}");

                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }
                Console.WriteLine();
            }
        }


    }
}
