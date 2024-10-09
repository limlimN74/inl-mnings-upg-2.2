using System;
using System.Web;
namespace inlämnings_upg_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar elin//
            Console.WriteLine("Hur långt hoppade Elin? ");
            string lägndtext1= Console.ReadLine();
            double lägnd1= double.Parse(lägndtext1 );

            //Frågar Alma//
            Console.WriteLine("Hur lågnt hoppade Alma? ");
            string lägndtext2= Console.ReadLine();
            double lägnd2=double.Parse(lägndtext2 );

            //Skillnad//
            double skillnad = lägnd1 - lägnd2;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre");
        }
    }
}
