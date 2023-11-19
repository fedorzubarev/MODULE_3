namespace MODULE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            const string ConstName = "Fedor_Const";
            myName = "Fedor";

            Console.WriteLine(myName);
            Console.WriteLine(ConstName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\t\tМне 27 лет");
            Console.WriteLine("My name is \nJane");
            Console.WriteLine("Привет,\n мир");
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(5);
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            //          Console.ReadKey();
        }
    }
}