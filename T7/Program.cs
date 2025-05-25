namespace T7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("number2?   ");
            string strnumber1 = Console.ReadLine();
            int number1 = int.Parse(strnumber1);

            Console.Write("number2?   ");
            string strnumber2 = Console.ReadLine();
            int number2 = int.Parse(strnumber2);

            int c;
            c = number1 + number2;

            Console.WriteLine(c);

        }   
    }
}
