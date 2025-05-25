namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("number?   ");
            string strnumber = Console.ReadLine();
            int number = int.Parse(strnumber);
            switch (number)
            {
                case 0: Console.WriteLine("zere"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("dwo"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("for"); break;
                case 5: Console.WriteLine("fvie"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("sevrn"); break;
                case 8: Console.WriteLine("eiggt"); break;
                case 9: Console.WriteLine("nie"); break;

                default: Console.WriteLine("Invalid Input");break;
            
                
            }
            


        }
    }
}
