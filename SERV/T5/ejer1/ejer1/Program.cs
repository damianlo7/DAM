namespace ejer1
{
    internal class Program
    {


        static bool flag = true;
        static readonly object l = new object();
        static int i = 0;

        static void sumar()
        {
            while (flag)
            {
                lock (l)
                {
                    if (flag)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write($"{i:D4} ");
                        i++;
                        if (i >= 500 || i <= -500)
                        {
                            flag = false;
                        }
                    }
                }
            }
        }
        static void restar()
        {
            while (flag)
            {
                lock (l)
                {
                    if (flag)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        //Console.Write($" {i, 4} ");
                        Console.Write($"{i:D4} ");

                        i--;
                        if (i >= 500 || i <= -500)
                        {
                            flag = false;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(sumar);
            Thread thread1 = new Thread(restar);
            thread.Start();
            thread1.Start();
            thread.Join();
            thread1.Join();

            if (i >= 500)
            {
                Console.WriteLine("\nGano Thread 1 (Sumar)");
            }
            else if (i <= -500)
            {
                Console.WriteLine("\nGano Thread 2 (Restar)");
            }

        }
    }
}
