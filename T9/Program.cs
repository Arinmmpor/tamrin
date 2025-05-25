namespace T9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("name?   ");
            string strname = Console.ReadLine();
            

            Console.Write("NomrhRiaze?   ");
            string strRiaze = Console.ReadLine();
            int Riaze = int.Parse(strRiaze);

            Console.Write("NomrhAlvm?   ");
            string strAlvm = Console.ReadLine();
            int Alvm = int.Parse(strAlvm);

            Console.Write("NomrhArbe");
            string strArbe = Console.ReadLine();
            int Arbe = int.Parse(strArbe);

            int Madel;


            Madel = (Riaze + Alvm + Arbe);
            Console.WriteLine(Madel);
                Madel=Madel / 3;
             Console.WriteLine(Madel);

                        
           

        }
    }
}
