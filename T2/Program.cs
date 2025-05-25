namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("nuber?  ");
            string strnumber = Console.ReadLine();
            int number=int.Parse(strnumber);

            if (number < 10)
            {
                Console.Write("Good Bte World ");
                
            }
            else
            {
                Console.Write("Hello World");
                
            }



        }
    }
}
