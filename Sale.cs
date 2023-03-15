using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT
{
    internal class Sale
    {

        /// <summary>
        /// Lägga till ett sälj av bil
        /// </summary>
        public static void Sälj()
        {
            Program.InputRequest("Vad heter Köparen", true);

            var kIn = Console.ReadLine();
            DataStorage.buyers.Add(kIn);
            Console.Clear();

            Program.UtMenu(DataStorage.bilarna);
            Program.InputRequest("Vilken önskas?", false);


            var bilVal = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Försäljning till {kIn} har registrerats, kolla kvitton för mer info.");

            DataStorage.kvittona.Add($"Kund: {kIn}. Vald bil: {DataStorage.bilarna[bilVal - 1].ToString()} --> Hanterad av: {DataStorage.personal[0].ToString()}");

            DataStorage.bilarna.RemoveAt(bilVal - 1);
            Console.ReadKey();
            Console.Clear();




        }


        /// <summary>
        /// Lägga till ett inköp av bil från privatperson
        /// </summary>
        public static void Köp()
        {
            Program.InputRequest("Vem köpes bil av?", true);

            var Sin = Console.ReadLine();
            DataStorage.sellers.Add(Sin);
            Console.Clear();

            Program.InputRequest("Vad för sorts bil erbjuds?");
            var Sbil = Console.ReadLine();
            DataStorage.bilarna.Add(Sbil);
            Console.Clear();

            Console.WriteLine($"Köp från {Sin} har registrerats, Kolla kvitton för mer info.");
            DataStorage.kvittona.Add($"Säljare: {Sin}. Införskaffad bil: {Sbil} --> Hanterad av: {DataStorage.personal[0].ToString()}");

            DataStorage.sellers.Clear();
            Console.ReadKey();

        }


        /// <summary>
        /// Sälj startMeny
        /// </summary>
        public static void SäljMeny()
        {
            while (true)
            {

                Program.UtMenu(new[] { "Sälj", "Köp", "Kvitton", "Avbryt" });

                switch (Program.ReadMenyVal())
                {
                    case 1:
                        Sälj();
                        continue;

                    case 2:
                        Köp();
                        continue;

                    case 3:
                        Console.WriteLine("Antal inlägg {0}", DataStorage.kvittona.Count);
                        Console.WriteLine();
                        Program.indexListaItems(DataStorage.kvittona);
                        Console.Write("> ");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    case 4:
                        Program.StartMeny();
                        break;
                    default:
                        Program.BadMenyVal();
                        continue;
                }

                break;
            }
        }




    }
}
