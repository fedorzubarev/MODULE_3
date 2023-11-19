namespace MODULE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            const string ConstName = "Fedor_Const";
            myName = "Fedor";
            byte MyAge = 27;
            bool HavePet = true;
            double MyShoeSize = 37.5;
            Console.WriteLine("myName name is {0}", myName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do I have a pet? {0}", HavePet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);

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