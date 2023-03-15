namespace ConsoleAppT
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StartMeny();
        }

        /// <summary>
        /// Metod för att avsluta ett program
        /// </summary>
        public static void Avslut()
        {
            Console.WriteLine("Hejdå, ha en bra dag.");
            Console.WriteLine("Tryck på valfri knapp för att avsluta...");
            Console.ReadKey();
            System.Environment.Exit(0);

        }
        /// <summary>
        /// metod för Inläsning av text
        /// </summary>
        /// <param name="title"></param>
        /// <param name="clear"></param>
        public static void InputRequest(string title, bool clear = false)
        {
            if (clear) Console.Clear();

            Console.WriteLine(title);
            Console.WriteLine();
            Console.Write("> ");
        }

        /// <summary>
        /// metod för att skriva ut en lista med index som tar emot en lista som en parameter.
        /// </summary>
        /// <param name="list"></param>
        public static void UtMenu(IEnumerable<string> list)
        {
            var items = list.Select((n, i) => $"{i + 1}. {n}");
            var str = string.Join(Environment.NewLine, items);

            Console.WriteLine(str);
            Console.WriteLine();
            Console.Write("> ");
        }

        /// <summary>
        /// funktion som läser av indata vid ett menyval
        /// </summary>
        /// <returns></returns>
        public static int ReadMenyVal()
        {
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var i)) return -1;
            Console.Clear();
            return i;
        }

        /// <summary>
        /// hanterar ogiltiga val
        /// </summary>
        public static void BadMenyVal()
        {
            Console.Clear();
            Console.WriteLine("Dåligt val, gör om.");
            Console.WriteLine();

        }


        /// <summary>
        /// Skriver ut en lista med index som börjar på 1
        /// </summary>
        /// <param name="lista"></param>
        public static void indexListaItems(List<string> lista)
        {
            Console.WriteLine(
            String.Join(
            Environment.NewLine,
            lista.Select((namn, index) => $"{index + 1}. {namn}")));

        }



        /// <summary>
        /// StartMeny
        /// </summary>
        public static void StartMeny()
        {
            while (true)
            {
                Console.WriteLine("StartMeny");
                Console.WriteLine();
                UtMenu(new[] { "Personal", "Sälj", "Ärenden", "Hantera Bilar", "Avsluta" });

                switch (ReadMenyVal())
                {
                    case 1: // Personal
                        Console.WriteLine("Personal");
                        Console.WriteLine();
                        Staff.PersonalMeny();
                        break;

                    case 2:
                        Console.WriteLine("Sälj");
                        Console.WriteLine();
                        Sale.SäljMeny();
                        break;

                    case 3:
                        Console.WriteLine("Ärendehantering");
                        Console.WriteLine();
                        Task.TodoMeny();

                        break;

                    case 4:
                        Console.WriteLine("Garaget");
                        CarsMenu.hanteraBilar();
                        break;

                    case 5:
                        Avslut();
                        break;
                    default:
                        Console.Clear();
                        BadMenyVal();

                        continue;

                }

                break;
            }
        }




    }
}
