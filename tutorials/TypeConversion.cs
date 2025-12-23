namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte");
            }
            
        }
    }
}