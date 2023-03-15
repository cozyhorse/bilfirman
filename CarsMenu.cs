using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT
{
    internal class CarsMenu
    {

        /// <summary>
        /// Lägger till i en lista baserat på parameter
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="item"></param>
        public static void AddItem(List<string> lista, string item) => lista.Add(item);


        /// <summary>
        /// Tar bort från en lista baserat på parameter
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="item"></param>
        public static void PopCar(List<string> lista, int item) => lista.RemoveAt(item - 1);


        /// <summary>
        /// lägg till bilar i garage
        /// </summary>
        public static void AddBil()
        {
            Program.InputRequest("Lägg till en bil", true);

            var addCar = Console.ReadLine();

            AddItem(DataStorage.bilarna, addCar);
            Console.Clear();

        }


        /// <summary>
        /// hanterar radering utav bil
        /// </summary>
        public static void PopBil()
        {
            Program.UtMenu(DataStorage.bilarna);
            Console.WriteLine();
            Program.InputRequest("Vilken bil vill du radera?", false);
            var bilR = Int32.Parse(Console.ReadLine());
            PopCar(DataStorage.bilarna, bilR);
            Console.Clear();
        }


        /// <summary>
        /// Hanterar bilarna
        /// </summary>
        public static void hanteraBilar()
        {


            while (true)
            {
                Console.WriteLine("Bilar i Garaget {0}", DataStorage.bilarna.Count);
                Console.WriteLine();
                Program.UtMenu(DataStorage.bilarna);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();
                Program.UtMenu(new[] { "Lägg till bil", "Radera bil", "Avbryt" });

                switch (Program.ReadMenyVal())
                {
                    case 1:
                        AddBil();
                        continue;

                    case 2:
                        PopBil();
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
