namespace T7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("number1?   ");
            string strnumber1 = Console.ReadLine();
            int number1 = int.Parse(strnumber1);
            int s = 0;

            while (number1 > 0)
            {
                int c = number1 % 10;
                s = s + c;
                number1 = number1 / 10;
            }
            Console.WriteLine(s);

        }
    }
}
