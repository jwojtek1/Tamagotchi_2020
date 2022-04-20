using System;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Pies : Cialo
    {
        public static void GraPies()
        {
            Tamagochi.Cialo.Sytosc += 5;
            Tamagochi.Cialo.Zdrowie += 7;
            Tamagochi.Cialo.Higiena += 6;

            for (; ; )
            {


                Tamagochi.Cialo.WyborPieska();

                Random los = new Random();
                int a = los.Next(1, 30);

                if (a < 9)
                {
                    Tamagochi.Cialo.Sytosc -= 2;
                }
                else if (a > 19)
                {
                    Tamagochi.Cialo.Zdrowie -= 1;
                }
                else
                {
                    Tamagochi.Cialo.Higiena -= 1;
                }
                Console.WriteLine("1 - umyj  // 2 - wylecz // 3 - nakarm // 4 - sprzątaj odchody");
                string decyzja = Console.ReadLine();

                if (decyzja == "1")
                {
                    Tamagochi.Cialo.Higiena += 1;
                }
                else if (decyzja == "2")
                {
                    Tamagochi.Cialo.Zdrowie += 1;
                }
                else if (decyzja == "3")
                {
                    Tamagochi.Cialo.Sytosc += 1;
                }
                else if (decyzja == "4")
                {
                    Tamagochi.Cialo.Odchody -= 4;

                }
                else
                {
                    Console.WriteLine("Wybierz 1 lub 2 lub 3!");
                }

                if (Tamagochi.Cialo.Sytosc <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Zagłodziłeś swojego psiaka!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Twój wynik to: " + Dzien + " dni");
                    Console.ReadKey();
                    return;
                }
                else if (Tamagochi.Cialo.Higiena <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Twój psiak zdechł z brudu!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Twój wynik to: " + Dzien + " dni");
                    Console.ReadKey();
                    return;
                }
                else if (Tamagochi.Cialo.Zdrowie <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Twój psiak umarł! ;(");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Twój wynik to: " + Dzien + " dni");
                    Console.ReadKey();
                    return;
                }
                else if (Tamagochi.Cialo.Odchody > 6)
                {
                    Tamagochi.Cialo.Higiena -= 1;
                }
                else
                {

                }
                Tamagochi.Cialo.Dzien += 1;

                Thread.Sleep(1000);


            }

        }
    }
}
