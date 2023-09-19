using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Int32 x = new Int32();



            //eltelt idő
            TimeSpan ts01 = new TimeSpan(06, 30, 22);
            TimeSpan ts02 = new TimeSpan(02, 30, 22);
            TimeSpan ts03 = TimeSpan.Parse("4.10:01:10.101013");
            TimeSpan ts04 = TimeSpan.FromMilliseconds(1231245125.0);
            double tb = ts01.TotalHours;

            Console.WriteLine(ts01);
            Console.WriteLine(ts03);
            Console.WriteLine(ts04);
            Console.WriteLine(ts01.Hours);
            Console.WriteLine(x);
            Console.WriteLine();



            //dátum-idő tárolására való
            DateTime dm = new DateTime(1930, 10, 22);

            Console.WriteLine(dm);
            Console.WriteLine(dm.ToString("yyyy"));






        }
    }
}
