namespace pripravaNaTest
{
    internal class Program
    {

        static int hodKostkou1, hodKostkou2, hodKostkou3;
        static double prumerHrac1, prumerHrac2;
        static int skoreHrac1, skoreHrac2;
        static Random r = new Random();

        static int SpocitejSoucetHodu(int hod1, int hod2, int hod3)
        {

            int soucet = hod1 + hod2 + hod3;

            return soucet;
        }

        static double SpocitejPrumerHodu(int hod1, int hod2, int hod3)
        {

            double soucet = (hod1 + hod2 + hod3) / 3.0;

            return soucet;

        }

        static int VygenerujNahodneCislo(int from, int to)
        {
            return r.Next(from, to);
        }

        static void UrciViteze(int skoreA, int skoreB)
        {

            if (skoreA > skoreB)
            {
                Console.WriteLine("Vítěj je hráč A se skore " + skoreA + ", průměrem " + prumerHrac1 + ".");
            }
            else if (skoreA < skoreB)
            {
                Console.WriteLine("Vítěj je hráč B se skore " + skoreB + ", průměren " + prumerHrac2 + ".");
            }
            else
            {
                Console.WriteLine("Hra skončila remízou se skore " + skoreA + ", průměrem " + prumerHrac1 + ".");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Pro zahájení hry napiště - start");

            while (true)
            {

                if (Console.ReadLine().Contains("start"))
                {

                    Console.WriteLine(""); 

                    Console.WriteLine("Házím kostkou pro hráče A..");
                    hodKostkou1 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč A hodil prvním hodem " + hodKostkou1 + ".");
                    hodKostkou2 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč A hodil druhým hodem " + hodKostkou2 + ".");
                    hodKostkou3 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč A hodil třetím hodem " + hodKostkou3 + ".");
                    skoreHrac1 = SpocitejSoucetHodu(hodKostkou1, hodKostkou2, hodKostkou3);
                    prumerHrac1 = SpocitejPrumerHodu(hodKostkou1, hodKostkou2, hodKostkou3);

                    Console.WriteLine(""); 

                    Console.WriteLine("Házím kostkou pro hráče B..");
                    hodKostkou1 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč B hodil prvním hodem " + hodKostkou1 + ".");
                    hodKostkou2 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč B hodil druhým hodem " + hodKostkou1 + ".");
                    hodKostkou3 = VygenerujNahodneCislo(1, 6);
                    Console.WriteLine("Hráč B hodil třetím hodem " + hodKostkou1 + ".");
                    skoreHrac2 = SpocitejSoucetHodu(hodKostkou1, hodKostkou2, hodKostkou3);
                    prumerHrac2 = SpocitejPrumerHodu(hodKostkou1, hodKostkou2, hodKostkou3);

                    Console.WriteLine(""); 

                    UrciViteze(skoreHrac1, skoreHrac2);






                }

            }
        }
    }
}
