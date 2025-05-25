namespace T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number?  ");
            string strnumber = Console.ReadLine();
            int number = int.Parse(strnumber);

            if (number % 2 == 0)
            {
                Console.WriteLine("Zoj");
            }
            else
            {
                Console.WriteLine("Frd");
            }




        }
    }
}
