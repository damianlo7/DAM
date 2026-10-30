namespace TemaArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory;
            string separator;
            string fullName;
            StreamWriter s;
            // If only use Windows, you don’t need to do this
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                directory = Environment.GetEnvironmentVariable("HOME");
                separator = "/";
            }
            else
            {
                directory = Environment.GetEnvironmentVariable("homepath");
                separator = "\\";
            }
            fullName = directory + separator + "testfile.txt";
            // Open File
            s = new StreamWriter(fullName);
            // Write File
            for (int i = 1; i <= 10; i++)
            {
                s.Write("{0,-2}", i);
            }
            s.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                s.WriteLine($"Line :{i,3}");
            }
            // Close File. Needs try-catch.
            s.Close();

        }
    }
}
