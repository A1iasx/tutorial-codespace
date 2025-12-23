using System.Configuration.Assemblies;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // format string ! 
            const float Pi = 3.14f; // cannot change it
            Pi = 1;
            System.Console.WriteLine(Pi);
        }
    }
}