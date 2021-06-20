using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Geek_Brains
{
    
    public enum Winterrr
    {
        January=1 ,
        February=2,
        April=3,
        March=4,

    }


    public enum Month
    {


        decemder = 0b_000_000_000_100,
        January = 0b_000_000_000_001,
        february = 0b_000_000_001_000,
        marc = 0b_000_000_010_000,
        april = 0b_000_000_100_000,
        may = 0b_000_001_000_000,
        june = 0b_000_010_000_000,
        july = 0b_000_100_000_000,
        agust = 0b_001_000_000_000,
        september = 0b_010_000_000_000,
        october = 0b_100_000_000_000,
        novemder = 0b_000_000_000_010,
    }
    [Flags]
    public  enum DayofWorking
    {
      
        Monday      =0b_000_0001,
        Tuesday     =0b_000_0010,
        Wednesday=   0b_000_0100, 
        Thursday=    0b_000_1000, 
        Friday =     0b_001_0000,
        Saturday    =0b_010_0000,
        Sunday =     0b_100_0000
    }
       
       class Program
    {
        static void Main(string[] args)
        {
          

            
        
            //задание 5

            Console.WriteLine("ввидите пору года");
            string a = Console.ReadLine();
            string a1 = "jenuary";
            string a2 = "december";
            string a3 = "febreuary";
            Console.WriteLine("Ввидите температуру ");
            int b = Convert.ToInt32(Console.ReadLine());

           
            

           
            bool isWinter = a == a3;
            bool isWinter1 = a == a2;
            bool isWinter2 = a == a1;
            bool isWinter3 = isWinter || isWinter1 || isWinter2;



            if (isWinter3&&b>0)
            {
                Console.WriteLine("Дождливая зима Зима");
            }
            else
            {
                Console.WriteLine(  "Не ту такой поры ");
            }


            //тут пытался через битовые маски но похходу не доконца их понял

            Month allSeason = (Month)0b111111111111;

            //маски пор года 
            int Winter = 0b000000001101;
            int Spring = 0b000001110000;
            int Summer = 0b001110000000;
            int Othum = 0b110000000010;

            //еще одни маски пор года 
            Month monthSeasonWinter = Month.decemder | Month.January | Month.february;
            Month monthSeasonSpring = Month.marc | Month.april | Month.may;
            Month monthSeasonSummer = Month.june | Month.july | Month.agust;
            Month monthSeasonOthum = Month.september | Month.october | Month.novemder;

            //сравниваем наши поры года

            Month monthWinter = monthSeasonWinter & allSeason;
            Month monthSpring = monthSeasonSpring & allSeason;
            Month monthSummer = monthSeasonSummer & allSeason;
            Month monthOuthum = monthSeasonOthum & allSeason;

            //теперь первщает все в логический бооол
            bool ifWinter = monthWinter == monthSeasonWinter;
            bool ifSpring = monthSpring == monthSeasonSpring;
            bool ifSummer = monthSummer == monthSeasonSummer;
            bool ifOuthum = monthOuthum == monthSeasonOthum;

            Console.WriteLine("ВВидите пору года");
            string aa1 = Console.ReadLine();


            ////те поры года которые есть
            //int seasonWinter = Winter & allSeason;
            //int seasonSpring = allSeason & Spring;
            //int seasonSummer = allSeason & Summer;
            //int seasonOuthum = allSeason & Othum;

            Console.WriteLine($"сезон пор года {allSeason}");

            if (ifWinter)
            {
                Console.WriteLine("Зима");
            }

            if (ifSummer)
            {
                Console.WriteLine("Summer");
            }
            if (ifOuthum)
            {
                Console.WriteLine("Outhum");
            }
            if (ifSpring)
            {
                Console.WriteLine("Spring");
            }





           // первое задание 1

            Console.WriteLine("ввидите минимальную температуру ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввидите максимальную температуру ");
            int t2 = Convert.ToInt32(Console.ReadLine());
            int sum = (t1 + t2) / 2;
            Console.WriteLine($"Среднее {sum}");



            //задание 2 и 4

            Console.WriteLine("Ввидите порядковый номер месяца");
            Console.Write("Январь=1\nФевраль=2\nАпрель=3\nМарт=4\n");
            var aa11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввидите темпертуру");
            int b2 = Convert.ToInt32(Console.ReadLine());


            switch (aa11)
            {
                case (int)Winterrr.April:
                    Console.WriteLine("Апрель");
                    break;
                case (int)Winterrr.February:
                    Console.WriteLine("Февраль");
                    if (b2 > 0)
                    {
                        Console.WriteLine("Жождливая зима");
                    }
                    break;
                case (int)Winterrr.January:
                    Console.WriteLine("Январь");
                    break;
                case (int)Winterrr.March:
                    Console.WriteLine("Март");
                    break;
            }


            //третье  задание 3
            Console.WriteLine("ввидите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("число четное ");

            }





            //четвертое заданиe 4




            //пятое задание 5

            DayofWorking dayofWorkingFirstOfice = DayofWorking.Tuesday | DayofWorking.Wednesday |  DayofWorking.Friday;
            Console.WriteLine($"Рабочие дни первого офиса {dayofWorkingFirstOfice}\n");
            DayofWorking dayofWorkingSecondOfice = DayofWorking.Saturday | DayofWorking.Sunday | DayofWorking.Monday;
            Console.WriteLine($"Рабочие дние второго офиса {dayofWorkingSecondOfice}");

        }
    }
}
