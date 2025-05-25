namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("number?   ");
            string strnumber = Console.ReadLine();
            int number = int.Parse(strnumber);

            if (number < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

        }
    }
}
