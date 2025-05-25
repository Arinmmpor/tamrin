namespace T10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numberMah?   ");
            string srtnumberMah = Console.ReadLine();
            int number = int.Parse(srtnumberMah);
          
            if (number > 12)
            {
                Console.Write("no ");
            }
            else
            {
                Console.Write("yes");
            }




            switch (number)
            {
                case 1:Console.WriteLine("frvordin");break;
                case 2:Console.WriteLine("Ardibhst");break;
                case 3:Console.WriteLine("Khrdadd");break;
                case 4:Console.WriteLine("Ter");break;
                case 5:Console.WriteLine("Mrdad");break;
                case 6:Console.WriteLine("Shrivr");break;
                case 7:Console.WriteLine("Mhr");break;
                case 8:Console.WriteLine("Aban");break;
                case 9:Console.WriteLine("Azr");break;
                case 10:Console.WriteLine("Dy");break;
                case 11:Console.WriteLine("Bhmn");break;
                case 12:Console.WriteLine("Asfnd");break;
                default:Console.Write("-----");break;

            }







        }
    }
}
