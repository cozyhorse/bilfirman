using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT
{
    internal class Staff
    {
        /// <summary>
        /// hanterar instämpling av personal och kollar om det är mer än 1 inloggad
        /// </summary>
        public static void logInCheck()
        {
            while (true)
            {
                // kollar om det är mer än 1 person inloggad
                if (DataStorage.personal.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Det jobbar bara en här! ok?");
                    Console.WriteLine("Be den andra personen stämpla ut först.");
                }
                else
                {
                    Program.InputRequest("Skriv ditt namn:", true);

                    var input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                        continue;
                    DataStorage.personal.Add(input);

                    Console.Clear();
                    Console.WriteLine($"Hej Och välkommen till jobbet {input}\n{DateTime.Now}");
                    Program.StartMeny();
                }

                Console.WriteLine();

                break;
            }
        }


        /// <summary>
        /// hanterar utstämpling
        /// </summary>
        public static void logOutCheck()
        {
            Console.Clear();
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    DataStorage.personal.Select(namn => $"hejdå och bra jobbat idag {namn}!")));

            DataStorage.personal.Clear();
            Program.StartMeny();
        }



        /// <summary>
        /// Hanterar personal
        /// </summary>
        public static void PersonalMeny()
        {
            while (true)
            {

                Program.UtMenu(new[] { "Stämpla in", "Stämpla ut", "Avbryt" });

                switch (Program.ReadMenyVal())
                {
                    case 1:
                        Console.WriteLine();
                        logInCheck();
                        continue;

                    case 2:
                        logOutCheck();
                        continue;
                    case 3:
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
