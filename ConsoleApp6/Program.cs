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
            DateTime dm = new DateTime(2023,09,01);
            DateTime dm2 = new DateTime(1995,10,11);
            TimeSpan ts5 = dm - dm2;
            Console.WriteLine(ts5);
            Console.WriteLine();
            Console.WriteLine(dm2);
            var dm3 = dm2.AddDays(100);
            Console.WriteLine(dm>dm2);
            Console.WriteLine(dm3);

            var dim =  DateTime.DaysInMonth(2016,02);
            var dim2 =  DateTime.IsLeapYear(2024); /*szökőév*/
            var dim3 =  DateTime.MinValue; /*minérték ami megadható*/
            var dim4 =  DateTime.Parse("2000-03-16"); 
 

            Console.WriteLine(dim);
            Console.WriteLine(dim2);
            Console.WriteLine(dim3);
            Console.WriteLine(dim4);
            Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            for (DateTime d = new DateTime(2023,09,07); d <= DateTime.Parse("2024-06-15") ; d= d.AddDays(7))
            {
                Console.WriteLine(d);
            }
            




            Console.ReadLine();


        }
    }
}
