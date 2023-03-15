using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppT
{
    internal class Task
    {

        /// <summary>
        /// Lägga till ärende
        /// </summary>
        public static void AddTodo()
        {
            Program.InputRequest("Vilken bil gäller det?", true);
            var InDo = Console.ReadLine();
            Console.Clear();
            Program.InputRequest("Beskriv felet", true);
            var BeDo = Console.ReadLine();
            Console.Clear();

            DataStorage.ToDo.Add($"Ärende: {InDo}, {BeDo} --> Inlagt av: {DataStorage.personal[0].ToString()}");

            Console.WriteLine("Ärende inlagt!");
            Console.ReadKey();
            Console.Clear();

            TodoMeny();


        }


        /// <summary>
        /// Ta bort ärende
        /// </summary>
        public static void ClearTodo()
        {

            Program.UtMenu(DataStorage.ToDo);

            Program.InputRequest("Vilket ärende har hanterats?", false);
            var Cin = Int32.Parse(Console.ReadLine());
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            DataStorage.ResolveTodo.Add($"{DataStorage.ToDo[Cin - 1].ToString()} -> Hanterad av {DataStorage.personal[0].ToString()}");

            DataStorage.ToDo.RemoveAt(Cin - 1);
            Program.UtMenu(DataStorage.ResolveTodo);
            Console.Clear();
            Console.WriteLine("Ärendet hanterat!");

            Console.ReadKey();
            Console.Clear();
        }


        /// <summary>
        /// Todo startMeny
        /// </summary>
        public static void TodoMeny()
        {

            while (true)
            {

                Console.WriteLine("Ärenden att hantera: {0}", DataStorage.ToDo.Count);
                Program.UtMenu(DataStorage.ToDo);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Ärenden hanterad: {0}", DataStorage.ResolveTodo.Count);
                Program.UtMenu(DataStorage.ResolveTodo);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();


                Program.UtMenu(new[] { "Lägg till ärende", "Radera ärende", "Avbryt" });

                switch (Program.ReadMenyVal())
                {
                    case 1:
                        AddTodo();
                        Console.ReadKey();
                        continue;


                    case 2:
                        ClearTodo();
                        continue;

                    case 3:
                        Program.StartMeny();
                        Console.ReadKey();
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
